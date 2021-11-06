using System;

namespace EFRET_TMS
{
    public partial class CoCreation : DevExpress.XtraEditors.XtraForm
    {
        ProcessCreateCo _createCouc;
        public CoCreation()
        {
            InitializeComponent();
            _createCouc = new ProcessCreateCo();
            Controls.Add(_createCouc);
            _createCouc.BringToFront();
            _createCouc.Visible = true;
        }

        private void COCreation_Load(object sender, EventArgs e)
        {

        }
    }
}
