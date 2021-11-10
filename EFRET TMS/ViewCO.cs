using DevExpress.XtraBars;
using System;
namespace EFRET_TMS
{
    public partial class ViewCO : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private object CID;
        private string path;
        private object newChargingOrder;
        private int P44ChecklistCounter;

        public ViewCO(int COID, object newCO, object ContractID)
        {
            InitializeComponent();
            CID = ContractID + @"\";
            newChargingOrder = newCO;
            path = @"\\efret-app-01\Database\efret\2021\CustomerCO\" + CID + newChargingOrder;
        }

        private void ViewCO_Load(object sender, EventArgs e)
        {
            ribbonPageGroup7.Text = "Project44 Checklist";
            barStaticItem1.Caption = P44ChecklistCounter + "/5 Completed";
        }

        private void P44Check(int P44ChecklistCounter, ItemClickEventArgs e)
        {
            if (barCheckItem1.Checked)
            {
                P44ChecklistCounter++;
            }
            else
            {
                P44ChecklistCounter--;
            }
            if (barCheckItem2.Checked)
            {
                P44ChecklistCounter++;
            }
            else
            {
                P44ChecklistCounter--;
            }
            if (barCheckItem3.Checked)
            {
                P44ChecklistCounter++;
            }
            else
            {
                P44ChecklistCounter--;
            }
            if (barCheckItem4.Checked)
            {
                P44ChecklistCounter++;
            }
            else
            {
                P44ChecklistCounter--;
            }
            if (barCheckItem5.Checked)
            {
                P44ChecklistCounter++;
            }
            else
            {
                P44ChecklistCounter--;
            }
            barStaticItem1.Refresh();
            this.Refresh();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraOpenFileDialog1.InitialDirectory = path;
            xtraOpenFileDialog1.Title = "View Charging Order Browser";
            xtraOpenFileDialog1.FileName = "";
            xtraOpenFileDialog1.ShowDialog();
        }

        private void barCheckItem2_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            P44Check(P44ChecklistCounter,e);
        }

        private void barCheckItem5_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            P44Check(P44ChecklistCounter, e);
        }

        private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            P44Check(P44ChecklistCounter, e);
        }

        private void barCheckItem3_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            P44Check(P44ChecklistCounter, e);
        }

        private void barCheckItem4_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            P44Check(P44ChecklistCounter, e);
           
        }
    }
}