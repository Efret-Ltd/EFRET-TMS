namespace EFRET_TMS
{
    partial class ToolsUtiltiesMenu
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
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.roundRectShapeTitle = new Telerik.WinControls.RoundRectShape(this.components);
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.vatCheckButton = new Syncfusion.WinForms.Controls.SfButton();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.sfButton3 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton4 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton5 = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTitleBar1.Location = new System.Drawing.Point(1, 1);
            this.radTitleBar1.Name = "radTitleBar1";
            // 
            // 
            // 
            this.radTitleBar1.RootElement.ApplyShapeToControl = true;
            this.radTitleBar1.RootElement.Shape = this.roundRectShapeTitle;
            this.radTitleBar1.Size = new System.Drawing.Size(398, 23);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "ToolsUtiltiesMenu";
            // 
            // roundRectShapeTitle
            // 
            this.roundRectShapeTitle.BottomLeftRounded = false;
            this.roundRectShapeTitle.BottomRightRounded = false;
            // 
            // vatCheckButton
            // 
            this.vatCheckButton.AccessibleName = "Button";
            this.tablePanel1.SetColumn(this.vatCheckButton, 0);
            this.vatCheckButton.FocusRectangleVisible = true;
            this.vatCheckButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.vatCheckButton.Location = new System.Drawing.Point(3, 3);
            this.vatCheckButton.Name = "vatCheckButton";
            this.tablePanel1.SetRow(this.vatCheckButton, 0);
            this.vatCheckButton.Size = new System.Drawing.Size(188, 20);
            this.vatCheckButton.TabIndex = 2;
            this.vatCheckButton.Text = "VAT Check";
            this.vatCheckButton.Click += new System.EventHandler(this.vatCheckButton_Click);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 27.08F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.88F)});
            this.tablePanel1.Controls.Add(this.sfButton5);
            this.tablePanel1.Controls.Add(this.sfButton4);
            this.tablePanel1.Controls.Add(this.sfButton3);
            this.tablePanel1.Controls.Add(this.sfButton2);
            this.tablePanel1.Controls.Add(this.sfButton1);
            this.tablePanel1.Controls.Add(this.vatCheckButton);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablePanel1.Location = new System.Drawing.Point(0, 30);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(400, 349);
            this.tablePanel1.TabIndex = 3;
            // 
            // sfButton3
            // 
            this.sfButton3.AccessibleName = "Button";
            this.tablePanel1.SetColumn(this.sfButton3, 1);
            this.sfButton3.FocusRectangleVisible = true;
            this.sfButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton3.Location = new System.Drawing.Point(197, 29);
            this.sfButton3.Name = "sfButton3";
            this.tablePanel1.SetRow(this.sfButton3, 1);
            this.sfButton3.Size = new System.Drawing.Size(200, 20);
            this.sfButton3.TabIndex = 5;
            this.sfButton3.Text = "EDI";
            // 
            // sfButton2
            // 
            this.sfButton2.AccessibleName = "Button";
            this.tablePanel1.SetColumn(this.sfButton2, 0);
            this.sfButton2.FocusRectangleVisible = true;
            this.sfButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton2.Location = new System.Drawing.Point(3, 29);
            this.sfButton2.Name = "sfButton2";
            this.tablePanel1.SetRow(this.sfButton2, 1);
            this.sfButton2.Size = new System.Drawing.Size(188, 20);
            this.sfButton2.TabIndex = 4;
            this.sfButton2.Text = "Force P44 Upload";
            this.sfButton2.Click += new System.EventHandler(this.sfButton2_Click);
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.tablePanel1.SetColumn(this.sfButton1, 1);
            this.sfButton1.FocusRectangleVisible = true;
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton1.Location = new System.Drawing.Point(197, 3);
            this.sfButton1.Name = "sfButton1";
            this.tablePanel1.SetRow(this.sfButton1, 0);
            this.sfButton1.Size = new System.Drawing.Size(200, 20);
            this.sfButton1.TabIndex = 3;
            this.sfButton1.Text = "Domain Whois";
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // sfButton4
            // 
            this.sfButton4.AccessibleName = "Button";
            this.tablePanel1.SetColumn(this.sfButton4, 1);
            this.sfButton4.FocusRectangleVisible = true;
            this.sfButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton4.Location = new System.Drawing.Point(197, 55);
            this.sfButton4.Name = "sfButton4";
            this.tablePanel1.SetRow(this.sfButton4, 2);
            this.sfButton4.Size = new System.Drawing.Size(200, 20);
            this.sfButton4.TabIndex = 6;
            this.sfButton4.Text = "Reset CO for P44";
            this.sfButton4.Click += new System.EventHandler(this.sfButton4_Click);
            // 
            // sfButton5
            // 
            this.sfButton5.AccessibleName = "Button";
            this.tablePanel1.SetColumn(this.sfButton5, 0);
            this.sfButton5.FocusRectangleVisible = true;
            this.sfButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton5.Location = new System.Drawing.Point(3, 55);
            this.sfButton5.Name = "sfButton5";
            this.tablePanel1.SetRow(this.sfButton5, 2);
            this.sfButton5.Size = new System.Drawing.Size(188, 20);
            this.sfButton5.TabIndex = 7;
            this.sfButton5.Text = "Onboard to P44";
            this.sfButton5.Click += new System.EventHandler(this.sfButton5_Click);
            // 
            // ToolsUtiltiesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 379);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.radTitleBar1);
            this.Name = "ToolsUtiltiesMenu";
            this.Shape = this.roundRectShapeForm;
            this.Text = "ToolsUtiltiesMenu";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.RoundRectShape roundRectShapeTitle;
        private Syncfusion.WinForms.Controls.SfButton vatCheckButton;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private Syncfusion.WinForms.Controls.SfButton sfButton3;
        private Syncfusion.WinForms.Controls.SfButton sfButton4;
        private Syncfusion.WinForms.Controls.SfButton sfButton5;
    }
}
