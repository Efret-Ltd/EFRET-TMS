﻿using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using EFRET_TMS.axsDataSetTableAdapters;
using System;
using System.Collections;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System.Diagnostics;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class Orders : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Orders()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            newCOTableAdapter1.Fill(axsDataSet1.NewCO);

            DevExpress.XtraGrid.GridFormatRule gridFormatRule = new DevExpress.XtraGrid.GridFormatRule();
            FormatConditionRuleDataUpdate formatConditionRuleDataUpdate = new FormatConditionRuleDataUpdate();
            gridFormatRule.Column = gridView1.Columns["colP44ShipmentID"];
            gridFormatRule.Name = "P44Update";
            formatConditionRuleDataUpdate.HighlightTime = 500;
            formatConditionRuleDataUpdate.PredefinedName = "Green Fill";
            formatConditionRuleDataUpdate.Trigger = FormatConditionDataUpdateTrigger.ValueChanged;
            gridFormatRule.Rule = formatConditionRuleDataUpdate;
            gridView1.FormatRules.Add(gridFormatRule);
        }
        //Create a Charging Order.
        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

            COCreation COCreate = new COCreation();
            COCreate.ShowDialog();
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
            ArrayList rows = new ArrayList();
            // Add the selected rows to the list.
            Int32[] selectedRowHandles = gridView1.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView1.GetDataRow(selectedRowHandle));
            }
            try
            {
                gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    var p44id = row["P44ShipmentID"];
                    var P44_Long = row["P44Longitude"];
                    var P44_Lat = row["P44Latitude"];
                    var coords = P44_Long.ToString() + P44_Lat.ToString();
                    RadMessageBox.Show(coords.ToString());
                }

            }
            finally
            {
                gridView1.EndUpdate();
                
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
