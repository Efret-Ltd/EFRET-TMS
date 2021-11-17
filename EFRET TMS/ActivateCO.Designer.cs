
namespace EFRET_TMS
{
    partial class ActivateCO
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab1 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            this.ultraStatusBar1 = new Infragistics.Win.UltraWinStatusBar.UltraStatusBar();
            this.ultraFormManager1 = new Infragistics.Win.UltraWinForm.UltraFormManager(this.components);
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraTabStripControl1 = new Infragistics.Win.UltraWinTabControl.UltraTabStripControl();
            this.ultraTabSharedControlsPage1 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
            this.ultraFormattedTextEditor1 = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.ultraStatusBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraFormManager1)).BeginInit();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabStripControl1)).BeginInit();
            this.ultraTabStripControl1.SuspendLayout();
            this.ultraTabSharedControlsPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraStatusBar1
            // 
            this.ultraStatusBar1.Location = new System.Drawing.Point(0, 104);
            this.ultraStatusBar1.Name = "ultraStatusBar1";
            this.ultraStatusBar1.Size = new System.Drawing.Size(301, 27);
            this.ultraStatusBar1.TabIndex = 0;
            this.ultraStatusBar1.Text = "ultraStatusBar1";
            // 
            // ultraPanel1
            // 
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraTabStripControl1);
            this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraPanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(301, 104);
            this.ultraPanel1.TabIndex = 1;
            // 
            // ultraTabStripControl1
            // 
            this.ultraTabStripControl1.CloseButtonLocation = Infragistics.Win.UltraWinTabs.TabCloseButtonLocation.HeaderArea;
            this.ultraTabStripControl1.Controls.Add(this.ultraTabSharedControlsPage1);
            this.ultraTabStripControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraTabStripControl1.Location = new System.Drawing.Point(0, 0);
            this.ultraTabStripControl1.Name = "ultraTabStripControl1";
            this.ultraTabStripControl1.SharedControls.AddRange(new System.Windows.Forms.Control[] {
            this.ultraFormattedTextEditor1,
            this.ultraButton1});
            this.ultraTabStripControl1.SharedControlsPage = this.ultraTabSharedControlsPage1;
            this.ultraTabStripControl1.Size = new System.Drawing.Size(301, 104);
            this.ultraTabStripControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPageFlat;
            this.ultraTabStripControl1.TabIndex = 0;
            ultraTab1.Text = "tab1";
            this.ultraTabStripControl1.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
            ultraTab1});
            // 
            // ultraTabSharedControlsPage1
            // 
            this.ultraTabSharedControlsPage1.Controls.Add(this.ultraButton1);
            this.ultraTabSharedControlsPage1.Controls.Add(this.ultraFormattedTextEditor1);
            this.ultraTabSharedControlsPage1.Location = new System.Drawing.Point(2, 24);
            this.ultraTabSharedControlsPage1.Name = "ultraTabSharedControlsPage1";
            this.ultraTabSharedControlsPage1.Size = new System.Drawing.Size(297, 78);
            // 
            // ultraFormattedTextEditor1
            // 
            this.ultraFormattedTextEditor1.Location = new System.Drawing.Point(3, 31);
            this.ultraFormattedTextEditor1.Name = "ultraFormattedTextEditor1";
            this.ultraFormattedTextEditor1.Size = new System.Drawing.Size(191, 22);
            this.ultraFormattedTextEditor1.TabIndex = 0;
            this.ultraFormattedTextEditor1.Value = "Enter New CO Number";
            // 
            // ultraButton1
            // 
            this.ultraButton1.Location = new System.Drawing.Point(219, 30);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(75, 23);
            this.ultraButton1.TabIndex = 1;
            this.ultraButton1.Text = "Active CO";
            this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // ActivateCO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ultraPanel1);
            this.Controls.Add(this.ultraStatusBar1);
            this.Name = "ActivateCO";
            this.Size = new System.Drawing.Size(301, 131);
            ((System.ComponentModel.ISupportInitialize)(this.ultraStatusBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraFormManager1)).EndInit();
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabStripControl1)).EndInit();
            this.ultraTabStripControl1.ResumeLayout(false);
            this.ultraTabSharedControlsPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinStatusBar.UltraStatusBar ultraStatusBar1;
        private Infragistics.Win.UltraWinForm.UltraFormManager ultraFormManager1;
        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private Infragistics.Win.UltraWinTabControl.UltraTabStripControl ultraTabStripControl1;
        private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage1;
        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor ultraFormattedTextEditor1;
    }
}
