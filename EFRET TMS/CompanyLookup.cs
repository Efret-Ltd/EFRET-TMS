using System;
using Telerik.WinControls.UI;

namespace EFRET_TMS
{
    public partial class CompanyLookup : DevExpress.XtraEditors.XtraForm
    {
        public CompanyLookup()
        {
            InitializeComponent();
        }

        private void CompanyLookup_Load(object sender, EventArgs e)
        {
            this.companyTableAdapter.Fill(this.company._Company);

        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            ShipmentMap SMap = new ShipmentMap(0,radTextBox25.Text, radTextBox26.Text);
            SMap.Show();
        }
        private void radTextBox16_TextChanged(object sender, EventArgs e)
        {
            radValidationProvider1.ClearErrorStatus();
        }
    }
}