using DevExpress.XtraBars;
using System;

using System.Windows.Forms;

namespace EFRET_TMS
{
    public partial class ViewCO : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewCO()
        {
            InitializeComponent();
        }

        private void ViewCO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cOInstance.Goods' table. You can move, or remove it, as needed.
            this.goodsTableAdapter.Fill(this.cOInstance.Goods);

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr = radOpenFolderDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string folderName = radOpenFolderDialog1.FileName;
            }
        }
    }
}