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
    public partial class ActivateCO : UserControl
    {
        private string _newCO;
        public ActivateCO()
        {
            InitializeComponent();
        }

        private void ultraButton1_Click(object sender, EventArgs e)

        {
            _newCO = ultraFormattedTextEditor1.Text;
            string queryString = "UPDATE [axs].[dbo].[NewCO] SET Actif = 0 WHERE NewCO = '" + _newCO + "'";
            string connectionString = @"Server=EFRET-APP-01\EFRET;Database=axs;Trusted_Connection=True;";

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
                            ultraStatusBar1.Text = _newCO + " was not found. Nothing changed.";

                            // Houston, we have a problem.
                        }
                        else
                        {
                            RadForm1.LogMessage(Environment.UserName + " reactivated " + _newCO);
                            ultraStatusBar1.Text = _newCO + " has been activated.";
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
    }
}
