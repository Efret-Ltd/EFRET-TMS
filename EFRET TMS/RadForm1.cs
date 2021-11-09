using System;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Telerik.WinControls;

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
                    rate = $"{reader["ConversionRate"]}";
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
            Statistics stats = new Statistics();
            stats.Show();
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
        //Show Rates
        private void accordionControlElement10_Click(object sender, EventArgs e)
        {

            getCurrentRate();
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Focus();
        }

        private void OnRadButtonElementPress()
        {

            Telerik.WinControls.RadItem radButtonElement1 = radDesktopAlert1.ButtonItems[0];

        }

        //Invoicing
        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            radDesktopAlert1.CaptionText = "<html><strong>This module is locked while in use.";
            radDesktopAlert1.Show();
            Invoicing invoicing = new Invoicing();
            invoicing.Show();
        }
        //Transport Planning
        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            Tp tp = new Tp();
            tp.Show();
        }

        static void getCurrentRate()
        {

            var accessKey = "cfb2e6fefbb0b44fe84b89287788f089";
            var CurrencyFrom = "EUR";
            var CurrencyTo = "GBP";
            int amount = 1;


            var url = "https://api.currencylayer.com/convert?access_key=" + accessKey + "&from=" + CurrencyFrom + "&to=" + CurrencyTo + "&amount=" + amount + "";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            String result = String.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }

            //var objects = JsonConvert.SerializeObject(new { result });
            dynamic data = JObject.Parse(result);
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(data.info.timestamp.ToString());
            DateTime dateTime = dateTimeOffset.UtcDateTime;

            var caption = "Live Rates EUR to GBP";
            var details = "This was last updated at: " + dateTime;
            RadMessageBox.Show(data.result.ToString(), caption, MessageBoxButtons.OK, details);

        }
    }
}
