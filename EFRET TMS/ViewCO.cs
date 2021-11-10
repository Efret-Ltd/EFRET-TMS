using DevExpress.XtraBars;
using System;
namespace EFRET_TMS
{
    public partial class ViewCO : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private object CID;
        private string path;
        private object newChargingOrder;
        public ViewCO(int COID, object newCO,object ContractID)
        {
            InitializeComponent(); 
            CID = ContractID+@"\";
            newChargingOrder = newCO;
            path = @"\\efret-app-01\Database\efret\2021\CustomerCO\" + CID + newChargingOrder;
        }

        private void ViewCO_Load(object sender, EventArgs e)
        {
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraOpenFileDialog1.InitialDirectory = path;
            xtraOpenFileDialog1.Title = "View Charging Order Browser";
            xtraOpenFileDialog1.FileName = "";
            xtraOpenFileDialog1.ShowDialog();
        }
    }
}