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
    public partial class ClearZerosOnCO : UserControl
    {
        private int _idCO;
        private int recordCount;
        public ClearZerosOnCO()
        {
            InitializeComponent();
            if (Environment.UserName == "dan.khosa" || Environment.UserName == "sysadmin")
            {
                simpleButton1.Visible = true;
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            _idCO = Int32.Parse(radTextBox1.Text);
            FixKM(_idCO);
            FixCost(_idCO);
        }

        private void FixKM(int idCO)
        {
            string queryString = "UPDATE Movement SET KM = null WHERE KM = '0' AND IdCO='" + _idCO + "'";
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

    private void FixCost(int idCO) 
    {
            string queryString = "UPDATE Movement SET Cost = null WHERE Cost = '0' AND IdCO='" + idCO + "'";
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
                    }

                }
            }
            catch (Exception ex)
            {

                SentrySdk.CaptureException(ex);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            recordCount = 0;
            string queryString = "UPDATE Movement SET Cost = null WHERE Cost = '0'";
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
                                recordCount++;
                            }
                        }
                        finally
                        {
                            // Always call Close when done reading.
                            reader.Close();
                            RadMessageBox.Show(recordCount.ToString() + " Records have been fixed where cost was 0.");
                            recordCount = 0;
                    }

                    }
                }
                catch (Exception ex)
                {

                    SentrySdk.CaptureException(ex);
                }
                string fixKMString = "UPDATE Movement SET KM = null WHERE KM = '0'";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(fixKMString, connection);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        try
                        {
                            while (reader.Read())
                            {
                                recordCount++;
                            }
                        }
                        finally
                        {
                            // Always call Close when done reading.
                            reader.Close();
                            RadMessageBox.Show(recordCount.ToString() + " Records have been fixed where KM was 0.");
                            recordCount = 0;
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
