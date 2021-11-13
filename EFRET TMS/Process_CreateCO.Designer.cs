
namespace EFRET_TMS
{
    partial class ProcessCreateCo
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.stepProgressBar1 = new DevExpress.XtraEditors.StepProgressBar();
            this.stepProgressBarItem1 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem2 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem4 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem5 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem6 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem3 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.radTextBoxControl1 = new Telerik.WinControls.UI.RadTextBoxControl();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.stepProgressBar2 = new DevExpress.XtraEditors.StepProgressBar();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.process1 = new System.Diagnostics.Process();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.welcomeWizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).BeginInit();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepProgressBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(848, 447);
            this.wizardControl1.Text = "Charging Order Creation";
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.ProcessEnd);
            this.wizardControl1.Click += new System.EventHandler(this.wizardControl1_Click);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Controls.Add(this.simpleButton1);
            this.welcomeWizardPage1.Controls.Add(this.stepProgressBar1);
            this.welcomeWizardPage1.Controls.Add(this.radTextBoxControl1);
            this.welcomeWizardPage1.IntroductionText = "If a company fails to validate, a new company can be created.";
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(631, 315);
            this.welcomeWizardPage1.Text = "Enter Company Code Or VAT Number";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(313, 47);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(315, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Validate";
            // 
            // stepProgressBar1
            // 
            this.stepProgressBar1.Appearance.BackColor = System.Drawing.Color.White;
            this.stepProgressBar1.Appearance.Options.UseBackColor = true;
            this.stepProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem1);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem2);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem4);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem5);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem6);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem3);
            this.stepProgressBar1.Location = new System.Drawing.Point(0, 225);
            this.stepProgressBar1.Name = "stepProgressBar1";
            this.stepProgressBar1.SelectedItemIndex = 0;
            this.stepProgressBar1.Size = new System.Drawing.Size(631, 90);
            this.stepProgressBar1.TabIndex = 4;
            // 
            // stepProgressBarItem1
            // 
            this.stepProgressBarItem1.ContentBlock2.Appearance.Caption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.stepProgressBarItem1.ContentBlock2.Appearance.Caption.Options.UseForeColor = true;
            this.stepProgressBarItem1.ContentBlock2.Caption = "Select Company";
            this.stepProgressBarItem1.Name = "stepProgressBarItem1";
            this.stepProgressBarItem1.State = DevExpress.XtraEditors.StepProgressBarItemState.Active;
            // 
            // stepProgressBarItem2
            // 
            this.stepProgressBarItem2.ContentBlock2.Appearance.Caption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.stepProgressBarItem2.ContentBlock2.Appearance.Caption.Options.UseForeColor = true;
            this.stepProgressBarItem2.ContentBlock2.Caption = "Route Planning";
            this.stepProgressBarItem2.Name = "stepProgressBarItem2";
            // 
            // stepProgressBarItem4
            // 
            this.stepProgressBarItem4.ContentBlock2.Caption = "Cost Agreement";
            this.stepProgressBarItem4.Name = "stepProgressBarItem4";
            // 
            // stepProgressBarItem5
            // 
            this.stepProgressBarItem5.ContentBlock2.Caption = "Fleet Selection";
            this.stepProgressBarItem5.Name = "stepProgressBarItem5";
            // 
            // stepProgressBarItem6
            // 
            this.stepProgressBarItem6.ContentBlock2.Caption = "Time Scheduling";
            this.stepProgressBarItem6.Name = "stepProgressBarItem6";
            // 
            // stepProgressBarItem3
            // 
            this.stepProgressBarItem3.ContentBlock2.Appearance.Caption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.stepProgressBarItem3.ContentBlock2.Appearance.Caption.Options.UseForeColor = true;
            this.stepProgressBarItem3.ContentBlock2.Caption = "Summary";
            this.stepProgressBarItem3.Name = "stepProgressBarItem3";
            // 
            // radTextBoxControl1
            // 
            radListDataItem1.Text = "CompanyCodes";
            this.radTextBoxControl1.AutoCompleteItems.Add(radListDataItem1);
            this.radTextBoxControl1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.radTextBoxControl1.Location = new System.Drawing.Point(15, 47);
            this.radTextBoxControl1.Name = "radTextBoxControl1";
            this.radTextBoxControl1.Size = new System.Drawing.Size(284, 23);
            this.radTextBoxControl1.TabIndex = 1;
            this.radTextBoxControl1.Text = "AMALON or AMAZON or 03223028";
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.stepProgressBar2);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(816, 304);
            this.wizardPage1.Text = "Enter Company Name or Number ";
            // 
            // stepProgressBar2
            // 
            this.stepProgressBar2.Appearance.BackColor = System.Drawing.Color.White;
            this.stepProgressBar2.Appearance.Options.UseBackColor = true;
            this.stepProgressBar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stepProgressBar2.Items.Add(this.stepProgressBarItem1);
            this.stepProgressBar2.Items.Add(this.stepProgressBarItem2);
            this.stepProgressBar2.Items.Add(this.stepProgressBarItem3);
            this.stepProgressBar2.Location = new System.Drawing.Point(0, 214);
            this.stepProgressBar2.Name = "stepProgressBar2";
            this.stepProgressBar2.SelectedItemIndex = 0;
            this.stepProgressBar2.Size = new System.Drawing.Size(816, 90);
            this.stepProgressBar2.TabIndex = 5;
            this.stepProgressBar2.Click += new System.EventHandler(this.stepProgressBar2_Click);
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(631, 315);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // ProcessCreateCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wizardControl1);
            this.Name = "ProcessCreateCo";
            this.Size = new System.Drawing.Size(848, 447);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.welcomeWizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stepProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).EndInit();
            this.wizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stepProgressBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl1;
        private DevExpress.XtraEditors.StepProgressBar stepProgressBar1;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem1;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem2;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem3;
        private System.Diagnostics.Process process1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.StepProgressBar stepProgressBar2;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem4;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem5;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem6;
    }
}
