using System;
using Sentry;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class ToolsUtiltiesMenu : Telerik.WinControls.UI.ShapedForm
    {
        public ToolsUtiltiesMenu()
        {
            InitializeComponent();
        }

        private void vatCheckButton_Click(object sender, EventArgs e)
        {
            CheckVat checkVat = new CheckVat();
            checkVat.Show();
            SentrySdk.CaptureMessage(Environment.UserName + " opened checkVAT form");
        }

        private void sfButton1_Click(object sender, EventArgs e)
        {
            Whois whois = new Whois();
            whois.Show();
            SentrySdk.CaptureMessage(Environment.UserName + " opened whois form");
        }

        private void sfButton2_Click(object sender, EventArgs e)
        {
            if (Environment.UserName != "alain.jestin")
            {
                RadMessageBox.Show("You do not have permission to use this.");
                SentrySdk.CaptureMessage(Environment.UserName + " attempted to use the ForceP44Upload function");

            }
            else
            {

                SentrySdk.CaptureMessage(Environment.UserName + " accessed the ForceP44Upload function");
            }
        }

        private void sfButton4_Click(object sender, EventArgs e)
        {
            RadForm1.LogMessage(Environment.UserName + " Accessed Reset P44 Upload form");
            ResetP44Upload resetP44Upload = new ResetP44Upload();
            resetP44Upload.Show();
        }

        private void sfButton5_Click(object sender, EventArgs e)
        {
            OnboardP44 OP44 = new OnboardP44("TESTCM");
            OP44.Show();
        }
    }
}
