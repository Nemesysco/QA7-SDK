using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NMS.Core.Entities;
using NMS.Core.Utility;
using NMS.Core.Utility.Converters;
using NMS.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QA7.Desktop.Core.Utility;
using QA7.Desktop.Core.Extensions;

namespace QA7.Desktop.Forms
{
    public partial class MainForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private readonly string FFMpegPath = Application.StartupPath + @"\Tools\ffmpeg.exe";


        private StringBuilder _sb = new StringBuilder(); // TODO: AG: ???
        private NmsAnalysis _analysis = new NmsAnalysis();
        
        private string _inputAppID = "QA7";
        private List<NmsAnalysis> _batchJsonResults = new List<NmsAnalysis>();


        public string JsonText { get; set; }
        public string SystemId { get; set; }
        public string LicenseText { get; set; }
        public string DataPath
        {
            get
            {
                var cfg = ConfigUtility.GetValue("DataPath");
                return cfg == string.Empty ? Path.Combine(Application.StartupPath, "Data") : cfg;
            }
        }
        public string ReportsPath
        {
            get
            {
                var cfg = ConfigUtility.GetValue("ReportsPath");
                return cfg == string.Empty ? Path.Combine(Application.StartupPath, "Reports") : cfg;
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        

        public MainForm()
        {
            // Verify multi licenses
            var isMultiLicense = Convert.ToBoolean(ConfigUtility.GetValue("multi"));
            if (isMultiLicense)
            {
                _inputAppID = Microsoft.VisualBasic.Interaction.InputBox("Please provide an AppID", "Tester", "1");
            }

            InitializeComponent();

            pnlMain.Width = this.Width;

            InitFolders();
            InitLicenseInfo();

            cmbCalibrationType.SelectedIndex = 1;

            if (!File.Exists($"{ReportsPath}\\ReportsSummary.csv"))
            {
                var csvHeaders =
                    "Filename;Channel;Call Tag;Duration (# Segments);Highest Quality Priority;Final Quality Priority;Agent Priority Rank;Dissatisfaction;Voice Energy;%Anger;" +
                    "%Stress;%Upset;%Content;Emotional Energy;Energy;SAF;Emotion Level;Uneasyness;Stress;Thinking;Confidence;Concentration;Anticipation;CSC Score;Final 10 Score\r\n";

                File.WriteAllText($"{ReportsPath}\\ReportsSummary.csv", csvHeaders);
            }

            dgvSummary.ConfigureDefault();
            dgvSegments.ConfigureDefault();
            dgvEdp.ConfigureDefault();
        }


        public bool GenerateMonthlyLicense(string code)
        {
            LicenseManager.GetMonthlyLicense(code);
            return true;
        }

        public bool SetLicenseCode(string newLicenseCode)
        {
            int rc = LicenseManager.ResetCounter(newLicenseCode);
            if (rc != 0)
            {
                MessageBox.Show("Error: " + rc.ToString(), "Error");
                NmsLogger.Error(rc.ToString());
                return false;
            }

            MessageBox.Show("Operation Successful", "Success");

            InitLicenseInfo();
            return true;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            rtbConsole.Text = string.Empty;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            PerformReset();

            var dlgOpenFile = new OpenFileDialog
            {
                //Filter =
                //"Audio Files (*.wav;*.mp3;*.wma;*.flac;*.opus;*.ogg;*.amr;*.aiff;*.aac)|*.WAV;*.MP3;*.WMA;*.FLAC;*.OPUS;*.OGG;*.AMR;*.AIFF;*.AAC|" +
                //"Video Files (*.avi;*.mp4;*.mov)|*.AVI;*.MP4;*.MOV|" +
                //"All files (*.*)|*.*",

                Multiselect = chkBatchAnalysis.Checked
            };

            if (dlgOpenFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (chkBatchAnalysis.Checked)
            {
                var files = dlgOpenFile.FileNames.ToList();

                DoAnalysis(files, new AnalysisOptions
                {
                    AnalysisType = (byte)cmbCalibrationType.SelectedIndex,
                    Bglevel = (short)txtBackgroundNoiseLevel.Value,
                    Normalize = chkAutoAmplify.Checked,
                    SetMono = chkConvertToMono.Checked,
                    SegMaxLength = (byte)txtSegmentLength.Value
                });

                return;
            }

            txtAudioFile.Text = dlgOpenFile.FileName;
            btnAnalyze.BackColor = Color.DodgerBlue;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (txtAudioFile.Text.Trim() == string.Empty && !chkBatchAnalysis.Checked)
            {
                MessageBox.Show("Please, choose the audio file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (new WaitCursor())
            {
                lblStatus.ForeColor = Color.White;
                lblStatus.Text = "ANALYZING...";
                lblStatus.Visible = true;

                _analysis.SummaryLine.Clear();

                rtbTextualReport.Clear();
                rtbTextualReport.Text = string.Empty;

                dgvSegments.Visible = true;
                dgvSummary.DataSource = null;
                dgvSegments.DataSource = null;
                dgvEdp.DataSource = null;

                var options = new AnalysisOptions
                {
                    AnalysisType = (byte)cmbCalibrationType.SelectedIndex,
                    Bglevel = (short)txtBackgroundNoiseLevel.Value,
                    Normalize = chkAutoAmplify.Checked,
                    SetMono = chkConvertToMono.Checked,
                    SegMaxLength = (byte)txtSegmentLength.Value
                };

                try
                {
                    using (var manager = new AnalysisManager())
                    {
                        var cFileName = AudioConverter.ToWav(txtAudioFile.Text, FFMpegPath, DataPath, options.SetMono);

                        if (options.Normalize) //Do Normalization if needed
                        {
                            cFileName = NMS.Audio.NmsAudioHelper.SaveFile(cFileName, ConfigurationManager.AppSettings["DataPath"]);
                            cFileName = AudioConverter.ToWav(cFileName, FFMpegPath, DataPath, options.SetMono);
                        }

                        var analysisInfo = manager.ProcessFile(cFileName, options);
                        analysisInfo.AudioFile = Path.GetFileNameWithoutExtension(txtAudioFile.Text);

                        var wavInfo = WavInfo.Get(cFileName);
                        if (wavInfo.NoOfChannels == 2)
                        {
                            var channelsRep = analysisInfo.Summary.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                            _sb.Append($"{analysisInfo.AudioFile} [2 channels];C0{channelsRep[0]}\r\n{analysisInfo.AudioFile} [2 channels];C1;{channelsRep[1]}\r\n");
                        }
                        else
                        {
                            _sb.Append(analysisInfo.AudioFile + ";C0" + analysisInfo.Summary);
                        }

                        var segments = analysisInfo.Segments.Split(new[] { Environment.NewLine }, 
                            StringSplitOptions.RemoveEmptyEntries).ToList();

                        var segResult = new NmsAnalysis();

                        var fileId = Guid.NewGuid();
                        segResult.Segments = manager.GetSegments(analysisInfo, segResult, fileId);
                        segResult.SummaryLine = manager.GetSummaryLines(analysisInfo, segResult, fileId);
                        segResult.CoreType = manager.GetCoreTypes(segResult);

                        dgvSummary.DataSource = segResult.SummaryLine;
                        dgvSegments.DataSource = segResult.Segments;
                        dgvEdp.DataSource = segResult.CoreType;

                        dgvSummary.FormatAnalysis();

                        string json = JsonConvert.SerializeObject(segResult);
                        JsonText = JToken.Parse(json).ToString(Formatting.Indented);

                        rtbTextualReport.Text = analysisInfo.Details;

                        if (chkAutoCSVExport.Checked)
                        {
                            File.WriteAllText($"{ReportsPath}\\{analysisInfo.AudioFile}.csv", analysisInfo.Segments);
                        }
                    }

                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "DONE!";
                }
                catch (Exception ex)
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "ERROR!";

                    rtbConsole.Text = ex.ToString();
                    NmsLogger.Error(ex.ToString());
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure you want to quit the application?", 
                "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (dgvSegments.DataSource == null)
                return;
            
            dgvSegments.SelectAll();
            Clipboard.SetDataObject(dgvSegments.GetClipboardContent());
            btnCopyToClipboard.ForeColor = Color.Green;
            btnCopyToClipboard.Text = "COPIED!";
        }

        private void btnOpenReportsFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(ReportsPath))
            {
                Process.Start(ReportsPath);
            }
        }

        private void btnLicense_Click(object sender, EventArgs e)
        {
            var form = new LicenseForm(this, true);
            form.ShowDialog();
        }

        private void btnShowJsonOutput_Click(object sender, EventArgs e)
        {
            var form = new JsonOutputForm(this);
            form.ShowDialog();
        }

        private void chkBatchAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            dgvSegments.Visible = !chkBatchAnalysis.Checked;

            if (chkBatchAnalysis.Checked) // Batch
                dgvSummary.Height = 439;
            else
                dgvSummary.Height = 86;
        }

        private void dgvReportSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || _batchJsonResults.Count == 0)
            {
                return;
            }

            var fileId = Guid.Parse(dgvSummary.Rows[e.RowIndex].Cells["FileID"].Value.ToString());
            dgvSegments.DataSource = _batchJsonResults[0].Segments.Where(s => s.FileId == fileId).Select(a => a).ToList();
            dgvSegments.Visible = true;
        }


        private void PerformReset()
        {
            btnAnalyze.BackColor = Color.Black;
            rtbConsole.Text = string.Empty;
            rtbTextualReport.Clear();
            dgvSegments.DataSource = null;
            dgvSummary.DataSource = null;
            _sb.Clear();

            lblStatus.Visible = false;
            lblStatus.ForeColor = Color.White;
        }

        private void DoAnalysis(List<string> files, AnalysisOptions options)
        {
            lblStatus.Visible = true;

            for (int i = 0; i < files.Count; i++)
            {
                lblStatus.Invoke((MethodInvoker)(() => lblStatus.Text = "File " + i));

                //Convert
                var cFilename = AudioConverter.ToWav(files[i], FFMpegPath, DataPath, options.SetMono);

                //Analyze
                using (var manager = new AnalysisManager())
                {
                    var analysisOutput = manager.ProcessFile(cFilename, options);

                    if (analysisOutput.Summary == null)
                        return;

                    if (chkShowResultGrid.Checked)
                    {
                        var fileId = Guid.NewGuid();
                        _analysis.SummaryLine = manager.GetSummaryLines(analysisOutput, _analysis, fileId);
                        _analysis.Segments = manager.GetSegments(analysisOutput, _analysis, fileId);
                    }

                    analysisOutput.AudioFile = Path.GetFileNameWithoutExtension(cFilename);

                    var wavInfo = WavInfo.Get(cFilename);
                    if (wavInfo.NoOfChannels == 2)
                    {
                        var channelsRep = analysisOutput.Summary.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        _sb.Append($"{analysisOutput.AudioFile} [2 channels];C0;{channelsRep[0]}\r\n{analysisOutput.AudioFile} [2 channels];C1;{channelsRep[1]}\r\n");
                    }
                    else
                    {
                        _sb.Append(analysisOutput.AudioFile + ";C0;" + analysisOutput.Summary);
                    }
                }
            }

            if (chkShowResultGrid.Checked)
            {
                dgvSegments.Visible = false;
                dgvSummary.DataSource = _analysis.SummaryLine;

                dgvSummary.FormatAnalysis();
            }


            lblStatus.Invoke((MethodInvoker)(() => lblStatus.Text = "DONE: " + files.Count));
            File.AppendAllText($"{ReportsPath}\\ReportsSummary.csv", _sb.ToString());
        }

        private void InitFolders()
        {
            string[] folderCheck = { DataPath, ReportsPath };

            foreach (var dir in folderCheck)
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            };
        }

        private void InitLicenseInfo()
        {
            var rc = LicenseManager.Init(ConfigUtility.GetValue("LicPath"));

            if (rc == -999)
            {
                LicenseManager.Terminate();
                Application.Restart();
                return;
            }

            var info = LicenseManager.GetInfo();
            SystemId = info.SystemId;

            if (info.SystemId.Length == 35 || info.LicensePosts == 0 || rc != 0)
            {
                var form = new LicenseForm(this, false);
                form.ShowDialog();
            }

            LicenseText = LicenseManager.ToString(info);
        }
    }
}
