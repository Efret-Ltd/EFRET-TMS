﻿using System;
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
            Random rnd = new Random();
            var user = Environment.UserName;
            int randomNo = rnd.Next(100);

            string queryString = "INSERT INTO [axs].[dbo].[NewCO] (NewCO, UserCreation) VALUES ('" + randomNo + "','" + user + "'"; ;
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

                            // Houston, we have a problem.
                        }
                        else
                        {
                            RadMessageBox.Show("CO: " + randomNo);
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
            RadForm1.LogMessage(Environment.UserName + " Started CO Creation ");
        }

        private void ultraNavigationBar1_SelectedLocationChanged(object sender, Infragistics.Win.Misc.UltraWinNavigationBar.SelectedLocationChangedEventArgs e)
        {

        }
    }
}
