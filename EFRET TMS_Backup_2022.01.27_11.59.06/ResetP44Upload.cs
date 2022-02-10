using DevExpress.XtraEditors;
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
    public partial class ResetP44Upload : DevExpress.XtraEditors.XtraForm
    {
        private string _NewCO;
        public ResetP44Upload()
        {
            InitializeComponent();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _NewCO = radTextBox1.Text;
            string queryString = "UPDATE [axs].[dbo].[NewCO] SET P44UploadError = 0, P44ReasonDescription = null,P44ReasonCode = null, P44LastUpdate = null WHERE NewCO = '" + _NewCO+ "'";
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
                            radLabel2.Text = _NewCO + " was not found. Nothing changed.";

                            // Houston, we have a problem.
                        }
                        else
                        {
                            RadForm1.LogMessage(Environment.UserName + " reset "+ _NewCO+" for P44 Upload.");
                            radLabel2.Text = _NewCO + " has been reset.";
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