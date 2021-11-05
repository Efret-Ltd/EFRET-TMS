using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EFRET_TMS
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
            this.Text = "Welcome to EFRET " + Environment.UserName;
            GetRate();
        }

        public void GetRate()
        {
            string rate = null;
            SqlConnection conn =
                new SqlConnection(
                    @"Data Source=EFRET-APP-01\EFRET;Database=axs;Integrated Security=sspi;Connection Timeout=5;");
            conn.Open();

            SqlCommand command =
                new SqlCommand(
                    "SELECT TOP 1 [ConversionRate] FROM [axs].[dbo].[ParamConversionRate] ORDER BY [ConversionDate] desc",
                    conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    rate = string.Format("{0}", reader["ConversionRate"]);
                }
            }

            conn.Close();
            accordionControlElement10.Text = "Current Rate: " + rate;
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        //Administration
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            AdminControlPanel acp = new AdminControlPanel();
            acp.Show();
        }


        //Statistics
        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }

        //Management
        private void accordionControlElement4_Click(object sender, EventArgs e)
        {

        }

        //Orders
        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.Show();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            ShowRatesPage ratesPage = new ShowRatesPage();
            ratesPage.Show();
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Focus();
        }

        private void OnRadButtonElementPress()
        {

            var radButtonElement1 = radDesktopAlert1.ButtonItems[0];

        }

        //Invoicing
        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            radDesktopAlert1.CaptionText = "<html><strong>This module is locked while in use.";
            radDesktopAlert1.Show();
        }
        //Transport Planning
        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            Tp tp = new Tp();
            tp.Show();
        }
    }
}
