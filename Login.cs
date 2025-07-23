using System;
using System.Diagnostics;
using System.Windows.Forms;
using TimeLog.DataImporter.Handlers;
using TimeLog.DataImporter.TimeLogApi;

namespace TimeLog.DataImporter
{
    public partial class Login : Form
    {
        public static Main MainForm;

        public Login()
        {
            InitializeComponent();
            panel_login.BackgroundImage = Properties.Resources.baggrund_min;
        }

        private async void loginUsingPat()
        {
            if (string.IsNullOrWhiteSpace(textBox_siteUrl.Text))
            {
                MessageBox.Show("Please enter a site url.");
            } else if (string.IsNullOrWhiteSpace(textbox_PAT.Text))
            {
                MessageBox.Show("Please enter a personal access token.");
            } else
            {
                ApiHelper.Instance.SiteUrl = textBox_siteUrl.Text;

                var _token = await AuthenticationHandler.Instance.Authenticate(textbox_PAT.Text.Trim());

                if (!string.IsNullOrEmpty(_token))
                {
                    Hide();

                    if (MainForm == null)
                    {
                        MainForm = new Main();
                        MainForm.Closed += (s, args) => Close();
                    }

                    MainForm.Show();
                }
            }
        }

        private async void button_pat_login_Click(object sender, EventArgs e)
        {
            loginUsingPat();
        }

        private void textbox_PAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginUsingPat();
            }
        }

        private void link_PAT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = sender as LinkLabel;
            string target = "https://login.timelog.com/PersonalToken";

            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = target,
                    UseShellExecute = true
                });

                linkLabel.LinkVisited = true;
            } catch (Exception ex)
            {
                MessageBox.Show($"Could not open link: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}