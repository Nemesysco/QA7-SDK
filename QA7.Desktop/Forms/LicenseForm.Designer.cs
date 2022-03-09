namespace QA7.Desktop.Forms
{
    partial class LicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.pnlActivation = new System.Windows.Forms.Panel();
            this.btnActivate = new System.Windows.Forms.Button();
            this.lblCopySystemId = new System.Windows.Forms.Label();
            this.rdoMonthly = new System.Windows.Forms.RadioButton();
            this.rdoActivation = new System.Windows.Forms.RadioButton();
            this.txtSystemId = new System.Windows.Forms.TextBox();
            this.txtNMSFcode = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.lblLicenseInfo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblManualLicense = new System.Windows.Forms.Label();
            this.lblAutomatedLicense = new System.Windows.Forms.Label();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.txtSitePassword = new System.Windows.Forms.TextBox();
            this.lblSiteName = new System.Windows.Forms.Label();
            this.lblSitePassword = new System.Windows.Forms.Label();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.btnRequestLicense = new System.Windows.Forms.Button();
            this.pnlCredentials = new System.Windows.Forms.Panel();
            this.chkSaveCredentials = new System.Windows.Forms.CheckBox();
            this.lblChannels = new System.Windows.Forms.Label();
            this.txtChannels = new System.Windows.Forms.TextBox();
            this.pnlActivation.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlCredentials.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnProcess.Location = new System.Drawing.Point(733, -549);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(110, 22);
            this.btnProcess.TabIndex = 103;
            this.btnProcess.Text = "Activate";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 29);
            this.lblTitle.TabIndex = 106;
            this.lblTitle.Text = "License Activation";
            // 
            // txtProcess
            // 
            this.txtProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtProcess.Location = new System.Drawing.Point(346, -549);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(381, 18);
            this.txtProcess.TabIndex = 102;
            this.txtProcess.Text = "NMSF:";
            // 
            // pnlActivation
            // 
            this.pnlActivation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlActivation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActivation.Controls.Add(this.btnActivate);
            this.pnlActivation.Controls.Add(this.lblCopySystemId);
            this.pnlActivation.Controls.Add(this.rdoMonthly);
            this.pnlActivation.Controls.Add(this.rdoActivation);
            this.pnlActivation.Controls.Add(this.txtSystemId);
            this.pnlActivation.Controls.Add(this.txtNMSFcode);
            this.pnlActivation.Location = new System.Drawing.Point(18, 364);
            this.pnlActivation.Name = "pnlActivation";
            this.pnlActivation.Size = new System.Drawing.Size(631, 126);
            this.pnlActivation.TabIndex = 2;
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnActivate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnActivate.Location = new System.Drawing.Point(396, 83);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(212, 25);
            this.btnActivate.TabIndex = 6;
            this.btnActivate.Text = "ACTIVATE";
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // lblCopySystemId
            // 
            this.lblCopySystemId.AutoSize = true;
            this.lblCopySystemId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopySystemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCopySystemId.ForeColor = System.Drawing.Color.White;
            this.lblCopySystemId.Location = new System.Drawing.Point(266, 27);
            this.lblCopySystemId.Name = "lblCopySystemId";
            this.lblCopySystemId.Size = new System.Drawing.Size(40, 13);
            this.lblCopySystemId.TabIndex = 2;
            this.lblCopySystemId.Text = "COPY";
            this.lblCopySystemId.Click += new System.EventHandler(this.lblCopySystemId_Click);
            // 
            // rdoMonthly
            // 
            this.rdoMonthly.AutoSize = true;
            this.rdoMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.rdoMonthly.ForeColor = System.Drawing.Color.White;
            this.rdoMonthly.Location = new System.Drawing.Point(395, 28);
            this.rdoMonthly.Name = "rdoMonthly";
            this.rdoMonthly.Size = new System.Drawing.Size(121, 17);
            this.rdoMonthly.TabIndex = 5;
            this.rdoMonthly.Text = "MONTHLY LICENSE";
            this.rdoMonthly.UseVisualStyleBackColor = true;
            // 
            // rdoActivation
            // 
            this.rdoActivation.AutoSize = true;
            this.rdoActivation.Checked = true;
            this.rdoActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.rdoActivation.ForeColor = System.Drawing.Color.White;
            this.rdoActivation.Location = new System.Drawing.Point(395, 9);
            this.rdoActivation.Name = "rdoActivation";
            this.rdoActivation.Size = new System.Drawing.Size(84, 17);
            this.rdoActivation.TabIndex = 4;
            this.rdoActivation.TabStop = true;
            this.rdoActivation.Text = "ACTIVATION";
            this.rdoActivation.UseVisualStyleBackColor = true;
            // 
            // txtSystemId
            // 
            this.txtSystemId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSystemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSystemId.Location = new System.Drawing.Point(13, 24);
            this.txtSystemId.Name = "txtSystemId";
            this.txtSystemId.Size = new System.Drawing.Size(250, 20);
            this.txtSystemId.TabIndex = 1;
            // 
            // txtNMSFcode
            // 
            this.txtNMSFcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNMSFcode.Location = new System.Drawing.Point(13, 55);
            this.txtNMSFcode.Name = "txtNMSFcode";
            this.txtNMSFcode.Size = new System.Drawing.Size(594, 20);
            this.txtNMSFcode.TabIndex = 3;
            this.txtNMSFcode.Text = "NMSF:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClose.Location = new System.Drawing.Point(259, 499);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.Gray;
            this.pnlStatus.Controls.Add(this.lblRefresh);
            this.pnlStatus.Controls.Add(this.lblLicenseInfo);
            this.pnlStatus.Location = new System.Drawing.Point(16, 71);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(367, 260);
            this.pnlStatus.TabIndex = 4;
            // 
            // lblRefresh
            // 
            this.lblRefresh.AutoSize = true;
            this.lblRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblRefresh.ForeColor = System.Drawing.SystemColors.Window;
            this.lblRefresh.Location = new System.Drawing.Point(292, 234);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(62, 13);
            this.lblRefresh.TabIndex = 1;
            this.lblRefresh.Text = "REFRESH";
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // lblLicenseInfo
            // 
            this.lblLicenseInfo.AutoSize = true;
            this.lblLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLicenseInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLicenseInfo.Location = new System.Drawing.Point(2, 3);
            this.lblLicenseInfo.Name = "lblLicenseInfo";
            this.lblLicenseInfo.Size = new System.Drawing.Size(123, 15);
            this.lblLicenseInfo.TabIndex = 49;
            this.lblLicenseInfo.Text = "{License Information}";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStatus.Location = new System.Drawing.Point(14, 53);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 13);
            this.lblStatus.TabIndex = 111;
            this.lblStatus.Text = "LICENSE STATUS";
            // 
            // lblManualLicense
            // 
            this.lblManualLicense.AutoSize = true;
            this.lblManualLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblManualLicense.ForeColor = System.Drawing.SystemColors.Window;
            this.lblManualLicense.Location = new System.Drawing.Point(15, 345);
            this.lblManualLicense.Name = "lblManualLicense";
            this.lblManualLicense.Size = new System.Drawing.Size(97, 13);
            this.lblManualLicense.TabIndex = 112;
            this.lblManualLicense.Text = "MANUAL LICENSE";
            // 
            // lblAutomatedLicense
            // 
            this.lblAutomatedLicense.AutoSize = true;
            this.lblAutomatedLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblAutomatedLicense.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAutomatedLicense.Location = new System.Drawing.Point(389, 53);
            this.lblAutomatedLicense.Name = "lblAutomatedLicense";
            this.lblAutomatedLicense.Size = new System.Drawing.Size(117, 13);
            this.lblAutomatedLicense.TabIndex = 113;
            this.lblAutomatedLicense.Text = "AUTOMATED LICENSE";
            // 
            // txtSiteName
            // 
            this.txtSiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiteName.Location = new System.Drawing.Point(22, 31);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(212, 20);
            this.txtSiteName.TabIndex = 1;
            // 
            // txtSitePassword
            // 
            this.txtSitePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSitePassword.Location = new System.Drawing.Point(22, 75);
            this.txtSitePassword.Name = "txtSitePassword";
            this.txtSitePassword.Size = new System.Drawing.Size(212, 20);
            this.txtSitePassword.TabIndex = 2;
            // 
            // lblSiteName
            // 
            this.lblSiteName.AutoSize = true;
            this.lblSiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSiteName.Location = new System.Drawing.Point(21, 13);
            this.lblSiteName.Name = "lblSiteName";
            this.lblSiteName.Size = new System.Drawing.Size(62, 13);
            this.lblSiteName.TabIndex = 116;
            this.lblSiteName.Text = "SITE NAME";
            // 
            // lblSitePassword
            // 
            this.lblSitePassword.AutoSize = true;
            this.lblSitePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSitePassword.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSitePassword.Location = new System.Drawing.Point(20, 58);
            this.lblSitePassword.Name = "lblSitePassword";
            this.lblSitePassword.Size = new System.Drawing.Size(92, 13);
            this.lblSitePassword.TabIndex = 117;
            this.lblSitePassword.Text = "SITE PASSWORD";
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApiKey.ForeColor = System.Drawing.SystemColors.Window;
            this.lblApiKey.Location = new System.Drawing.Point(20, 104);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(48, 13);
            this.lblApiKey.TabIndex = 120;
            this.lblApiKey.Text = "API KEY";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApiKey.Location = new System.Drawing.Point(22, 120);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(212, 20);
            this.txtApiKey.TabIndex = 3;
            // 
            // btnRequestLicense
            // 
            this.btnRequestLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRequestLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestLicense.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRequestLicense.Location = new System.Drawing.Point(22, 222);
            this.btnRequestLicense.Name = "btnRequestLicense";
            this.btnRequestLicense.Size = new System.Drawing.Size(212, 25);
            this.btnRequestLicense.TabIndex = 6;
            this.btnRequestLicense.Text = "REQUEST LICENSE";
            this.btnRequestLicense.UseVisualStyleBackColor = false;
            this.btnRequestLicense.Click += new System.EventHandler(this.btnRequestLicense_Click);
            // 
            // pnlCredentials
            // 
            this.pnlCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlCredentials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCredentials.Controls.Add(this.chkSaveCredentials);
            this.pnlCredentials.Controls.Add(this.lblChannels);
            this.pnlCredentials.Controls.Add(this.txtChannels);
            this.pnlCredentials.Controls.Add(this.btnRequestLicense);
            this.pnlCredentials.Controls.Add(this.txtSiteName);
            this.pnlCredentials.Controls.Add(this.txtSitePassword);
            this.pnlCredentials.Controls.Add(this.lblApiKey);
            this.pnlCredentials.Controls.Add(this.lblSiteName);
            this.pnlCredentials.Controls.Add(this.txtApiKey);
            this.pnlCredentials.Controls.Add(this.lblSitePassword);
            this.pnlCredentials.Location = new System.Drawing.Point(391, 71);
            this.pnlCredentials.Name = "pnlCredentials";
            this.pnlCredentials.Size = new System.Drawing.Size(258, 260);
            this.pnlCredentials.TabIndex = 1;
            // 
            // chkSaveCredentials
            // 
            this.chkSaveCredentials.AutoSize = true;
            this.chkSaveCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSaveCredentials.ForeColor = System.Drawing.Color.White;
            this.chkSaveCredentials.Location = new System.Drawing.Point(22, 196);
            this.chkSaveCredentials.Name = "chkSaveCredentials";
            this.chkSaveCredentials.Size = new System.Drawing.Size(208, 17);
            this.chkSaveCredentials.TabIndex = 5;
            this.chkSaveCredentials.Text = "SAVE CREDENTIALS FOR NEXT TIME";
            this.chkSaveCredentials.UseVisualStyleBackColor = true;
            // 
            // lblChannels
            // 
            this.lblChannels.AutoSize = true;
            this.lblChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChannels.ForeColor = System.Drawing.SystemColors.Window;
            this.lblChannels.Location = new System.Drawing.Point(21, 148);
            this.lblChannels.Name = "lblChannels";
            this.lblChannels.Size = new System.Drawing.Size(126, 13);
            this.lblChannels.TabIndex = 124;
            this.lblChannels.Text = "NUMBER OF CHANNELS";
            // 
            // txtChannels
            // 
            this.txtChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChannels.Location = new System.Drawing.Point(22, 166);
            this.txtChannels.Name = "txtChannels";
            this.txtChannels.Size = new System.Drawing.Size(212, 20);
            this.txtChannels.TabIndex = 4;
            // 
            // LicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(669, 531);
            this.Controls.Add(this.pnlCredentials);
            this.Controls.Add(this.lblAutomatedLicense);
            this.Controls.Add(this.lblManualLicense);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlActivation);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtProcess);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(685, 570);
            this.MinimumSize = new System.Drawing.Size(685, 570);
            this.Name = "LicenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Activation";
            this.Load += new System.EventHandler(this.LicenseForm_Load);
            this.pnlActivation.ResumeLayout(false);
            this.pnlActivation.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlCredentials.ResumeLayout(false);
            this.pnlCredentials.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Panel pnlActivation;
        private System.Windows.Forms.RadioButton rdoMonthly;
        private System.Windows.Forms.RadioButton rdoActivation;
        private System.Windows.Forms.TextBox txtSystemId;
        private System.Windows.Forms.TextBox txtNMSFcode;
        private System.Windows.Forms.Label lblCopySystemId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.Label lblLicenseInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblManualLicense;
        private System.Windows.Forms.Label lblAutomatedLicense;
        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.TextBox txtSitePassword;
        private System.Windows.Forms.Label lblSiteName;
        private System.Windows.Forms.Label lblSitePassword;
        private System.Windows.Forms.Label lblApiKey;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Button btnRequestLicense;
        private System.Windows.Forms.Panel pnlCredentials;
        private System.Windows.Forms.Label lblChannels;
        private System.Windows.Forms.TextBox txtChannels;
        private System.Windows.Forms.CheckBox chkSaveCredentials;
    }
}