using DevExpress.XtraBars;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Sentry;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class Orders : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Orders()
        {
            InitializeComponent();
            // We will the adapter with NewCO dataset. 
            newCOTableAdapter1.Fill(axsDataSet1.NewCO);
            WindowState = FormWindowState.Maximized;
        }
        //Create a Charging Order.
        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

            CoCreation coCreate = new CoCreation();
            coCreate.ShowDialog();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {

        }

        private void barHeaderItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            newCOTableAdapter1.GetData();
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            
            ArrayList rows = new ArrayList();
            // Add the selected rows to the list.
            int[] selectedRowHandles = gridView1.GetSelectedRows();
            foreach (var selectedRowHandle in selectedRowHandles)
            {
                if (selectedRowHandle >= 0)
                    rows.Add(gridView1.GetDataRow(selectedRowHandle));
            }

            foreach (var t in rows)
            {
                try
                {
                    DataRow row = t as DataRow;
                    int coid = int.Parse(row["IdCO"].ToString());
                    object contractId = row["IdContractHolder"];
                    object newCo = row["NewCO"];
                    //We want to make a ViewCO screen of the IDCO selected.
                    object p44Long = row["P44Longitude"];
                    object p44Lat = row["P44Latitude"];
                    try
                    {
                        // Here we do a bunch of conditioning depending on the column cell clicked.
                        if (gridView1.FocusedColumn.FieldName == "IdCO" ||
                            gridView1.FocusedColumn.FieldName == "New CO")
                        {
                            RadForm1.LogMessage(Environment.UserName+" Opened CO:  " + newCo);
                            ViewCo viewCo = new ViewCo(coid, newCo, contractId);
                            viewCo.Show();
                        }

                        if (gridView1.FocusedColumn.FieldName == "P44ShipmentID")
                        {

                            //We currently do not want the map to show when tracking is provided.
                            if (row["P44Longitude"].ToString() != "0" || row["P44Longitude"].ToString() != "0")
                            {
                                ShipmentMap sMap = new ShipmentMap(coid, p44Lat.ToString(), p44Long.ToString());
                                /*
                             * TODO: Add more user controls on shipment map. Allow the user to control the zoom level. Refresh data.
                             */
                                sMap.Show();

                            }
                            else
                            {

                                if (row["P44ShipmentID"] != null & row["P44ReasonDescription"] == null)
                                {
                                    RadMessageBox.Show("No Tracking Available: Investigation Needed");
                                }
                                if(row["P44ReasonDescription"] == null)
                                {
                                    RadMessageBox.Show("No Tracking Available: Contact IT");
                                }
                                RadMessageBox.Show("No Tracking Available: " + row["P44ReasonDescription"]);

                            }

                        }

                        gridView1.BeginUpdate();

                    }
                    finally
                    {
                        gridView1.EndUpdate();

                    }
                }
                catch (Exception ex)
                {
                    SentrySdk.CaptureException(ex);
                }
            }

        }

        private void barLargeButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            string path = "output.xlsx";
            gridControl1.ExportToXlsx(path);
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {

        }
    }
}
