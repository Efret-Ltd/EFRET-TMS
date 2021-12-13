
namespace EFRET_TMS
{
    partial class TrailerBlacklist
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.axsTrailerBlacklist = new EFRET_TMS.axsTrailerBlacklist();
            this.paramTrailerNumberBlacklistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paramTrailerNumberBlacklistTableAdapter = new EFRET_TMS.axsTrailerBlacklistTableAdapters.ParamTrailerNumberBlacklistTableAdapter();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.axsTrailerBlacklistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axsTrailerBlacklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramTrailerNumberBlacklistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axsTrailerBlacklistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // axsTrailerBlacklist
            // 
            this.axsTrailerBlacklist.DataSetName = "axsTrailerBlacklist";
            this.axsTrailerBlacklist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paramTrailerNumberBlacklistBindingSource
            // 
            this.paramTrailerNumberBlacklistBindingSource.DataMember = "ParamTrailerNumberBlacklist";
            this.paramTrailerNumberBlacklistBindingSource.DataSource = this.axsTrailerBlacklist;
            // 
            // paramTrailerNumberBlacklistTableAdapter
            // 
            this.paramTrailerNumberBlacklistTableAdapter.ClearBeforeFill = true;
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.DataSource = this.axsTrailerBlacklistBindingSource;
            this.radGridView1.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(528, 419);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Click += new System.EventHandler(this.radGridView1_Click);
            // 
            // axsTrailerBlacklistBindingSource
            // 
            this.axsTrailerBlacklistBindingSource.DataSource = this.axsTrailerBlacklist;
            this.axsTrailerBlacklistBindingSource.Position = 0;
            // 
            // TrailerBlacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radGridView1);
            this.Name = "TrailerBlacklist";
            this.Size = new System.Drawing.Size(528, 419);
            ((System.ComponentModel.ISupportInitialize)(this.axsTrailerBlacklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramTrailerNumberBlacklistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axsTrailerBlacklistBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private axsTrailerBlacklist axsTrailerBlacklist;
        private System.Windows.Forms.BindingSource paramTrailerNumberBlacklistBindingSource;
        private axsTrailerBlacklistTableAdapters.ParamTrailerNumberBlacklistTableAdapter paramTrailerNumberBlacklistTableAdapter;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource axsTrailerBlacklistBindingSource;
    }
}
