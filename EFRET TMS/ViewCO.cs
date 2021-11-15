using DevExpress.XtraBars;
using System;
using System.Data;
using System.Data.CData.MariaDB;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Headers;
using DevExpress.CodeParser;
using Sentry;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class ViewCO : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int chargingOrderID; 
        private object CID;
        private string path;
        private object newChargingOrder;
        private string ShipmentID;
        int ContractualdateSet = 0;
        int TractorNumber = 0;
        int CostProvider = 0;
        private int TrailerNumber = 0;
        private int isTrailerTypeAutorised = 0;
        private string COComment;
        public ViewCO(int COID, object newCO, object ContractID)
        {
            InitializeComponent();
            CID = ContractID + @"\";
            chargingOrderID = COID;
            newChargingOrder = newCO;
            path = @"\\efret-app-01\Database\efret\2021\CustomerCO\" + CID + newChargingOrder;
            getCODetails(newChargingOrder.ToString());
            getCOMovements(newChargingOrder.ToString());
            getCOCMR(chargingOrderID);

        }

        private void getCOCMR(int chargingOrderID)
        {
            string queryString = "Select * FROM CMRStatus WHERE IdCO ='" + chargingOrderID + "'";

            using (MariaDBConnection connection =
                new MariaDBConnection(
                    "User=efretdb;Password=^eA7yQfqqpaO;Database=EFRETCMR;Server=192.168.10.70;Port=3306;"))
            {
                MariaDBCommand command = new MariaDBCommand(queryString, connection);
                connection.Open();
                MariaDBDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        //We do a hit check then enable button
                        if (reader["cStatus"].ToString() == "WAITING")
                        {
                            RadMessageBox.Show("CMR WAITING FOR: " + reader["IdCO"]);
                        }

                        if (reader["cStatus"].ToString() == "ACCEPTED")
                        {//TODO: Link to CMR PDF for viewing.
                            RadMessageBox.Show("CMR ACCEPTED for: " + reader["IdCO"]);
                            barButtonItem10.Enabled = true;

                        }

                        if (reader["cStatus"].ToString() == "REVIEW")
                        {
                            RadMessageBox.Show("CMR IN REVIEW FOR: " + reader["IdCO"]);
                        }

                    }

                }
                catch (Exception ex)
                {
                    SentrySdk.CaptureException(ex);

                }
            }
        }


        private void getCODetails(string NewCO)
        {
            string queryString = "Select * FROM NewCO INNER JOIN Movement ON NewCO.IdCo = Movement.IdCO INNER JOIN Goods ON NewCO.IdCo = Goods.IDco WHERE NewCO ='"+ NewCO+"'";
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
                            textEdit1.Text = "Confirmation Order: " + reader["NewCO"];
                            radLabel5.Text = "Created By: " + reader["UserCreation"];
                            radLabel3.Text = "Line: " + reader["Line"];
                            radLabel1.Text = "Rate € to £: "+ reader["ConversionRate"];
                            radLabel2.Text = "Last Change By: "+ reader["UserUpdate"];
                            radLabel4.Text = "IDCO: " + reader["IdCO"];
                            radDropDownList1.Text = "Manager: " + reader["UserOwner"];
                            radMenuHeaderItem1.Text = reader["ContractHolderEmail"].ToString();
                            radMenuHeaderItem2.Text = reader["ContractHolderTel"].ToString();
                            radMenuHeaderItem3.Text = reader["ContractHolderMob"].ToString();
                            radMenuHeaderItem4.Text = reader["CostVATCode"].ToString();
                            labelControl1.Text = "Type: " + reader["TrailerTypeAutorised"];
                            if (reader["P44ShipmentID"].ToString() != "")
                            {
                                ShipmentID = reader["P44ShipmentID"].ToString();
                            }

                            if (reader["TrailerNumber"].ToString() != "")
                            {
                                barCheckItem1.Checked = true;
                                TrailerNumber = 1;
                            }
                            if (reader["TrailerTypeAutorised"].ToString() != "")
                            {
                                barCheckItem4.Checked = true;
                                isTrailerTypeAutorised = 1;
                            }
                            if (reader["Comment"].ToString() != "")
                            {
                                COComment = reader["Comment"].ToString();
                                simpleButton1.Visible = true;
                            }
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

        private void ViewCO_Load(object sender, EventArgs e)
        {
            ribbonPageGroup7.Text = @"Project44 Checklist";
            

            int done =  ContractualdateSet + TractorNumber + CostProvider + TrailerNumber+ isTrailerTypeAutorised;
            barStaticItem1.Caption = done + "/5 Completed";
            if (done == 5 & ShipmentID ==null)
            {
                barStaticItem1.Caption = "Checklist Complete";
                barButtonItem13.Visibility = BarItemVisibility.Always;

            }
            if (ShipmentID != null)
            {
                barStaticItem1.Caption = ShipmentID;
            }

        }

        private void getCOMovements(string newCO)
        {

            string queryStringAllMovements = "Select * FROM NewCO INNER JOIN Movement ON NewCO.IdCo = Movement.IdCO WHERE NewCO ='" + newCO + "'";
            string connectionString = @"Server=EFRET-APP-01\EFRET;Database=axs;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryStringAllMovements, connection);
                connection.Open();
                DataSet sourceDataSet = new DataSet();
                try
                {
                    using (var da = new SqlDataAdapter(queryStringAllMovements, connectionString))
                    {
                        da.Fill(sourceDataSet);
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            if (reader["Contractualdate"] != null)
                            {
                                barCheckItem2.Checked = true;
                                ContractualdateSet = 1;
                            }
                            if (reader["TractorNumber"] != null)
                            {
                                barCheckItem5.Checked = true;
                                TractorNumber = 1;
                            }
                            if (reader["CostProvider"] != null)
                            {
                                barCheckItem3.Checked = true;
                                CostProvider = 1;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        SentrySdk.CaptureException(ex);

                    }
                

                    gridControl1.DataSource = sourceDataSet.Tables[0]; 
                    connection.Close();
                }
                catch (Exception ex)
                {
                    SentrySdk.CaptureException(ex);

                }
            }
        }


        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            //TODO: We may want to use devexpress PDF utilities on selection.
            xtraOpenFileDialog1.InitialDirectory = path;
            xtraOpenFileDialog1.Title = "View Charging Order Browser";
            xtraOpenFileDialog1.FileName = "";
            xtraOpenFileDialog1.ShowDialog();
        }

        private void barCheckItem2_CheckedChanged(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barCheckItem5_CheckedChanged(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
         
        }

        private void barCheckItem3_CheckedChanged(object sender, ItemClickEventArgs e)
        {
         
        }

        private void barCheckItem4_CheckedChanged(object sender, ItemClickEventArgs e)
        {
           
           
        }

        //View Costs
        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            COCost viewCoCost = new COCost(newChargingOrder.ToString());
            viewCoCost.Show();
            RadForm1.LogMessage(Environment.UserName+" has opened view costs panel for CO: "+ chargingOrderID);
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        //Button to Upload to P44
        private async void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            RadForm1.LogMessage(Environment.UserName + " has attempted to upload CO: " + chargingOrderID+" to Project44");
            var username = "integrationuser@efret.net";
            var password = "project442019!";


            // do not upload CO's that have an idContractHolder of 'EFRCHR' or 'EF1CHR' - These are internal shipments that dont need to be tracked
            // remove CO's that have any movement with a CostProvider of '4SALE2' or 'EFRCHR' or 'EF1CHR'
            var messageP44 = "";

            //While the button isn't shown until all fields are properly filled. We do a final check to ensure the data we post is valid.

            // remove CO's with no trailer number

            // remove CO's with invalid Efret trailer number EFRU

            // Remove CO's with trailerType not currently compatiable with Project 44
            /*
             * case 'B737CARGO AIRCRAFT 23 T':
                            console.log('IdCO:', confirmationOrders[loop].idCo, 'Confirmation Order:', confirmationOrders[loop].confirmationOrder, 'Contract:', confirmationOrders[loop].idContractHolder, 'Trailer Number:', confirmationOrders[loop].trailerNumber, 'Trailer Type:', confirmationOrders[loop].trailerType);    
                            console.log(' - CO has a Project 44 unsupported trailer type of B737Cargo Aircraft 23 t. Unflagged this CO for upload to Project 44');
                            updateDatabaseRecord('UPDATE NewCO SET P44ToUpload=0, P44ReasonCode=\'NO_NEED_TO_UPLOAD\', P44ReasonDescription=\'CO has a Project 44 unsupported trailer type of 737Cargo Aircraft 23 t. Unflagged this CO for upload to Project 44\', P44UploadError=-1, P44LastUpdate='+getDateTimeAccess()+' WHERE IdCO='+confirmationOrdersToUpload[loop].idCo, 'CO', confirmationOrdersToUpload[loop].idCo);
                            confirmationOrdersToUpload.splice(loop, 1);
                            break;
             */
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"),
                        "http://cloud-v2.p-44.com/api/v4/tl/shipments"))
                    {
                        request.Headers.Authorization =
                            new AuthenticationHeaderValue(
                                "Basic", Convert.ToBase64String(
                                    System.Text.ASCIIEncoding.ASCII.GetBytes(
                                        $"{username}:{password}")));


                        string postContent = "{'text':'" + messageP44 + "'}";
                        request.Content = new StringContent(postContent);


                        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                        var response = await httpClient.SendAsync(request);
                        RadMessageBox.Show(response.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex);
            }
            //Now we do a bunch of checks before posting to P44.
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            RadMessageBox.Show(COComment);
        }
    }
}