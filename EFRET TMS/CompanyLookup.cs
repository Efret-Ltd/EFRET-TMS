using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            // TODO: This line of code loads data into the 'company.CompanyContact' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'company._Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.company._Company);

        }

        private void radDataEntry1_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            ShipmentMap SMap = new ShipmentMap(0,radTextBox25.Text, radTextBox26.Text);
            SMap.Show();
        }
    }
}