using System;
using System.Data.SqlClient;
using Sentry;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class CoCreation : DevExpress.XtraEditors.XtraForm
    {
        public CoCreation()
        {
            InitializeComponent();
            InitializeCo();
        }

        private void InitializeCo()
        {
            string connectionString = @"Server=EFRET-APP-01\EFRET;Database=axs;Trusted_Connection=True;";
            string queryString= @"INSERT INTO [dbo].[NewCO]
           ([NewCO]
           ,[UserCreation])
VALUES
('ChangeME','"+Environment.UserName+@"')


            ";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    int affectedRows = command.ExecuteNonQuery();

                    //SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        if (affectedRows <= 0)
                        {

                            // Houston, we have a problem.
                        }
                        else
                        {
                         
                        }

                    }
                    catch (Exception ex)
                    {
                        SentrySdk.CaptureException(ex);
                    }
                }
            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex);
            }
        }

    
        private void COCreation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'company._Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.company._Company);
            RadForm1.LogMessage(Environment.UserName + " Started CO Creation ");
        }

    }
}
