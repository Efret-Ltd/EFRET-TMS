﻿using DevExpress.XtraBars;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;

namespace EFRET_TMS
{
    public partial class Orders : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Orders()
        {
            InitializeComponent();
            // We will the adapter with NewCO dataset. 
            newCOTableAdapter1.Fill(axsDataSet1.NewCO);
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
            // TODO: This line of code loads data into the 'axsDataSet1.DataTable1' table. You can move, or remove it, as needed.
            //  this.dataTable1TableAdapter.Fill(axsDataSet1.DataTable1);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Base.GridCell[] selectedCellHandles = gridView1.GetSelectedCells();


            ArrayList rows = new ArrayList();
            // Add the selected rows to the list.
            int[] selectedRowHandles = gridView1.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView1.GetDataRow(selectedRowHandle));
            }
            try
            {
                gridView1.BeginUpdate();


            }
            finally
            {
                gridView1.EndUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    int coid = int.Parse(row["IdCO"].ToString());
                    object p44Long = row["P44Longitude"];
                    object p44Lat = row["P44Latitude"];
                    //We currently do not want the map to show when tracking is provided.
                    if (row["P44Longitude"].ToString() != "0" || row["P44Longitude"].ToString() != "0")
                    {
                    ShipmentMap sMap = new ShipmentMap(coid, p44Lat.ToString(), p44Long.ToString());
                    /*
                     * TODO: Add more user controls on shipment map. Allow the user to control the zoom level. Refresh data.
                     */
                    sMap.ShowDialog();

                    }
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
    }
}