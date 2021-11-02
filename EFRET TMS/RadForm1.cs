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
    }
}
