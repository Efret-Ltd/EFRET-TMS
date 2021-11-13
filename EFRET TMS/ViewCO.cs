using DevExpress.XtraBars;
using System;
using System.Data;
using System.Data.SqlClient;
using Sentry;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class ViewCO : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private object CID;
        private string path;
        private object newChargingOrder;
        private int P44ChecklistCounter;

        public ViewCO(int COID, object newCO, object ContractID)
        {
            InitializeComponent();
            CID = ContractID + @"\";
            newChargingOrder = newCO;
            DateTime moment = new DateTime();
            path = @"\\efret-app-01\Database\efret\"+moment.Year+@"\CustomerCO\" + CID + newChargingOrder;
            getCODetails(newChargingOrder.ToString());
            getCOMovements(newChargingOrder.ToString());

            
        }

        private void getCODetails(string NewCO)
        {
            string queryString = "Select * FROM NewCO INNER JOIN Movement ON NewCO.IdCo = Movement.IdCO INNER JOIN Goods ON NewCO.IdCo = Goods.IDco WHERE NewCO ='"+ NewCO+"'";
            string connectionString = @"Server=EFRET-APP-01\EFRET;Database=axs;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    { 
                        textEdit1.Text = "Confirmation Order: "+reader["NewCO"]; 
                        textEdit2.Text = "Created By: " + reader["UserCreation"].ToString(); 
                        textEdit4.Text = "Line: " + reader["Line"].ToString();
                        textEdit3.Text = "IDCO: " + reader["IdCO"].ToString();
                        radDropDownList1.Text = "Manager: " + reader["UserOwner"].ToString();
                        radMenuHeaderItem1.Text = reader["ContractHolderEmail"].ToString();
                        radMenuHeaderItem2.Text = reader["ContractHolderTel"].ToString();
                        radMenuHeaderItem3.Text = reader["ContractHolderMob"].ToString();
                        radMenuHeaderItem4.Text =  reader["CostVATCode"].ToString();
                        labelControl1.Text = "Type: "+ reader["TrailerTypeAutorised"].ToString();
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }

        }

        private void ViewCO_Load(object sender, EventArgs e)
        {
            ribbonPageGroup7.Text = @"Project44 Checklist";
            barStaticItem1.Caption = P44ChecklistCounter + "/5 Completed";
           
        }

        private void getCOMovements(string newCO)
        {
            string queryString = "Select * FROM NewCO INNER JOIN Movement ON NewCO.IdCo = Movement.IdCO WHERE NewCO ='" + newCO + "'";
            string connectionString = @"Server=EFRET-APP-01\EFRET;Database=axs;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                DataSet sourceDataSet = new DataSet();
                try
                {
                    using (var da = new SqlDataAdapter(queryString, connectionString))
                    {
                        da.Fill(sourceDataSet);
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

        private void P44Check(int P44ChecklistCounter, ItemClickEventArgs e)
        {
            //This is highly redundant. We are going to do simple checks against the table and tally up the ones that have valid data.
            if (barCheckItem1.Checked)
            {
                P44ChecklistCounter++;
            }
            else
            {
                P44ChecklistCounter--;
            }
            if (barCheckItem2.Checked)
            {
                P44ChecklistCounter++;
            }
            else
            {
                P44ChecklistCounter--;
            }
            if (barCheckItem3.Checked)
            {
                P44ChecklistCounter++;
            }
            else
            {
                P44ChecklistCounter--;
            }
            if (barCheckItem4.Checked)
            {
                P44ChecklistCounter++;
            }
            else
            {
                P44ChecklistCounter--;
            }
            if (barCheckItem5.Checked)
            {
                P44ChecklistCounter++;
            }
            else
            {
                P44ChecklistCounter--;
            }
            barStaticItem1.Refresh();
            this.Refresh();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraOpenFileDialog1.InitialDirectory = path;
            xtraOpenFileDialog1.Title = "View Charging Order Browser";
            xtraOpenFileDialog1.FileName = "";
            xtraOpenFileDialog1.ShowDialog();
        }

        private void barCheckItem2_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            P44Check(P44ChecklistCounter,e);
        }

        private void barCheckItem5_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            P44Check(P44ChecklistCounter, e);
        }

        private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            P44Check(P44ChecklistCounter, e);
        }

        private void barCheckItem3_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            P44Check(P44ChecklistCounter, e);
        }

        private void barCheckItem4_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            P44Check(P44ChecklistCounter, e);
           
        }

        //View Costs
        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewCOCost viewCoCost = new ViewCOCost();
            viewCoCost.Show();
            RadForm1.LogMessage(Environment.UserName+" Has opened view costs panel");
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}