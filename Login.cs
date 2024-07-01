using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
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

		private async void LoginButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox_siteUrl.Text))
			{
				MessageBox.Show("Please enter site url!");
			}
			else
			{
#if !DEBUG
                ApiHelper.Instance.SiteUrl = textBox_siteUrl.Text;
#endif

				var _token = await AuthenticationHandler.Instance.Authenticate();

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
			if (string.IsNullOrWhiteSpace(textBox_siteUrl.Text))
			{
				MessageBox.Show("Please enter a site url.");
			}
			else if (string.IsNullOrWhiteSpace(textbox_PAT.Text))
			{
				MessageBox.Show("Please enter a personal access token.");
			}
			else
			{
				ApiHelper.Instance.SiteUrl = textBox_siteUrl.Text;

				var _token = await AuthenticationHandler.Instance.Authenticate(Strings.Trim(textbox_PAT.Text));

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
	}
}