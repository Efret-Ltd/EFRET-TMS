using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sentry;
using Telerik.WinControls;

namespace EFRET_TMS
{
    
    public partial class UploadtoP44 : UserControl
    {
        public UploadtoP44()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            string queryString = "UPDATE NewCO SET P44UploadError=0,P44ReasonDescription=NULL,P44ReasonCode=NULL,P44ToUpload=1 WHERE NewCO = '"+textEdit1+"'";
            string connectionString = @"Server=EFRET-APP-01\EFRET;Database=axs;Trusted_Connection=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {

                        }
                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                        RadMessageBox.Show("Job Done");
                    }

                }
            }
            catch (Exception ex)
            {

                SentrySdk.CaptureException(ex);
            }
        }

    }
}