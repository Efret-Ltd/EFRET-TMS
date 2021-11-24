using DevExpress.XtraBars;
using System;
using System.Data;
using System.Data.CData.MariaDB;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using Sentry;
using Telerik.WinControls;
using System.Windows.Forms;

namespace EFRET_TMS
{
    public partial class ViewCo : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly int _chargingOrderId;
        private readonly string _path;
        private readonly object _newChargingOrder;
        private  string _shipmentId;
        private int _contractualdateSet;
        private int _tractorNumber;
        private int _costProvider;
        private int _trailerNumber;
        private int _isTrailerTypeAutorised;
        private object _coComment;
        private string _cmrPath;
        private string _p44long;
        private string _p44lat;
        public ViewCo(int coid, object newCo, object contractId, object comment)
        {
            InitializeComponent();
            object cid = contractId + @"\";
            _chargingOrderId = coid;
            _newChargingOrder = newCo;
            _coComment = comment;
            _path = @"\\efret-app-01\Database\efret\2021\CustomerCO\" + cid + _newChargingOrder;
            _cmrPath = @"https://cmr.efret.net/retrieve/cmr/" + contractId + "-" + newCo + "-CMR.pdf";
            GetCoDetails(_newChargingOrder.ToString());
            GetCoMovements(_newChargingOrder.ToString());
            GetCocmr(_chargingOrderId);
            GetCOTally();
        }
        /*
         * We select the record from CMR database then do comparisons on the status of the CMR.
         * IF the CMR is accepted we provide a button and a link to the PDF.
         *
         */
        private void GetCOTally()
        {

            ribbonPageGroup7.Text = @"Project44 Checklist";

            //We tally up and show outstanding.
            int done = _contractualdateSet + _tractorNumber + _costProvider + _trailerNumber + _isTrailerTypeAutorised;
            barStaticItem1.Caption = done + @"/5 Completed";

            if (done == 5 & _shipmentId == null)
            {
                barStaticItem1.Caption = @"Checklist Complete";
                barButtonItem13.Visibility = BarItemVisibility.Always;

            }
            if (_shipmentId != null)
            {
                barStaticItem1.Caption = _shipmentId;
                barButtonItem14.Visibility = BarItemVisibility.Always;
            }
        }
        private void GetCocmr(int chargingOrderId)
        {
            // We use the query for the CMR.
            string queryString = "Select * FROM CMRStatus WHERE IdCO ='" + chargingOrderId + "'";
            try
            {
                using (MariaDBConnection connection =
                    new MariaDBConnection(
                        "User=efretdb;Password=^eA7yQfqqpaO;Database=EFRETCMR;Server=192.168.10.70;Port=3306;"))
                {
                    MariaDBCommand command = new MariaDBCommand(queryString, connection);
                    connection.Open();
                    MariaDBDataReader reader = command.ExecuteReader();
                    /*
                     * A CMR has four states: Waiting, resend, Review and Accepted.
                     * Show button to view CMR on accepted.
                     */
                    while (reader.Read())
                    {
                        //We do a hit check then enable button
                        if (reader["cStatus"].ToString() == "WAITING")
                        {
                            RadMessageBox.Show("CMR WAITING FOR: " + reader["IdCO"]);
                        }

                        if (reader["cStatus"].ToString() == "RESEND")
                        {
                            RadMessageBox.Show("CMR RESEND FOR: " + reader["IdCO"]);
                        }

                        if (reader["cStatus"].ToString() == "REVIEW")
                        {
                            RadMessageBox.Show("CMR IN REVIEW FOR: " + reader["IdCO"]);
                        }

                        if (reader["cStatus"].ToString() == "ACCEPTED")
                        {
                            //TODO: Link to CMR PDF for viewing.
                            RadMessageBox.Show("CMR ACCEPTED for: " + reader["IdCO"]);
                            barButtonItem10.Enabled = true;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex);

            }
        }


        private void GetCoDetails(string newCo)
        {
            string queryString = "Select * FROM NewCO INNER JOIN Movement ON NewCO.IdCo = Movement.IdCO INNER JOIN Goods ON NewCO.IdCo = Goods.IDco WHERE NewCO ='"+ newCo+"'";
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

                            //TODO: ServiceStack DTO make a charging Order and initalize instance.
                            barEditItem1.EditValue = reader["NewCO"];
                            barStaticItem2.Caption = reader["IdCO"].ToString();
                            barEditItem2.EditValue = reader["Line"];
                            barEditItem4.EditValue = reader["ConversionRate"];
                            barStaticItem3.Caption = @"Created By: " + reader["UserCreation"];
                            barStaticItem4.Caption = @"Last Change By: "+ reader["UserUpdate"];
                            barStaticItem5.Caption = @"Manager: " + reader["UserOwner"];
                            _p44lat = reader["P44Latitude"].ToString();
                            _p44long = reader["P44Longitude"].ToString();
                            barEditItem5.EditValue = reader["TrailerTypeAutorised"];

                            if (reader["P44ShipmentID"].ToString() != "")
                            {
                                _shipmentId = reader["P44ShipmentID"].ToString();
                            }

                            if (reader["TrailerNumber"] != null)
                            {
                                barCheckItem1.Checked = true;
                                bool EfretTrailer = reader["TrailerNumber"].ToString().StartsWith("EFRU");
                                //We add value so P44 Checklist tallies
                                if (EfretTrailer)
                                {
                                    RadMessageBox.Show("Efret trailer assigned. Not eligible for P44 Tracking.");
                                    barToggleSwitchItem1.Checked = true;
                                }
                                _trailerNumber = 1;
                            }
                            if (reader["TrailerTypeAutorised"] != null)
                            {
                                barCheckItem4.Checked = true;
                                //We add value so P44 Checklist tallies
                                _isTrailerTypeAutorised = 1;
                            }
 
                            _coComment = reader["Comment"].ToString();
          
                           
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
            

        }

        private void GetCoMovements(string newCo)
        {

            string queryStringAllMovements = "Select * FROM NewCO INNER JOIN Movement ON NewCO.IdCo = Movement.IdCO WHERE NewCO ='" + newCo + "'";
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
                                _contractualdateSet = 1;
                            }
                            if (reader["TractorNumber"] != null)
                            {
                                barCheckItem5.Checked = true;
                                _tractorNumber = 1;
                            }
                            if (reader["CostProvider"] != null)
                            {
                                barCheckItem3.Checked = true;
                                _costProvider = 1;
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
            xtraOpenFileDialog1.InitialDirectory = _path;
            xtraOpenFileDialog1.Title = @"View Charging Order Browser";
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
            CoCost viewCoCost = new CoCost(_newChargingOrder.ToString());
            viewCoCost.Show();
            RadForm1.LogMessage(Environment.UserName+" has opened view costs panel for CO: "+ _chargingOrderId);
        }

        //Button to Upload to P44
        private async void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            RadForm1.LogMessage(Environment.UserName + " has attempted to upload CO: " + _chargingOrderId+" to Project44");
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
                                    System.Text.Encoding.ASCII.GetBytes(
                                        $"{username}:{password}")));


                        string postContent = "{'text':'" + messageP44 + "'}";
                        request.Content = new StringContent(postContent);


                        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");


                        if (request.Content.Headers.Allow.Contains(""))
                        {

                            //once the request is recived with a 200 response we then run the utilities and parse the resulting data.


                         
                        }
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


        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            // We View the CMR from the portal.
            // e.g https://cmr.efret.net/retrieve/cmr/AMALOG-116HK179Y-CMR.pdf
            //TODO: download PDF locally, use own PDF libs to manipulate the file.
            Process.Start(_cmrPath);
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_p44lat != "0" || _p44long != "0")
            {
                ShipmentMap sMap = new ShipmentMap(_chargingOrderId, _p44lat.ToString(), _p44long.ToString());
                /*
             * TODO: Add more user controls on shipment map. Allow the user to control the zoom level. Refresh data.
             */
                sMap.Show();

            }
        }

        //Email CO
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialogResult = RadMessageBox.Show("Sure", "Send Confirmation Report to Carrier", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            RadMessageBox.Show(_coComment.ToString());
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            RadMessageBox.Show("This CO is Active");
        }
    }
}