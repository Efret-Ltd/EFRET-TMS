using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using Sentry;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class FixRateOfExchange : UserControl
    {
        private readonly DataGridView dataGridView1 = new DataGridView();
        private readonly BindingSource bindingSource1 = new BindingSource();
        private DateTime dateFrom;
        private DateTime dateTo;
        private string rate;
        public FixRateOfExchange()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            string queryString = "SELECT * FROM [axs].[dbo].[NewCO] WHERE DateCreation BETWEEN '" + dateFrom + "' AND '" + dateTo + "' AND '" + rate + "'";
            string connectionString = @"Server=EFRET-APP-01\EFRET;Database=axs;Trusted_Connection=True;";


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    DataSet ds = new DataSet();

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    try
                    {
                        while (reader.Read())
                        {
                            DataTable table = new DataTable
                            {
                                Locale = CultureInfo.InvariantCulture
                            };
                            adapter.Fill(ds);

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

        private void radDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateFrom = radDateTimePicker1.Value;
            dateFromToolStripLabel1.Text = dateFrom.ToString();
        }

        private void radDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTo = radDateTimePicker2.Value;
            dateToToolStripLabel1.Text = dateTo.ToString();
        }

        private void rangeSelectionToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.newCOTableAdapter.RangeSelection(this.cOInstance.NewCO, dateFromToolStripTextBox1.Text, dateToToolStripTextBox1.Text, textEdit2.Text);
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message);
            }

        }
    }
}
