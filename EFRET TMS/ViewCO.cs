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
        private  string _path;
        private  object _newChargingOrder;
        private  string _shipmentId;
        private int _contractualdateSet;
        private int _tractorNumber;
        private int _costProvider;
        private int _trailerNumber;
        private double conversionRate;
        private Boolean invoiced;
        private Boolean trackingStarted;
        private int _isTrailerTypeAutorised;
        private object _coComment;
        private string _cmrPath;
        private string contractId;
        private string _p44long;
        private string _p44lat;
        public ViewCo(int coid)
        {
            /* -We need to grab all the key fields from the CO
             *  We then show UI components based if the field has data.
             *  Do not need more than a single query to populate local fields. Except for CMR using a different DB
             */
            InitializeComponent();
            _chargingOrderId = coid;
            GetNewCO(_chargingOrderId);
            GetCoDetails(_chargingOrderId);
            GetCoMovements(_newChargingOrder.ToString());
            GetCocmr(_chargingOrderId);
            GetCOTally();
        }
        public void GetNewCO(int coid) {
            string queryString = "Select NewCO,Comment,IdContractHolder,DateCreation FROM NewCO WHERE IdCO ='" + coid + "'";
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
                            _newChargingOrder = reader["NewCO"];
                            DateTime COCreationDate = DateTime.Parse(reader["DateCreation"].ToString());
                            _coComment = reader["Comment"].ToString();
                            contractId = reader["IdContractHolder"].ToString();
                            _cmrPath = @"https://cmr.efret.net/retrieve/cmr/" + contractId + "-" + _newChargingOrder + "-CMR.pdf";
                            _path = @"\\efret-app-01\Database\efret\"+COCreationDate.ToString("yyyy")+@"\CustomerCO\" + contractId +@"\"+ _newChargingOrder;
                            //TODO: ServiceStack DTO make a charging Order and initalize instance.
                            barEditItem1.EditValue = _newChargingOrder;
                            barStaticItem2.Caption = reader["IdCO"].ToString();
                            barEditItem2.EditValue = reader["Line"];
                            barEditItem4.EditValue = reader["ConversionRate"];
                            barStaticItem3.Caption = @"Created By: " + reader["UserCreation"];
                            barStaticItem4.Caption = @"Last Change By: " + reader["UserUpdate"];
                            barStaticItem5.Caption = @"Manager: " + reader["UserOwner"];
                            _p44lat = reader["P44Latitude"].ToString();
                            _p44long = reader["P44Longitude"].ToString();
                            barEditItem5.EditValue = reader["TrailerTypeAutorised"];
                            _shipmentId = reader["P44ShipmentID"].ToString();
                        }

                    }
                    catch (Exception ex)
                    {
                        SentrySdk.CaptureException(ex);

                    }
                    RadMessageBox.Show(_path);
                }
            }catch (Exception ex)
            {
                SentrySdk.CaptureException(ex);

            }
            
        }
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


        private void GetCoDetails(int idCO)
        {
            string queryString = "Select * FROM NewCO INNER JOIN Movement ON NewCO.IdCo = Movement.IdCO INNER JOIN Goods ON NewCO.IdCo = Goods.IDco WHERE IdCO ='" + idCO+ "'";
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

                            if (reader["TrailerNumber"] != null)
                            {
                                barCheckItem1.Checked = true;
                                //TODO: It seems that this gets called in a loop of each check. This needs to be invoked once so better structure will be needed.
                                bool EfretTrailer = reader["TrailerNumber"].ToString().StartsWith("EFRU");
                                //We add value so P44 Checklist tallies
                                if (EfretTrailer)
                                {
                                    //RadMessageBox.Show("Efret trailer assigned. Not eligible for P44 Tracking.");
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
                        SqlDataReader reader = command.ExecuteReader();
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
            xtraOpenFileDialog1.Title = @"Charging Order Browser";
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
            //Run program with Charging order in argument
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

        //Email COz
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