using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QA7.Desktop.Forms
{
    public partial class JsonOutputForm : Form
    {
        private string ReportsPath { get; set; }


        public JsonOutputForm(MainForm mainForm)
        {
            InitializeComponent();

            ReportsPath = mainForm.ReportsPath;

            rtbOutput.Text = mainForm.JsonText;

            if (rtbOutput.Text == string.Empty)
            {
                btnCopyToClipboard.Enabled = false;
                btnExportToFile.Enabled = false;
            }
        }


        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (rtbOutput.Text != string.Empty)
            {
                Clipboard.SetText(rtbOutput.Text);
                btnCopyToClipboard.ForeColor = Color.Green;
                btnCopyToClipboard.Text = "Copied!";
            }
            else
            {
                btnCopyToClipboard.Enabled = false;
            }
        }

        private void btnExportToFile_Click(object sender, EventArgs e)
        {
            var fileName = Guid.NewGuid().ToString() + ".json";

            using (var sw = new StreamWriter(Path.Combine(ReportsPath, fileName), true))
            {
                sw.WriteLine(rtbOutput.Text);
                sw.Flush();

                btnExportToFile.ForeColor = Color.Green;
                btnExportToFile.Text = "Saved!";

                txtExportPath.Text = Path.Combine(ReportsPath, fileName);
                lblExportPath.Cursor = Cursors.Hand;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblExportPath_Click(object sender, EventArgs e)
        {
            if (txtExportPath.Text == string.Empty)
                return;

            if (Directory.Exists(ReportsPath))
            {
                Process.Start(ReportsPath);
            }
        }
    }
}
