
namespace EFRET_TMS
{
    partial class ShowRatesPage
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
        ///
        private void InitializeComponent()
        {
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(950, 267, 650, 400);
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(583, 329);
            this.layoutControl.TabIndex = 1;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1});
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0);
            this.layoutControlGroup.Size = new System.Drawing.Size(583, 329);
            this.layoutControlGroup.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.CustomizationFormText = "Rate";
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(503, 329);
            this.simpleLabelItem1.Text = "Rate";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(23, 13);
            // 
            // ShowRatesPage
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 329);
            this.Controls.Add(this.layoutControl);
            this.Name = "ShowRatesPage";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
    }
}