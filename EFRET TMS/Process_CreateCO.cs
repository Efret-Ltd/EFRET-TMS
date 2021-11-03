using System;
using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class Process_CreateCO : UserControl
    {
        //TODO: Generate a sessionid with all user entries so developers can trace back the submission to troubleshoot.
        /*
         * Currently posting all user entries to ably.
         */
        public Process_CreateCO()
        {
            InitializeComponent();
        }

        private void wizardControl1_Click(object sender, EventArgs e)
        {
        }

        private void processEnd(object sender, CancelEventArgs e)
        {
            //Future reference. All user input to be shown in the details section.
            RadMessageBox.SetThemeName("Desert");
            RadMessageBox.Show("Message", "Are you sure ? All your progress will be removed", MessageBoxButtons.YesNo, "Details Text");
            DialogResult ds = RadMessageBox.Show(this, "Are you sure? All your progress will be removed.", "Title", MessageBoxButtons.YesNo, RadMessageIcon.Question);
            this.Text = ds.ToString();
        }
    }
}
