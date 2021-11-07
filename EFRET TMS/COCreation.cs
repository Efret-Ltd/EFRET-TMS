using System;

namespace EFRET_TMS
{
    public partial class CoCreation : DevExpress.XtraEditors.XtraForm
    {
        public CoCreation()
        {
            InitializeComponent();
            var createCouc = new ProcessCreateCo();
            Controls.Add(createCouc);
            createCouc.BringToFront();
            createCouc.Visible = true;
        }

        private void COCreation_Load(object sender, EventArgs e)
        {

        }
    }
}
