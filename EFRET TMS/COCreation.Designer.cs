namespace EFRET_TMS
{
    partial class CoCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoCreation));
            this.axsDataSet = new EFRET_TMS.AxsDataSet();
            this.axsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newCOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // axsDataSet
            // 
            this.axsDataSet.DataSetName = "axsDataSet";
            this.axsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // axsDataSetBindingSource
            // 
            this.axsDataSetBindingSource.DataSource = this.axsDataSet;
            this.axsDataSetBindingSource.Position = 0;
            // 
            // newCOBindingSource
            // 
            this.newCOBindingSource.DataMember = "NewCO";
            this.newCOBindingSource.DataSource = this.axsDataSetBindingSource;
            // 
            // CoCreation
            // 
            this.ClientSize = new System.Drawing.Size(917, 490);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("CoCreation.IconOptions.SvgImage")));
            this.Name = "CoCreation";
            this.Load += new System.EventHandler(this.COCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxsDataSet axsDataSet;
        private System.Windows.Forms.BindingSource axsDataSetBindingSource;
        private System.Windows.Forms.BindingSource newCOBindingSource;
    }
}
