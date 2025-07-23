using LazyCache;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Windows.Forms;

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

            //LazyCache does not have a nice way to clear the full cache so i found this hack
            var _cache = new CachingService();
            ICacheProvider cacheProvider = _cache.CacheProvider;
            var memoryCache = (MemoryCache)cacheProvider.GetType().GetField("cache", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(cacheProvider);
            memoryCache.Compact(1.0);

            if (Login.MainForm != null)
            {
                Invoke((MethodInvoker)(() => Login.MainForm.Hide()));
                Invoke((MethodInvoker)(() => Login.MainForm = null));
                Invoke((MethodInvoker)(() => Program.LoginForm.Show()));
            }
        }
    }
}