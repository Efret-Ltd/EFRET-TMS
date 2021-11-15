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

namespace EFRET_TMS
{
    public partial class ViewCOCost : UserControl
    {
        public ViewCOCost(string NewCO)
        {
            InitializeComponent();
            getCosts(NewCO);
        }

        private void getCosts(string NewCO)
        {
            string queryString = "Select * FROM NewCO WHERE NewCO ='" + NewCO + "'";
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
