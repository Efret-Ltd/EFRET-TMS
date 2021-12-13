namespace EFRET_TMS
{
    partial class OnboardP44
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
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.radButtonTextBox1 = new Telerik.WinControls.UI.RadButtonTextBox();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraButton1
            // 
            this.ultraButton1.Location = new System.Drawing.Point(171, 12);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(117, 23);
            this.ultraButton1.TabIndex = 0;
            this.ultraButton1.Text = "Invite to P44";
            this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // radButtonTextBox1
            // 
            this.radButtonTextBox1.Location = new System.Drawing.Point(12, 11);
            this.radButtonTextBox1.Name = "radButtonTextBox1";
            this.radButtonTextBox1.Size = new System.Drawing.Size(153, 24);
            this.radButtonTextBox1.TabIndex = 1;
            this.radButtonTextBox1.Text = "Company Code";
            // 
            // autoLabel1
            // 
            this.autoLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.autoLabel1.Location = new System.Drawing.Point(12, 48);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(11, 17);
            this.autoLabel1.Style = Syncfusion.Windows.Forms.Tools.AutoLabelStyle.Office2016Colorful;
            this.autoLabel1.TabIndex = 2;
            this.autoLabel1.Text = ".";
            this.autoLabel1.ThemeName = "Office2016Colorful";
            // 
            // OnboardP44
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 74);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.radButtonTextBox1);
            this.Controls.Add(this.ultraButton1);
            this.Name = "OnboardP44";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "OnboardP44";
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private Telerik.WinControls.UI.RadButtonTextBox radButtonTextBox1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
    }
}
