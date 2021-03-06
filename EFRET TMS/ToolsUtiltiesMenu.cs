using System;
using System.Windows.Forms;
using EnvDTE;
using Sentry;
using Telerik.WinControls;
using Telerik.WinControls.UI;

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
            UploadtoP44 uploadtoP44 = new UploadtoP44();
            Form window = new Form
            {
                Text = "Reset CO for Upload",
                TopLevel = true,
                FormBorderStyle = FormBorderStyle.Fixed3D, //Disables user resizing
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = uploadtoP44.Size //size the form to fit the content
            };
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
            OnboardP44 OP44 = new OnboardP44();
            OP44.Show();
            RadForm1.LogMessage(Environment.UserName + " Accessed Onboarding P44 form");
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            ActivateCO ACO = new ActivateCO();
            Form window = new Form
            {
                Text = "Activate a Charging Order",
                TopLevel = true,
                FormBorderStyle = FormBorderStyle.Fixed3D, //Disables user resizing
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = ACO.Size //size the form to fit the content
            };

            window.Controls.Add(ACO);
            ACO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            window.ShowDialog();
            RadForm1.LogMessage(Environment.UserName + " Accessed 'Reactivate CO' function");
        }

        private void sfButton6_Click(object sender, EventArgs e)
        {



            ClearZerosOnCO CZONCO = new ClearZerosOnCO();
            Form window = new Form
            {
                Text = "Replace Zeros in KM/Cost with nulls in CO",
                TopLevel = true,
                FormBorderStyle = FormBorderStyle.Fixed3D, //Disables user resizing
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = CZONCO.Size //size the form to fit the content
            };

            window.Controls.Add(CZONCO);
            CZONCO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            window.ShowDialog();
            RadForm1.LogMessage(Environment.UserName + " Accessed  form");
        }


        private void radButton1_Click(object sender, EventArgs e)
        {
            FixRateOfExchange FROE = new FixRateOfExchange();
            Form window = new Form
            {
                Text = "Fix Rate of Exchange",
                TopLevel = true,
                FormBorderStyle = FormBorderStyle.Fixed3D, //Disables user resizing
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = FROE.Size //size the form to fit the content
            };

            window.Controls.Add(FROE);
            FROE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            window.ShowDialog();

        }

        private void sfButton7_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TrailerBlacklist TB = new TrailerBlacklist();
            Form window = new Form
            {
                Text = "Trailer Blacklist",
                TopLevel = true,
                FormBorderStyle = FormBorderStyle.Fixed3D, //Disables user resizing
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = TB.Size //size the form to fit the content
            };

            window.Controls.Add(TB);
            TB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            window.ShowDialog();
        }
    }
}
