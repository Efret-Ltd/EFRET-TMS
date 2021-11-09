using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
        }
    }
}
