using DevExpress.XtraSplashScreen;
using System;
using System.IO;
using System.Reflection;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class SplashScreen1 : SplashScreen
    {
        public SplashScreen1()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();

            versionCheck();
        }

        public void versionCheck()
        {
            int v = -1;
            String[] Lversion = File.ReadAllLines(@"\\efret-app-01\Database\efret\dist\version.txt");
            foreach (string version in Lversion)
            {
                if (version != AssemblyVersion)
                {
                    labelStatus.Text = "Outdated TMS... Updating Client";
                    RadMessageBox.Show(
                        "You are running a outdated version of the TMS.\nClick OK to run the updater.");
                }
                else
                {
                    labelStatus.Text = "Loading User Permissions";
                }

            }

        }


        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}