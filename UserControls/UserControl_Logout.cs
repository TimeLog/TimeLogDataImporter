using System;
using System.Windows.Forms;
using TimeLog.DataImporter.Handlers;

namespace TimeLog.DataImporter.UserControls
{
    public partial class UserControl_Logout : UserControl
    {
        public UserControl_Logout()
        {
            InitializeComponent();
            panel_logout.BackgroundImage = Properties.Resources.baggrund_min;
        }

        private async void button_logout_Click(object sender, EventArgs e)
        {
            if (Login.MainForm != null)
            {
                Invoke((MethodInvoker)(() => Login.MainForm.Hide()));
                Invoke((MethodInvoker)(() => Login.MainForm = null));
                Invoke((MethodInvoker)(() => Program.LoginForm.Show()));
            }
        }
    }
}