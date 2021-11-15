using System;
using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class ProcessCreateCo : UserControl
    {
        //TODO: Generate a sessionid with all user entries so developers can trace back the submission to troubleshoot.
        /*
         * Currently posting all user entries to ably.
         */
        public ProcessCreateCo()
        {
            InitializeComponent();
        }

        private void wizardControl1_Click(object sender, EventArgs e)
        {
        }

        private void CompanyCreation()
        {
        }


        //We use this to generate new folders on the network location.
        private void FolderGen(string companyCode)
        {
            var networkLocation = @"\\EFRET-APP-01\Database\efret\2021\CustomerCO\";
            bool exists = System.IO.Directory.Exists(networkLocation+companyCode);
            if (!exists)
                System.IO.Directory.CreateDirectory(networkLocation+companyCode);

        }

        //Company/Client Selection or Creation
        private void CompanySelection()
        {
        }

        private void ProcessEnd(object sender, CancelEventArgs e)
        {
            //Future reference. All user input to be shown in the details section.
            RadMessageBox.SetThemeName("Desert");
            var time = DateTime.Now+" ";
            var details = time + Environment.UserName + " Has started the CO creation process";
            RadMessageBox.Show("Quit Process", "Are you sure ? All your progress will be removed", MessageBoxButtons.YesNo,
                details);
        }

        private void stepProgressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
