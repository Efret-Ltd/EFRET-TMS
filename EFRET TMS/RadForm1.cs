using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace EFRET_TMS
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            this.Text = "Welcome to EFRET "+ Environment.UserName;
        }


        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        //Adminisrtation
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            AdminControlPanel ACP = new AdminControlPanel();
            ACP.Show();
        }


        //Statistics
        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }

        //Management
        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

        }
    }
}
