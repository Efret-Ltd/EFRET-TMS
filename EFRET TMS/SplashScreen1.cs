﻿using DevExpress.XtraSplashScreen;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace EFRET_TMS
{
    public partial class SplashScreen1 : SplashScreen
    {
        public SplashScreen1()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2005-" + DateTime.Now.Year.ToString();
            LoadAssets();
            VersionCheck();
        }

        public void LoadAssets()
        {
            var img = Convert.FromBase64String("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");
            using (MemoryStream ms = new MemoryStream(img))
            {
                peImage.Image = Image.FromStream(ms);
            }

        }

        public void VersionCheck()
        {
            // We do a self check to see if we are running the latest TMS.
            String[] lversion = File.ReadAllLines(@"\\efret-app-01\Database\efret\dist\version.txt");
            foreach (string version in lversion)
            {
                if (version != AssemblyVersion)
                {
                    labelStatus.ForeColor = Color.Red;
                    labelStatus.Text = "[ERROR 101] Outdated TMS... Updating Client";
                    /*
                     * We hit the update function. Call from the distribution network folder
                     * EFRET
                     */
                    //  installAXS();
                }
                else
                {
                    labelStatus.BackColor = Color.Green;
                    labelStatus.Text = "[SUCCESS] Loading User Permissions";

                }

            }

        }

        public void InstallAxs()
        {
            labelStatus.Text = "Installing/Updating AXS";
            Process process = new Process();
            process.StartInfo.FileName = "msiexec.exe";
            process.StartInfo.Arguments = @"/i \\VWIN10\Development\Deployment\Testing\Installer\axs\install_AXS.msi";
            process.Start();
            labelStatus.Text = "AXS is installed!";
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