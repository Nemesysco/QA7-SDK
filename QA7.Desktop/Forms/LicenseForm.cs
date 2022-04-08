using NMS.Core;
using QA7.Desktop.Core.Utility;
using RestSharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QA7.Desktop.Forms
{
    public partial class LicenseForm : Form
    {
        private readonly MainForm _mainForm = null;
        private readonly bool _isActivated;


        public LicenseForm(MainForm mainForm, bool isActivated)
        {
            _mainForm = mainForm;
            InitializeComponent();

            _isActivated = isActivated;
        }


        private void LicenseForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.conAccountId != string.Empty)
            {
                txtSiteName.Text = Properties.Settings.Default.containerId;
                txtSitePassword.Text = Properties.Settings.Default.containerPass;
                txtApiKey.Text = Properties.Settings.Default.conAccountId;
            }

            txtSystemId.Text = _mainForm.SystemId;

            if (_isActivated)
                lblLicenseInfo.ForeColor = Color.GreenYellow;
            else
                lblLicenseInfo.ForeColor = Color.Red;

            lblLicenseInfo.Text = _mainForm.LicenseText;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if ((txtNMSFcode.Text.Length == 0 && rdoActivation.Checked) || (txtSystemId.Text.Length == 0 && rdoMonthly.Checked))
            {
                MessageBox.Show("Empty text", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rdoActivation.Checked)
                _mainForm.SetLicenseCode(txtNMSFcode.Text.Trim());
            else
                _mainForm.GenerateMonthlyLicense(txtSystemId.Text.Trim());

            this.Close();
        }

        private async void btnRequestLicense_Click(object sender, EventArgs e)
        {
            if (txtSiteName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Site Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSitePassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Site Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtApiKey.Text.Trim() == string.Empty)
            {
                MessageBox.Show("API Key is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtChannels.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Number of Channels is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int channels = 0;
            if (!int.TryParse(txtChannels.Text, out channels))
            {
                MessageBox.Show("Incorrect value of Number of Channels. It must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // CREDENTIALS REMEMBER OR NOT

            if (chkSaveCredentials.Checked)
            {
                Properties.Settings.Default.containerId = txtSiteName.Text;
                Properties.Settings.Default.containerPass = txtSitePassword.Text;
                Properties.Settings.Default.conAccountId = txtApiKey.Text;
                Properties.Settings.Default.Save();
            }

            ////////////////////////////////////////
            //// OBTAIN TOKEN FROM IDP         /////
            ////////////////////////////////////////

            using (new WaitCursor())
            {
                // (1) PICK ENV:
                var client = new RestClient("https://auth.nemesysco.net/Auth/Login");

                // (2) BUILD REQUEST
                var request = new RestRequest(Method.POST);

                // build cred json
                request.AddJsonBody(new
                {
                    userName = txtSiteName.Text,
                    password = txtSitePassword.Text,
                });

                // (2.a) EXECUTE REQUEST
                var response = await client.ExecuteAsync(request);
                var token = response.Content.Replace("\"", string.Empty).Trim();

                // (2.b) PARSE RESPONSE UNTIL PURE TOKEN:
                int index2 = token.IndexOf(":");
                if (index2 > 0)
                {
                    token = token.Substring(index2 + 1);
                }
                int index3 = token.IndexOf(":");
                if (index3 > 0)
                {
                    token = token.Substring(index3 + 1);
                }

                ////////////////////////////////////////////////
                //// OBTAIN KEY FROM KM WITH TOKEN          ////
                ////////////////////////////////////////////////

                // (1) PICK ENV:
                //prod (pre staging)
                var client2 = new RestClient("https://api.nemesysco.net/api/PostCode");

                // (2) BUILD REQUEST:
                var request2 = new RestRequest(Method.POST);
                request2.AddHeader("Content-Type", "application/json");
                request2.AddHeader("Authorization", "Bearer " + token);
                request2.AddJsonBody(new
                {
                    AccountID = txtApiKey.Text.Trim().ToLower(),
                    ActivationType = 0,
                    ExpirationDate = DateTime.UtcNow,
                    SystemId = _mainForm.SystemId.Trim(),
                    LicenseNumber = "",
                    AppType = "NMS",
                    Seats = Int32.Parse(txtChannels.Text),
                    ServiceName = "QA7",
                    SourceType = 0,
                    RequestType = 1
                });

                // (3) EXECUTE REQUEST AND OBTAIN KEY
                // post request and get response:
                var response2 = await client2.ExecuteAsync(request2);
                txtNMSFcode.Text = response2.Content.ToString().Replace("\"", string.Empty);
            }

            txtNMSFcode.BackColor = Color.Green;
            btnActivate.Focus();
        }

        private void lblCopySystemId_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSystemId.Text);
            lblCopySystemId.ForeColor = Color.Green;
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            using (new WaitCursor())
            {
                var li = LicenseManager.GetInfo(AppUtility.GetVersion());
                lblLicenseInfo.Text = LicenseManager.ToString(li);
            }                
        }
    }
}
