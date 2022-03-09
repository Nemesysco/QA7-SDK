namespace QA7.Desktop.Forms
{
    partial class JsonOutputForm
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
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnExportToFile = new System.Windows.Forms.Button();
            this.lblExportPath = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtExportPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 12);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(845, 493);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold);
            this.btnCopyToClipboard.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(162, 511);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(147, 23);
            this.btnCopyToClipboard.TabIndex = 1;
            this.btnCopyToClipboard.Text = "COPY TO CLIPBOARD";
            this.btnCopyToClipboard.UseVisualStyleBackColor = false;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnExportToFile
            // 
            this.btnExportToFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExportToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold);
            this.btnExportToFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExportToFile.Location = new System.Drawing.Point(12, 511);
            this.btnExportToFile.Name = "btnExportToFile";
            this.btnExportToFile.Size = new System.Drawing.Size(147, 23);
            this.btnExportToFile.TabIndex = 2;
            this.btnExportToFile.Text = "EXPORT TO FILE";
            this.btnExportToFile.UseVisualStyleBackColor = false;
            this.btnExportToFile.Click += new System.EventHandler(this.btnExportToFile_Click);
            // 
            // lblExportPath
            // 
            this.lblExportPath.AutoSize = true;
            this.lblExportPath.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblExportPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline);
            this.lblExportPath.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblExportPath.Location = new System.Drawing.Point(12, 547);
            this.lblExportPath.Name = "lblExportPath";
            this.lblExportPath.Size = new System.Drawing.Size(48, 13);
            this.lblExportPath.TabIndex = 3;
            this.lblExportPath.Text = "File Path";
            this.lblExportPath.Click += new System.EventHandler(this.lblExportPath_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClose.Location = new System.Drawing.Point(710, 511);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtExportPath
            // 
            this.txtExportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExportPath.Location = new System.Drawing.Point(66, 544);
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.ReadOnly = true;
            this.txtExportPath.Size = new System.Drawing.Size(791, 20);
            this.txtExportPath.TabIndex = 5;
            // 
            // JsonOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(869, 579);
            this.Controls.Add(this.txtExportPath);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblExportPath);
            this.Controls.Add(this.btnExportToFile);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.rtbOutput);
            this.Name = "JsonOutputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSON Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnExportToFile;
        private System.Windows.Forms.Label lblExportPath;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtExportPath;
    }
}