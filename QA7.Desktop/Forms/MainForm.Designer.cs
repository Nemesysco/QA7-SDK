namespace QA7.Desktop.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.txtAudioFile = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbCalibrationType = new System.Windows.Forms.ComboBox();
            this.lblCalibrationType = new System.Windows.Forms.Label();
            this.rtbTextualReport = new System.Windows.Forms.RichTextBox();
            this.lblSegmentsReport = new System.Windows.Forms.Label();
            this.lblReportSummary = new System.Windows.Forms.Label();
            this.lblTextualReport = new System.Windows.Forms.Label();
            this.lblBackgroundNoiseLevel = new System.Windows.Forms.Label();
            this.txtBackgroundNoiseLevel = new System.Windows.Forms.NumericUpDown();
            this.chkBatchAnalysis = new System.Windows.Forms.CheckBox();
            this.chkAutoAmplify = new System.Windows.Forms.CheckBox();
            this.chkConvertToMono = new System.Windows.Forms.CheckBox();
            this.pnlConfigurationPanel = new System.Windows.Forms.Panel();
            this.chkShowResultGrid = new System.Windows.Forms.CheckBox();
            this.lblSegmentLength = new System.Windows.Forms.Label();
            this.chkAutoCSVExport = new System.Windows.Forms.CheckBox();
            this.txtSegmentLength = new System.Windows.Forms.NumericUpDown();
            this.lblConfigurationPanel = new System.Windows.Forms.Label();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.dgvSegments = new System.Windows.Forms.DataGridView();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnOpenReportsFolder = new System.Windows.Forms.Button();
            this.btnLicense = new System.Windows.Forms.Button();
            this.btnShowJsonOutput = new System.Windows.Forms.Button();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.lblConsole = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvEdp = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackgroundNoiseLevel)).BeginInit();
            this.pnlConfigurationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSegmentLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnalyze.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnAnalyze.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAnalyze.Location = new System.Drawing.Point(642, 91);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(147, 25);
            this.btnAnalyze.TabIndex = 46;
            this.btnAnalyze.Text = "ANALYZE";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // txtAudioFile
            // 
            this.txtAudioFile.BackColor = System.Drawing.Color.LightGray;
            this.txtAudioFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAudioFile.Location = new System.Drawing.Point(169, 91);
            this.txtAudioFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtAudioFile.Multiline = true;
            this.txtAudioFile.Name = "txtAudioFile";
            this.txtAudioFile.ReadOnly = true;
            this.txtAudioFile.Size = new System.Drawing.Size(467, 25);
            this.txtAudioFile.TabIndex = 48;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnChooseFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseFile.Location = new System.Drawing.Point(17, 91);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(147, 25);
            this.btnChooseFile.TabIndex = 47;
            this.btnChooseFile.Text = "CHOOSE FILE";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Location = new System.Drawing.Point(1239, 18);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 5, 50, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 25);
            this.btnExit.TabIndex = 52;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbCalibrationType
            // 
            this.cmbCalibrationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalibrationType.FormattingEnabled = true;
            this.cmbCalibrationType.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbCalibrationType.Location = new System.Drawing.Point(157, 9);
            this.cmbCalibrationType.Name = "cmbCalibrationType";
            this.cmbCalibrationType.Size = new System.Drawing.Size(52, 23);
            this.cmbCalibrationType.TabIndex = 59;
            // 
            // lblCalibrationType
            // 
            this.lblCalibrationType.AutoSize = true;
            this.lblCalibrationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalibrationType.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCalibrationType.Location = new System.Drawing.Point(11, 11);
            this.lblCalibrationType.Name = "lblCalibrationType";
            this.lblCalibrationType.Size = new System.Drawing.Size(95, 15);
            this.lblCalibrationType.TabIndex = 60;
            this.lblCalibrationType.Text = "Calibration Type";
            // 
            // rtbTextualReport
            // 
            this.rtbTextualReport.BackColor = System.Drawing.Color.Silver;
            this.rtbTextualReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rtbTextualReport.Location = new System.Drawing.Point(632, 591);
            this.rtbTextualReport.Name = "rtbTextualReport";
            this.rtbTextualReport.ReadOnly = true;
            this.rtbTextualReport.Size = new System.Drawing.Size(393, 203);
            this.rtbTextualReport.TabIndex = 76;
            this.rtbTextualReport.Text = "";
            // 
            // lblSegmentsReport
            // 
            this.lblSegmentsReport.AutoSize = true;
            this.lblSegmentsReport.BackColor = System.Drawing.Color.Transparent;
            this.lblSegmentsReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblSegmentsReport.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblSegmentsReport.Location = new System.Drawing.Point(13, 266);
            this.lblSegmentsReport.Name = "lblSegmentsReport";
            this.lblSegmentsReport.Size = new System.Drawing.Size(108, 13);
            this.lblSegmentsReport.TabIndex = 50;
            this.lblSegmentsReport.Text = "SEGMENTS REPORT";
            // 
            // lblReportSummary
            // 
            this.lblReportSummary.AutoSize = true;
            this.lblReportSummary.BackColor = System.Drawing.Color.Transparent;
            this.lblReportSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblReportSummary.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblReportSummary.Location = new System.Drawing.Point(13, 131);
            this.lblReportSummary.Name = "lblReportSummary";
            this.lblReportSummary.Size = new System.Drawing.Size(104, 13);
            this.lblReportSummary.TabIndex = 77;
            this.lblReportSummary.Text = "REPORT SUMMARY";
            // 
            // lblTextualReport
            // 
            this.lblTextualReport.AutoSize = true;
            this.lblTextualReport.BackColor = System.Drawing.Color.Transparent;
            this.lblTextualReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblTextualReport.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTextualReport.Location = new System.Drawing.Point(629, 571);
            this.lblTextualReport.Name = "lblTextualReport";
            this.lblTextualReport.Size = new System.Drawing.Size(95, 13);
            this.lblTextualReport.TabIndex = 78;
            this.lblTextualReport.Text = "TEXTUAL REPORT";
            // 
            // lblBackgroundNoiseLevel
            // 
            this.lblBackgroundNoiseLevel.AutoSize = true;
            this.lblBackgroundNoiseLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackgroundNoiseLevel.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBackgroundNoiseLevel.Location = new System.Drawing.Point(11, 38);
            this.lblBackgroundNoiseLevel.Name = "lblBackgroundNoiseLevel";
            this.lblBackgroundNoiseLevel.Size = new System.Drawing.Size(140, 15);
            this.lblBackgroundNoiseLevel.TabIndex = 79;
            this.lblBackgroundNoiseLevel.Text = "Background Noise Level";
            // 
            // txtBackgroundNoiseLevel
            // 
            this.txtBackgroundNoiseLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackgroundNoiseLevel.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtBackgroundNoiseLevel.Location = new System.Drawing.Point(157, 38);
            this.txtBackgroundNoiseLevel.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtBackgroundNoiseLevel.Name = "txtBackgroundNoiseLevel";
            this.txtBackgroundNoiseLevel.Size = new System.Drawing.Size(52, 21);
            this.txtBackgroundNoiseLevel.TabIndex = 80;
            this.txtBackgroundNoiseLevel.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // chkBatchAnalysis
            // 
            this.chkBatchAnalysis.AutoSize = true;
            this.chkBatchAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBatchAnalysis.ForeColor = System.Drawing.SystemColors.Window;
            this.chkBatchAnalysis.Location = new System.Drawing.Point(14, 95);
            this.chkBatchAnalysis.Name = "chkBatchAnalysis";
            this.chkBatchAnalysis.Size = new System.Drawing.Size(104, 19);
            this.chkBatchAnalysis.TabIndex = 82;
            this.chkBatchAnalysis.Text = "Batch Analysis";
            this.chkBatchAnalysis.UseVisualStyleBackColor = true;
            this.chkBatchAnalysis.CheckedChanged += new System.EventHandler(this.chkBatchAnalysis_CheckedChanged);
            // 
            // chkAutoAmplify
            // 
            this.chkAutoAmplify.AutoSize = true;
            this.chkAutoAmplify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoAmplify.ForeColor = System.Drawing.SystemColors.Window;
            this.chkAutoAmplify.Location = new System.Drawing.Point(14, 141);
            this.chkAutoAmplify.Name = "chkAutoAmplify";
            this.chkAutoAmplify.Size = new System.Drawing.Size(92, 19);
            this.chkAutoAmplify.TabIndex = 85;
            this.chkAutoAmplify.Text = "Auto Amplify";
            this.chkAutoAmplify.UseVisualStyleBackColor = true;
            // 
            // chkConvertToMono
            // 
            this.chkConvertToMono.AutoSize = true;
            this.chkConvertToMono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConvertToMono.ForeColor = System.Drawing.SystemColors.Window;
            this.chkConvertToMono.Location = new System.Drawing.Point(14, 164);
            this.chkConvertToMono.Name = "chkConvertToMono";
            this.chkConvertToMono.Size = new System.Drawing.Size(119, 19);
            this.chkConvertToMono.TabIndex = 88;
            this.chkConvertToMono.Text = "Convert To Mono";
            this.chkConvertToMono.UseVisualStyleBackColor = true;
            // 
            // pnlConfigurationPanel
            // 
            this.pnlConfigurationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlConfigurationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfigurationPanel.Controls.Add(this.chkShowResultGrid);
            this.pnlConfigurationPanel.Controls.Add(this.lblBackgroundNoiseLevel);
            this.pnlConfigurationPanel.Controls.Add(this.txtBackgroundNoiseLevel);
            this.pnlConfigurationPanel.Controls.Add(this.lblCalibrationType);
            this.pnlConfigurationPanel.Controls.Add(this.cmbCalibrationType);
            this.pnlConfigurationPanel.Controls.Add(this.lblSegmentLength);
            this.pnlConfigurationPanel.Controls.Add(this.chkAutoCSVExport);
            this.pnlConfigurationPanel.Controls.Add(this.txtSegmentLength);
            this.pnlConfigurationPanel.Controls.Add(this.chkAutoAmplify);
            this.pnlConfigurationPanel.Controls.Add(this.chkConvertToMono);
            this.pnlConfigurationPanel.Controls.Add(this.chkBatchAnalysis);
            this.pnlConfigurationPanel.Location = new System.Drawing.Point(352, 591);
            this.pnlConfigurationPanel.Name = "pnlConfigurationPanel";
            this.pnlConfigurationPanel.Size = new System.Drawing.Size(274, 203);
            this.pnlConfigurationPanel.TabIndex = 89;
            // 
            // chkShowResultGrid
            // 
            this.chkShowResultGrid.AutoSize = true;
            this.chkShowResultGrid.Checked = true;
            this.chkShowResultGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowResultGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowResultGrid.ForeColor = System.Drawing.SystemColors.Window;
            this.chkShowResultGrid.Location = new System.Drawing.Point(139, 164);
            this.chkShowResultGrid.Name = "chkShowResultGrid";
            this.chkShowResultGrid.Size = new System.Drawing.Size(121, 19);
            this.chkShowResultGrid.TabIndex = 113;
            this.chkShowResultGrid.Text = "Show Result Grid";
            this.chkShowResultGrid.UseVisualStyleBackColor = true;
            // 
            // lblSegmentLength
            // 
            this.lblSegmentLength.AutoSize = true;
            this.lblSegmentLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegmentLength.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSegmentLength.Location = new System.Drawing.Point(11, 67);
            this.lblSegmentLength.Name = "lblSegmentLength";
            this.lblSegmentLength.Size = new System.Drawing.Size(98, 15);
            this.lblSegmentLength.TabIndex = 103;
            this.lblSegmentLength.Text = "Segment Length";
            // 
            // chkAutoCSVExport
            // 
            this.chkAutoCSVExport.AutoSize = true;
            this.chkAutoCSVExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoCSVExport.ForeColor = System.Drawing.SystemColors.Window;
            this.chkAutoCSVExport.Location = new System.Drawing.Point(14, 118);
            this.chkAutoCSVExport.Name = "chkAutoCSVExport";
            this.chkAutoCSVExport.Size = new System.Drawing.Size(114, 19);
            this.chkAutoCSVExport.TabIndex = 102;
            this.chkAutoCSVExport.Text = "Auto CSV Export";
            this.chkAutoCSVExport.UseVisualStyleBackColor = true;
            // 
            // txtSegmentLength
            // 
            this.txtSegmentLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegmentLength.Location = new System.Drawing.Point(157, 65);
            this.txtSegmentLength.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtSegmentLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSegmentLength.Name = "txtSegmentLength";
            this.txtSegmentLength.Size = new System.Drawing.Size(52, 21);
            this.txtSegmentLength.TabIndex = 104;
            this.txtSegmentLength.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblConfigurationPanel
            // 
            this.lblConfigurationPanel.AutoSize = true;
            this.lblConfigurationPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblConfigurationPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblConfigurationPanel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblConfigurationPanel.Location = new System.Drawing.Point(351, 571);
            this.lblConfigurationPanel.Name = "lblConfigurationPanel";
            this.lblConfigurationPanel.Size = new System.Drawing.Size(127, 13);
            this.lblConfigurationPanel.TabIndex = 102;
            this.lblConfigurationPanel.Text = "CONFIGURATION PANEL";
            // 
            // dgvReportSummary
            // 
            this.dgvSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Location = new System.Drawing.Point(13, 148);
            this.dgvSummary.Margin = new System.Windows.Forms.Padding(10);
            this.dgvSummary.Name = "dgvReportSummary";
            this.dgvSummary.ReadOnly = true;
            this.dgvSummary.RowHeadersWidth = 62;
            this.dgvSummary.Size = new System.Drawing.Size(1372, 108);
            this.dgvSummary.TabIndex = 89;
            this.dgvSummary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportSummary_CellContentClick);
            // 
            // dgvSegmentsReport
            // 
            this.dgvSegments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSegments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSegments.Location = new System.Drawing.Point(13, 286);
            this.dgvSegments.Name = "dgvSegmentsReport";
            this.dgvSegments.ReadOnly = true;
            this.dgvSegments.RowHeadersWidth = 62;
            this.dgvSegments.Size = new System.Drawing.Size(1372, 274);
            this.dgvSegments.TabIndex = 108;
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnCopyToClipboard.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(1030, 523);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(169, 25);
            this.btnCopyToClipboard.TabIndex = 105;
            this.btnCopyToClipboard.Text = "COPY TO CLIPBOARD";
            this.btnCopyToClipboard.UseVisualStyleBackColor = false;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnOpenReportsFolder
            // 
            this.btnOpenReportsFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenReportsFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenReportsFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnOpenReportsFolder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOpenReportsFolder.Location = new System.Drawing.Point(1203, 523);
            this.btnOpenReportsFolder.Name = "btnOpenReportsFolder";
            this.btnOpenReportsFolder.Size = new System.Drawing.Size(169, 25);
            this.btnOpenReportsFolder.TabIndex = 109;
            this.btnOpenReportsFolder.Text = "OPEN REPORTS FOLDER";
            this.btnOpenReportsFolder.UseVisualStyleBackColor = false;
            this.btnOpenReportsFolder.Click += new System.EventHandler(this.btnOpenReportsFolder_Click);
            // 
            // btnLicense
            // 
            this.btnLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnLicense.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLicense.Location = new System.Drawing.Point(1238, 47);
            this.btnLicense.Margin = new System.Windows.Forms.Padding(5);
            this.btnLicense.Name = "btnLicense";
            this.btnLicense.Size = new System.Drawing.Size(147, 25);
            this.btnLicense.TabIndex = 110;
            this.btnLicense.Text = "LICENSE";
            this.btnLicense.UseVisualStyleBackColor = true;
            this.btnLicense.Click += new System.EventHandler(this.btnLicense_Click);
            // 
            // btnShowJsonOutput
            // 
            this.btnShowJsonOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowJsonOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowJsonOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnShowJsonOutput.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnShowJsonOutput.Location = new System.Drawing.Point(856, 523);
            this.btnShowJsonOutput.Name = "btnShowJsonOutput";
            this.btnShowJsonOutput.Size = new System.Drawing.Size(169, 25);
            this.btnShowJsonOutput.TabIndex = 110;
            this.btnShowJsonOutput.Text = "SHOW [JSON] OUTPUT";
            this.btnShowJsonOutput.UseVisualStyleBackColor = false;
            this.btnShowJsonOutput.Click += new System.EventHandler(this.btnShowJsonOutput_Click);
            // 
            // rtbConsole
            // 
            this.rtbConsole.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtbConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConsole.ForeColor = System.Drawing.Color.Ivory;
            this.rtbConsole.Location = new System.Drawing.Point(17, 591);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(329, 203);
            this.rtbConsole.TabIndex = 58;
            this.rtbConsole.Text = "{{CONSOLE TEXT}}";
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.BackColor = System.Drawing.Color.Transparent;
            this.lblConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblConsole.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblConsole.Location = new System.Drawing.Point(16, 571);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(57, 13);
            this.lblConsole.TabIndex = 97;
            this.lblConsole.Text = "CONSOLE";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picLogo.ErrorImage")));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(17, 23);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(172, 37);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 92;
            this.picLogo.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.AllowDrop = true;
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnShowJsonOutput);
            this.pnlMain.Controls.Add(this.btnOpenReportsFolder);
            this.pnlMain.Controls.Add(this.btnCopyToClipboard);
            this.pnlMain.Controls.Add(this.dgvSummary);
            this.pnlMain.Controls.Add(this.lblStatus);
            this.pnlMain.Controls.Add(this.dgvEdp);
            this.pnlMain.Controls.Add(this.dgvSegments);
            this.pnlMain.Controls.Add(this.btnLicense);
            this.pnlMain.Controls.Add(this.picLogo);
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.lblConsole);
            this.pnlMain.Controls.Add(this.rtbConsole);
            this.pnlMain.Controls.Add(this.rtbTextualReport);
            this.pnlMain.Controls.Add(this.pnlConfigurationPanel);
            this.pnlMain.Controls.Add(this.lblReportSummary);
            this.pnlMain.Controls.Add(this.lblConfigurationPanel);
            this.pnlMain.Controls.Add(this.lblSegmentsReport);
            this.pnlMain.Controls.Add(this.lblTextualReport);
            this.pnlMain.Controls.Add(this.txtAudioFile);
            this.pnlMain.Controls.Add(this.btnChooseFile);
            this.pnlMain.Controls.Add(this.btnAnalyze);
            this.pnlMain.Location = new System.Drawing.Point(-2, -2);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1418, 802);
            this.pnlMain.TabIndex = 89;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus.Location = new System.Drawing.Point(807, 91);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 25);
            this.lblStatus.TabIndex = 112;
            this.lblStatus.Text = "STATUS";
            this.lblStatus.Visible = false;
            // 
            // dgvEdp
            // 
            this.dgvEdp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdp.Location = new System.Drawing.Point(1031, 591);
            this.dgvEdp.Name = "dgvEdp";
            this.dgvEdp.ReadOnly = true;
            this.dgvEdp.RowHeadersWidth = 62;
            this.dgvEdp.Size = new System.Drawing.Size(354, 202);
            this.dgvEdp.TabIndex = 111;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1415, 800);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtBackgroundNoiseLevel)).EndInit();
            this.pnlConfigurationPanel.ResumeLayout(false);
            this.pnlConfigurationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSegmentLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSegments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.TextBox txtAudioFile;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbCalibrationType;
        private System.Windows.Forms.Label lblCalibrationType;
        private System.Windows.Forms.RichTextBox rtbTextualReport;
        private System.Windows.Forms.Label lblSegmentsReport;
        private System.Windows.Forms.Label lblReportSummary;
        private System.Windows.Forms.Label lblTextualReport;
        private System.Windows.Forms.Label lblBackgroundNoiseLevel;
        private System.Windows.Forms.NumericUpDown txtBackgroundNoiseLevel;
        private System.Windows.Forms.CheckBox chkBatchAnalysis;
        private System.Windows.Forms.CheckBox chkAutoAmplify;
        private System.Windows.Forms.CheckBox chkConvertToMono;
        private System.Windows.Forms.Panel pnlConfigurationPanel;
        private System.Windows.Forms.CheckBox chkAutoCSVExport;
        private System.Windows.Forms.Label lblSegmentLength;
        private System.Windows.Forms.NumericUpDown txtSegmentLength;
        private System.Windows.Forms.Label lblConfigurationPanel;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.DataGridView dgvSegments;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnOpenReportsFolder;
        private System.Windows.Forms.Button btnLicense;
        private System.Windows.Forms.Button btnShowJsonOutput;
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvEdp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkShowResultGrid;
    }
}

