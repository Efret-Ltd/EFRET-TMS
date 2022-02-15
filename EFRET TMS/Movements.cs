using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class Movements : DevExpress.XtraEditors.XtraForm
    {
        public Movements()
        {
            InitializeComponent();
        }

        private void Movements_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movementCO.Movement' table. You can move, or remove it, as needed.
            this.movementTableAdapter.Fill(this.movementCO.Movement);

        }

        private void barLargeButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
           CompanyLookup CL = new CompanyLookup();
            CL.Show();
        }

        private void OpenCO(object sender, EventArgs e)
        {
            var test = gridView1.GetDataRow(gridView1.FocusedRowHandle).ToString();
            RadMessageBox.Show(test);
           // ViewCo VCO = new ViewCo();
           // VCO.Show();
        }
    }
}