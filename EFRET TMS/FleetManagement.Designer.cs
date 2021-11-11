namespace EFRET_TMS
{
    partial class FleetManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FleetManagement));
            this.efretTrailerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trailers = new EFRET_TMS.Trailers();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.efretTrailerTableAdapter = new EFRET_TMS.TrailersTableAdapters.EfretTrailerTableAdapter();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colIdEfretTrailer = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTrailerNumber = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRegistrationNumber = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMOTDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNextMOTDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNextMOTAppointmentDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPreviousMOTDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colComment = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMOTPlace = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colInsertionDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colActive = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colGPS = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPaddock = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.efretTrailerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // efretTrailerBindingSource
            // 
            this.efretTrailerBindingSource.DataMember = "EfretTrailer";
            this.efretTrailerBindingSource.DataSource = this.trailers;
            // 
            // trailers
            // 
            this.trailers.DataSetName = "Trailers";
            this.trailers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Find Asset by ID";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barSubItem1});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 3";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 3";
            // 
            // bar4
            // 
            this.bar4.BarName = "Custom 5";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar4.Text = "Custom 5";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Create New Asset";
            this.barSubItem1.Id = 1;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(981, 23);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 365);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(981, 19);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 23);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 342);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(981, 23);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 342);
            // 
            // efretTrailerTableAdapter
            // 
            this.efretTrailerTableAdapter.ClearBeforeFill = true;
            // 
            // treeList1
            // 
            this.behaviorManager1.SetBehaviors(this.treeList1, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.PersistenceBehavior.Create(typeof(DevExpress.Utils.BehaviorSource.PersistenceBehaviorSourceForControl), null, DevExpress.Utils.Behaviors.Common.Storage.Registry, DevExpress.Utils.DefaultBoolean.Default)))});
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIdEfretTrailer,
            this.colTrailerNumber,
            this.colRegistrationNumber,
            this.colMOTDate,
            this.colNextMOTDate,
            this.colNextMOTAppointmentDate,
            this.colPreviousMOTDate,
            this.colComment,
            this.colMOTPlace,
            this.colInsertionDate,
            this.colActive,
            this.colGPS,
            this.colPaddock});
            this.treeList1.DataSource = this.efretTrailerBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 23);
            this.treeList1.MenuManager = this.barManager1;
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(981, 342);
            this.treeList1.TabIndex = 10;
            // 
            // colIdEfretTrailer
            // 
            this.colIdEfretTrailer.FieldName = "IdEfretTrailer";
            this.colIdEfretTrailer.Name = "colIdEfretTrailer";
            this.colIdEfretTrailer.OptionsColumn.ReadOnly = true;
            this.colIdEfretTrailer.Visible = true;
            this.colIdEfretTrailer.VisibleIndex = 0;
            // 
            // colTrailerNumber
            // 
            this.colTrailerNumber.FieldName = "TrailerNumber";
            this.colTrailerNumber.Name = "colTrailerNumber";
            this.colTrailerNumber.OptionsColumn.ReadOnly = true;
            this.colTrailerNumber.Visible = true;
            this.colTrailerNumber.VisibleIndex = 1;
            // 
            // colRegistrationNumber
            // 
            this.colRegistrationNumber.FieldName = "RegistrationNumber";
            this.colRegistrationNumber.Name = "colRegistrationNumber";
            this.colRegistrationNumber.OptionsColumn.ReadOnly = true;
            this.colRegistrationNumber.Visible = true;
            this.colRegistrationNumber.VisibleIndex = 2;
            // 
            // colMOTDate
            // 
            this.colMOTDate.FieldName = "MOTDate";
            this.colMOTDate.Name = "colMOTDate";
            this.colMOTDate.OptionsColumn.ReadOnly = true;
            this.colMOTDate.Visible = true;
            this.colMOTDate.VisibleIndex = 3;
            // 
            // colNextMOTDate
            // 
            this.colNextMOTDate.FieldName = "NextMOTDate";
            this.colNextMOTDate.Name = "colNextMOTDate";
            this.colNextMOTDate.OptionsColumn.ReadOnly = true;
            this.colNextMOTDate.Visible = true;
            this.colNextMOTDate.VisibleIndex = 4;
            // 
            // colNextMOTAppointmentDate
            // 
            this.colNextMOTAppointmentDate.FieldName = "NextMOTAppointmentDate";
            this.colNextMOTAppointmentDate.Name = "colNextMOTAppointmentDate";
            this.colNextMOTAppointmentDate.OptionsColumn.ReadOnly = true;
            this.colNextMOTAppointmentDate.Visible = true;
            this.colNextMOTAppointmentDate.VisibleIndex = 5;
            // 
            // colPreviousMOTDate
            // 
            this.colPreviousMOTDate.FieldName = "PreviousMOTDate";
            this.colPreviousMOTDate.Name = "colPreviousMOTDate";
            this.colPreviousMOTDate.OptionsColumn.ReadOnly = true;
            this.colPreviousMOTDate.Visible = true;
            this.colPreviousMOTDate.VisibleIndex = 6;
            // 
            // colComment
            // 
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.OptionsColumn.ReadOnly = true;
            this.colComment.Visible = true;
            this.colComment.VisibleIndex = 7;
            // 
            // colMOTPlace
            // 
            this.colMOTPlace.FieldName = "MOTPlace";
            this.colMOTPlace.Name = "colMOTPlace";
            this.colMOTPlace.OptionsColumn.ReadOnly = true;
            this.colMOTPlace.Visible = true;
            this.colMOTPlace.VisibleIndex = 8;
            // 
            // colInsertionDate
            // 
            this.colInsertionDate.FieldName = "InsertionDate";
            this.colInsertionDate.Name = "colInsertionDate";
            this.colInsertionDate.OptionsColumn.ReadOnly = true;
            this.colInsertionDate.Visible = true;
            this.colInsertionDate.VisibleIndex = 9;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.OptionsColumn.ReadOnly = true;
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 10;
            // 
            // colGPS
            // 
            this.colGPS.FieldName = "GPS";
            this.colGPS.Name = "colGPS";
            this.colGPS.OptionsColumn.ReadOnly = true;
            this.colGPS.Visible = true;
            this.colGPS.VisibleIndex = 11;
            // 
            // colPaddock
            // 
            this.colPaddock.FieldName = "Paddock";
            this.colPaddock.Name = "colPaddock";
            this.colPaddock.OptionsColumn.ReadOnly = true;
            this.colPaddock.Visible = true;
            this.colPaddock.VisibleIndex = 12;
            // 
            // FleetManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 384);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FleetManagement";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FleetManagement";
            this.Load += new System.EventHandler(this.FleetManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.efretTrailerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private Trailers trailers;
        private System.Windows.Forms.BindingSource efretTrailerBindingSource;
        private TrailersTableAdapters.EfretTrailerTableAdapter efretTrailerTableAdapter;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdEfretTrailer;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTrailerNumber;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRegistrationNumber;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMOTDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNextMOTDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNextMOTAppointmentDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPreviousMOTDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colComment;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMOTPlace;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInsertionDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colActive;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colGPS;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPaddock;
    }
}
