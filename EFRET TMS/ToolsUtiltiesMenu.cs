using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
            Check_VAT checkVat = new Check_VAT();
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
    }
}
