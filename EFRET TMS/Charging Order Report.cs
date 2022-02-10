namespace EFRET_TMS
{
    public class ChargingOrderReport : DevExpress.XtraReports.UI.XtraReport
    {
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRTableCell tableCell9;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.XRTableCell tableCell13;
        private DevExpress.XtraReports.UI.XRTableCell tableCell14;
        private DevExpress.XtraReports.UI.XRTableCell tableCell15;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell16;
        private DevExpress.XtraReports.UI.XRTableCell tableCell17;
        private DevExpress.XtraReports.UI.XRTableCell tableCell18;
        private DevExpress.XtraReports.UI.XRTableCell tableCell19;
        private DevExpress.XtraReports.UI.XRTableCell tableCell20;
        private DevExpress.XtraReports.UI.XRTableCell tableCell21;
        private DevExpress.XtraReports.UI.XRTableCell tableCell22;
        private DevExpress.XtraReports.UI.XRTableCell tableCell23;
        private DevExpress.XtraReports.UI.XRTableCell tableCell24;
        private DevExpress.XtraReports.UI.XRTableCell tableCell25;
        private DevExpress.XtraReports.UI.XRTableCell tableCell26;
        private DevExpress.XtraReports.UI.XRTableCell tableCell27;
        private DevExpress.XtraReports.UI.XRTableCell tableCell28;
        private DevExpress.XtraReports.UI.XRTableCell tableCell29;
        private DevExpress.XtraReports.UI.XRTableCell tableCell30;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle ReportHeaderBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupHeaderBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportDetailBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportGroupFooterBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportFooterBandStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportOddStyle;
        private DevExpress.XtraReports.UI.XRControlStyle ReportEvenStyle;
        private MovementCOTableAdapters.MovementTableAdapter movementTableAdapter;
        private System.Windows.Forms.BindingSource movementBindingSource1;
        private System.ComponentModel.IContainer components;
        private MovementCO movementCO;

        public ChargingOrderReport()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportGroupHeaderBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportDetailBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportGroupFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportFooterBandStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportOddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportEvenStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.movementTableAdapter = new EFRET_TMS.MovementCOTableAdapters.MovementTableAdapter();
            this.movementBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.movementCO = new EFRET_TMS.MovementCO();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementCO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.Name = "TopMargin";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.PageHeader.Dpi = 254F;
            this.PageHeader.HeightF = 63.5F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StyleName = "ReportHeaderBandStyle";
            // 
            // table1
            // 
            this.table1.Dpi = 254F;
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(1592F, 63.5F);
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2,
            this.tableCell3,
            this.tableCell4,
            this.tableCell5,
            this.tableCell6,
            this.tableCell7,
            this.tableCell8,
            this.tableCell9,
            this.tableCell10,
            this.tableCell11,
            this.tableCell12,
            this.tableCell13,
            this.tableCell14,
            this.tableCell15});
            this.tableRow1.Dpi = 254F;
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 11.499995494453673D;
            // 
            // tableCell1
            // 
            this.tableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell1.Dpi = 254F;
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StyleName = "ReportHeaderBandStyle";
            this.tableCell1.Text = "Id CO";
            this.tableCell1.Weight = 0.16933333813844614D;
            // 
            // tableCell2
            // 
            this.tableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell2.Dpi = 254F;
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StyleName = "ReportHeaderBandStyle";
            this.tableCell2.Text = "company Code";
            this.tableCell2.Weight = 0.16933333813844614D;
            // 
            // tableCell3
            // 
            this.tableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell3.Dpi = 254F;
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StyleName = "ReportHeaderBandStyle";
            this.tableCell3.Text = "Completed Date";
            this.tableCell3.Weight = 0.16933333813844614D;
            // 
            // tableCell4
            // 
            this.tableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell4.Dpi = 254F;
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.StyleName = "ReportHeaderBandStyle";
            this.tableCell4.Text = "Effective Date";
            this.tableCell4.Weight = 0.16933333813844614D;
            // 
            // tableCell5
            // 
            this.tableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell5.Dpi = 254F;
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.StyleName = "ReportHeaderBandStyle";
            this.tableCell5.Text = "Contractualdate";
            this.tableCell5.Weight = 0.16933333813844614D;
            // 
            // tableCell6
            // 
            this.tableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell6.Dpi = 254F;
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.StyleName = "ReportHeaderBandStyle";
            this.tableCell6.Text = "Operation";
            this.tableCell6.Weight = 0.16933333813844614D;
            // 
            // tableCell7
            // 
            this.tableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell7.Dpi = 254F;
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StyleName = "ReportHeaderBandStyle";
            this.tableCell7.Text = "id Movement";
            this.tableCell7.Weight = 0.16933333813844614D;
            // 
            // tableCell8
            // 
            this.tableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell8.Dpi = 254F;
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.StyleName = "ReportHeaderBandStyle";
            this.tableCell8.Text = "Cost";
            this.tableCell8.Weight = 0.16933333813844614D;
            // 
            // tableCell9
            // 
            this.tableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell9.Dpi = 254F;
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.StyleName = "ReportHeaderBandStyle";
            this.tableCell9.Text = "Currency";
            this.tableCell9.Weight = 0.16933333813844614D;
            // 
            // tableCell10
            // 
            this.tableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell10.Dpi = 254F;
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.StyleName = "ReportHeaderBandStyle";
            this.tableCell10.Text = "Cost VAT Code";
            this.tableCell10.Weight = 0.16933333813844614D;
            // 
            // tableCell11
            // 
            this.tableCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell11.Dpi = 254F;
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.StyleName = "ReportHeaderBandStyle";
            this.tableCell11.Text = "Date Creation";
            this.tableCell11.Weight = 0.16933333813844614D;
            // 
            // tableCell12
            // 
            this.tableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell12.Dpi = 254F;
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.StyleName = "ReportHeaderBandStyle";
            this.tableCell12.Text = "Cost Provider";
            this.tableCell12.Weight = 0.16933333813844614D;
            // 
            // tableCell13
            // 
            this.tableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell13.Dpi = 254F;
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.StyleName = "ReportHeaderBandStyle";
            this.tableCell13.Text = "Cost Provider Ferry";
            this.tableCell13.Weight = 0.16933333813844614D;
            // 
            // tableCell14
            // 
            this.tableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell14.Dpi = 254F;
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.StyleName = "ReportHeaderBandStyle";
            this.tableCell14.Text = "Vehicle Details";
            this.tableCell14.Weight = 0.16933333813844614D;
            // 
            // tableCell15
            // 
            this.tableCell15.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell15.Dpi = 254F;
            this.tableCell15.Name = "tableCell15";
            this.tableCell15.StyleName = "ReportHeaderBandStyle";
            this.tableCell15.Text = "Mvt Reference";
            this.tableCell15.Weight = 0.16933333813844614D;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.Detail.Dpi = 254F;
            this.Detail.EvenStyleName = "ReportEvenStyle";
            this.Detail.HeightF = 106.375F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "ReportOddStyle";
            this.Detail.StyleName = "ReportDetailBandStyle";
            // 
            // table2
            // 
            this.table2.Dpi = 254F;
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table2.Name = "table2";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(1592F, 63.5F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell16,
            this.tableCell17,
            this.tableCell18,
            this.tableCell19,
            this.tableCell20,
            this.tableCell21,
            this.tableCell22,
            this.tableCell23,
            this.tableCell24,
            this.tableCell25,
            this.tableCell26,
            this.tableCell27,
            this.tableCell28,
            this.tableCell29,
            this.tableCell30});
            this.tableRow2.Dpi = 254F;
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 11.499995494453673D;
            // 
            // tableCell16
            // 
            this.tableCell16.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell16.Dpi = 254F;
            this.tableCell16.EvenStyleName = "ReportEvenStyle";
            this.tableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IdCO]")});
            this.tableCell16.Name = "tableCell16";
            this.tableCell16.OddStyleName = "ReportOddStyle";
            this.tableCell16.StyleName = "ReportDetailBandStyle";
            this.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell16.Weight = 0.16933333813844614D;
            this.tableCell16.WordWrap = false;
            // 
            // tableCell17
            // 
            this.tableCell17.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell17.Dpi = 254F;
            this.tableCell17.EvenStyleName = "ReportEvenStyle";
            this.tableCell17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[companyCode]")});
            this.tableCell17.Name = "tableCell17";
            this.tableCell17.OddStyleName = "ReportOddStyle";
            this.tableCell17.StyleName = "ReportDetailBandStyle";
            this.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell17.Weight = 0.16933333813844614D;
            this.tableCell17.WordWrap = false;
            // 
            // tableCell18
            // 
            this.tableCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell18.Dpi = 254F;
            this.tableCell18.EvenStyleName = "ReportEvenStyle";
            this.tableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompletedDate]")});
            this.tableCell18.Name = "tableCell18";
            this.tableCell18.OddStyleName = "ReportOddStyle";
            this.tableCell18.StyleName = "ReportDetailBandStyle";
            this.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell18.TextFormatString = "{0:d}";
            this.tableCell18.Weight = 0.16933333813844614D;
            this.tableCell18.WordWrap = false;
            // 
            // tableCell19
            // 
            this.tableCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell19.Dpi = 254F;
            this.tableCell19.EvenStyleName = "ReportEvenStyle";
            this.tableCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EffectiveDate]")});
            this.tableCell19.Name = "tableCell19";
            this.tableCell19.OddStyleName = "ReportOddStyle";
            this.tableCell19.StyleName = "ReportDetailBandStyle";
            this.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell19.TextFormatString = "{0:d}";
            this.tableCell19.Weight = 0.16933333813844614D;
            this.tableCell19.WordWrap = false;
            // 
            // tableCell20
            // 
            this.tableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell20.Dpi = 254F;
            this.tableCell20.EvenStyleName = "ReportEvenStyle";
            this.tableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Contractualdate]")});
            this.tableCell20.Name = "tableCell20";
            this.tableCell20.OddStyleName = "ReportOddStyle";
            this.tableCell20.StyleName = "ReportDetailBandStyle";
            this.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell20.TextFormatString = "{0:d}";
            this.tableCell20.Weight = 0.16933333813844614D;
            this.tableCell20.WordWrap = false;
            // 
            // tableCell21
            // 
            this.tableCell21.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell21.Dpi = 254F;
            this.tableCell21.EvenStyleName = "ReportEvenStyle";
            this.tableCell21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Operation]")});
            this.tableCell21.Name = "tableCell21";
            this.tableCell21.OddStyleName = "ReportOddStyle";
            this.tableCell21.StyleName = "ReportDetailBandStyle";
            this.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell21.Weight = 0.16933333813844614D;
            this.tableCell21.WordWrap = false;
            // 
            // tableCell22
            // 
            this.tableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell22.Dpi = 254F;
            this.tableCell22.EvenStyleName = "ReportEvenStyle";
            this.tableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[idMovement]")});
            this.tableCell22.Name = "tableCell22";
            this.tableCell22.OddStyleName = "ReportOddStyle";
            this.tableCell22.StyleName = "ReportDetailBandStyle";
            this.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell22.Weight = 0.16933333813844614D;
            this.tableCell22.WordWrap = false;
            // 
            // tableCell23
            // 
            this.tableCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell23.Dpi = 254F;
            this.tableCell23.EvenStyleName = "ReportEvenStyle";
            this.tableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cost]")});
            this.tableCell23.Name = "tableCell23";
            this.tableCell23.OddStyleName = "ReportOddStyle";
            this.tableCell23.StyleName = "ReportDetailBandStyle";
            this.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell23.Weight = 0.16933333813844614D;
            this.tableCell23.WordWrap = false;
            // 
            // tableCell24
            // 
            this.tableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell24.Dpi = 254F;
            this.tableCell24.EvenStyleName = "ReportEvenStyle";
            this.tableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Currency]")});
            this.tableCell24.Name = "tableCell24";
            this.tableCell24.OddStyleName = "ReportOddStyle";
            this.tableCell24.StyleName = "ReportDetailBandStyle";
            this.tableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell24.Weight = 0.16933333813844614D;
            this.tableCell24.WordWrap = false;
            // 
            // tableCell25
            // 
            this.tableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell25.Dpi = 254F;
            this.tableCell25.EvenStyleName = "ReportEvenStyle";
            this.tableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CostVATCode]")});
            this.tableCell25.Name = "tableCell25";
            this.tableCell25.OddStyleName = "ReportOddStyle";
            this.tableCell25.StyleName = "ReportDetailBandStyle";
            this.tableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell25.Weight = 0.16933333813844614D;
            this.tableCell25.WordWrap = false;
            // 
            // tableCell26
            // 
            this.tableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell26.Dpi = 254F;
            this.tableCell26.EvenStyleName = "ReportEvenStyle";
            this.tableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DateCreation]")});
            this.tableCell26.Name = "tableCell26";
            this.tableCell26.OddStyleName = "ReportOddStyle";
            this.tableCell26.StyleName = "ReportDetailBandStyle";
            this.tableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell26.TextFormatString = "{0:d}";
            this.tableCell26.Weight = 0.16933333813844614D;
            this.tableCell26.WordWrap = false;
            // 
            // tableCell27
            // 
            this.tableCell27.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell27.Dpi = 254F;
            this.tableCell27.EvenStyleName = "ReportEvenStyle";
            this.tableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CostProvider]")});
            this.tableCell27.Name = "tableCell27";
            this.tableCell27.OddStyleName = "ReportOddStyle";
            this.tableCell27.StyleName = "ReportDetailBandStyle";
            this.tableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell27.Weight = 0.16933333813844614D;
            this.tableCell27.WordWrap = false;
            // 
            // tableCell28
            // 
            this.tableCell28.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell28.Dpi = 254F;
            this.tableCell28.EvenStyleName = "ReportEvenStyle";
            this.tableCell28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CostProviderFerry]")});
            this.tableCell28.Name = "tableCell28";
            this.tableCell28.OddStyleName = "ReportOddStyle";
            this.tableCell28.StyleName = "ReportDetailBandStyle";
            this.tableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell28.Weight = 0.16933333813844614D;
            this.tableCell28.WordWrap = false;
            // 
            // tableCell29
            // 
            this.tableCell29.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell29.Dpi = 254F;
            this.tableCell29.EvenStyleName = "ReportEvenStyle";
            this.tableCell29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VehicleDetails]")});
            this.tableCell29.Name = "tableCell29";
            this.tableCell29.OddStyleName = "ReportOddStyle";
            this.tableCell29.StyleName = "ReportDetailBandStyle";
            this.tableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell29.Weight = 0.16933333813844614D;
            this.tableCell29.WordWrap = false;
            // 
            // tableCell30
            // 
            this.tableCell30.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tableCell30.Dpi = 254F;
            this.tableCell30.EvenStyleName = "ReportEvenStyle";
            this.tableCell30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MvtReference]")});
            this.tableCell30.Name = "tableCell30";
            this.tableCell30.OddStyleName = "ReportOddStyle";
            this.tableCell30.StyleName = "ReportDetailBandStyle";
            this.tableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tableCell30.Weight = 0.16933333813844614D;
            this.tableCell30.WordWrap = false;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 322.7917F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeaderBandStyle
            // 
            this.ReportHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportHeaderBandStyle.Name = "ReportHeaderBandStyle";
            this.ReportHeaderBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportGroupHeaderBandStyle
            // 
            this.ReportGroupHeaderBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportGroupHeaderBandStyle.Name = "ReportGroupHeaderBandStyle";
            this.ReportGroupHeaderBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254F);
            this.ReportGroupHeaderBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportDetailBandStyle
            // 
            this.ReportDetailBandStyle.Name = "ReportDetailBandStyle";
            this.ReportDetailBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportDetailBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportGroupFooterBandStyle
            // 
            this.ReportGroupFooterBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportGroupFooterBandStyle.Name = "ReportGroupFooterBandStyle";
            this.ReportGroupFooterBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportGroupFooterBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportFooterBandStyle
            // 
            this.ReportFooterBandStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.ReportFooterBandStyle.Name = "ReportFooterBandStyle";
            this.ReportFooterBandStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportFooterBandStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportOddStyle
            // 
            this.ReportOddStyle.Name = "ReportOddStyle";
            this.ReportOddStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportOddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportEvenStyle
            // 
            this.ReportEvenStyle.Name = "ReportEvenStyle";
            this.ReportEvenStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 254F);
            this.ReportEvenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // movementTableAdapter
            // 
            this.movementTableAdapter.ClearBeforeFill = true;
            // 
            // movementBindingSource1
            // 
            this.movementBindingSource1.DataMember = "Movement";
            this.movementBindingSource1.DataSource = this.movementCO;
            this.movementBindingSource1.Position = 0;
            // 
            // movementCO
            // 
            this.movementCO.DataSetName = "MovementCO";
            this.movementCO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChargingOrderReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.PageHeader,
            this.Detail,
            this.BottomMargin});
            this.DataAdapter = this.movementTableAdapter;
            this.DataSource = this.movementBindingSource1;
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(254, 254, 100, 323);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.ReportHeaderBandStyle,
            this.ReportGroupHeaderBandStyle,
            this.ReportDetailBandStyle,
            this.ReportGroupFooterBandStyle,
            this.ReportFooterBandStyle,
            this.ReportOddStyle,
            this.ReportEvenStyle});
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementCO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}

namespace EFRET_TMS
{
    public class ChargingOrderReports : DevExpress.XtraReports.UI.XtraReport
    {
      
    }
}