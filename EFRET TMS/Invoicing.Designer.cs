namespace EFRET_TMS
{
    partial class Invoicing
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoicing));
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.radGridView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dropDownButton1
            // 
            this.tablePanel1.SetColumn(this.dropDownButton1, 1);
            this.dropDownButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropDownButton1.Location = new System.Drawing.Point(114, 3);
            this.dropDownButton1.Name = "dropDownButton1";
            this.tablePanel1.SetRow(this.dropDownButton1, 0);
            this.dropDownButton1.Size = new System.Drawing.Size(863, 56);
            this.dropDownButton1.TabIndex = 0;
            this.dropDownButton1.Text = "List C.O. for a provider";
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 6.82F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 53.18F)});
            this.tablePanel1.Controls.Add(this.simpleButton5);
            this.tablePanel1.Controls.Add(this.simpleButton4);
            this.tablePanel1.Controls.Add(this.navigationPane1);
            this.tablePanel1.Controls.Add(this.simpleButton3);
            this.tablePanel1.Controls.Add(this.radGridView2);
            this.tablePanel1.Controls.Add(this.splitContainerControl1);
            this.tablePanel1.Controls.Add(this.radGridView1);
            this.tablePanel1.Controls.Add(this.dropDownButton1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 62F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 103F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 45F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 85F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(980, 551);
            this.tablePanel1.TabIndex = 1;
            // 
            // radGridView1
            // 
            this.tablePanel1.SetColumn(this.radGridView1, 1);
            this.radGridView1.Controls.Add(this.radLabel1);
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(114, 65);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridView1.Name = "radGridView1";
            this.tablePanel1.SetRow(this.radGridView1, 1);
            this.radGridView1.Size = new System.Drawing.Size(863, 97);
            this.radGridView1.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(247, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(287, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "CO listing with NO date of invoice and NO sage number";
            // 
            // splitContainerControl1
            // 
            this.tablePanel1.SetColumn(this.splitContainerControl1, 1);
            this.splitContainerControl1.Location = new System.Drawing.Point(114, 168);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.tablePanel1.SetRow(this.splitContainerControl1, 2);
            this.splitContainerControl1.Size = new System.Drawing.Size(863, 39);
            this.splitContainerControl1.SplitterPosition = 390;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(0, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(390, 39);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Add";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(0, 0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(463, 39);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Subtract";
            // 
            // radGridView2
            // 
            this.tablePanel1.SetColumn(this.radGridView2, 1);
            this.radGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView2.Location = new System.Drawing.Point(114, 213);
            // 
            // 
            // 
            this.radGridView2.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView2.Name = "radGridView2";
            this.tablePanel1.SetRow(this.radGridView2, 3);
            this.radGridView2.Size = new System.Drawing.Size(863, 79);
            this.radGridView2.TabIndex = 3;
            // 
            // simpleButton3
            // 
            this.tablePanel1.SetColumn(this.simpleButton3, 0);
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(3, 213);
            this.simpleButton3.Name = "simpleButton3";
            this.tablePanel1.SetRow(this.simpleButton3, 3);
            this.simpleButton3.Size = new System.Drawing.Size(105, 79);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Pro Forma";
            // 
            // navigationPane1
            // 
            this.navigationPane1.AllowHtmlDraw = true;
            this.tablePanel1.SetColumn(this.navigationPane1, 1);
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage3);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(114, 298);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2,
            this.navigationPage3});
            this.navigationPane1.RegularSize = new System.Drawing.Size(863, 250);
            this.tablePanel1.SetRow(this.navigationPane1, 4);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(863, 250);
            this.navigationPane1.TabIndex = 5;
            this.navigationPane1.Text = "SI Validation before Exportation";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "First Step";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(748, 177);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Second Step";
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(688, 236);
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "Third Step";
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(688, 236);
            // 
            // simpleButton4
            // 
            this.tablePanel1.SetColumn(this.simpleButton4, 0);
            this.simpleButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton4.Location = new System.Drawing.Point(3, 3);
            this.simpleButton4.Name = "simpleButton4";
            this.tablePanel1.SetRow(this.simpleButton4, 0);
            this.simpleButton4.Size = new System.Drawing.Size(105, 56);
            this.simpleButton4.TabIndex = 6;
            this.simpleButton4.Text = "Copy of Existing PDF";
            // 
            // simpleButton5
            // 
            this.tablePanel1.SetColumn(this.simpleButton5, 0);
            this.simpleButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton5.Location = new System.Drawing.Point(3, 65);
            this.simpleButton5.Name = "simpleButton5";
            this.tablePanel1.SetRow(this.simpleButton5, 1);
            this.simpleButton5.Size = new System.Drawing.Size(105, 97);
            this.simpleButton5.TabIndex = 7;
            this.simpleButton5.Text = "Modify Company";
            // 
            // Invoicing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 551);
            this.Controls.Add(this.tablePanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Invoicing";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Invoicing";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.radGridView1.ResumeLayout(false);
            this.radGridView1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private Telerik.WinControls.UI.RadGridView radGridView2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}
