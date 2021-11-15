using System;
using System.Data.SqlClient;
using Sentry;

namespace EFRET_TMS
{
    public partial class CoCost : DevExpress.XtraEditors.XtraForm
    {
        public CoCost(string newCo)
        {
            InitializeComponent();
            GetCosts(newCo);
            this.Text = "Costs For CO: " + newCo;
        }

        private void COCost_Load(object sender, EventArgs e)
        {

        }

        private void GetCosts(string newCo)
        {
            string queryString = "Select * FROM NewCO WHERE NewCO ='" + newCo + "'";
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
                            textEdit1.Text = reader["BaseFreightRate"].ToString();
                            textEdit2.Text = reader["Cancellation"].ToString();
                            textEdit3.Text = reader["Wharehousing"].ToString();
                            textEdit4.Text = reader["ReroutingSurcharge"].ToString();
                            textEdit5.Text = reader["demurrage"].ToString();
                            textEdit6.Text = reader["DriverDententionAtUnloading"].ToString();
                            textEdit7.Text = reader["Corridor"].ToString();
                            textEdit8.Text = reader["Line"].ToString();
                            textEdit9.Text = reader["Redelivery"].ToString();
                            textEdit10.Text= reader["AdhocRate"].ToString();
                        }
                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
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