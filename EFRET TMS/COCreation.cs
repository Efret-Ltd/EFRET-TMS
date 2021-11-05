using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class COCreation : DevExpress.XtraEditors.XtraForm
    {
        ProcessCreateCo createCOUC;
        public COCreation()
        {
            InitializeComponent();
            createCOUC = new ProcessCreateCo();
            Controls.Add(createCOUC);
            createCOUC.BringToFront();
            createCOUC.Visible = true;
        }

        private void COCreation_Load(object sender, EventArgs e)
        {

        }
    }
}
