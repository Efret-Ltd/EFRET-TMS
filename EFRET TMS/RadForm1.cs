using System;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using Newtonsoft.Json.Linq;
using Sentry;
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
            PostTeamsLogin();
            
        }

        public async void PostTeamsLogin()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://efret.webhook.office.com/webhookb2/35489fe2-948e-4379-8e68-87d79974aee6@ec714a2e-c5d4-46ae-b1ba-36a361a2e00b/IncomingWebhook/780e1042788b4503b968583fad62f00c/a55b8555-1a18-4fcd-9e1a-6382eeb92c5e"))
                {

                    string postContent = "{'text':'" + Environment.UserName + " logged into the TMS'}";
                    request.Content = new StringContent(postContent);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        public static async void LogMessage(string message)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"),
                        "https://efret.webhook.office.com/webhookb2/35489fe2-948e-4379-8e68-87d79974aee6@ec714a2e-c5d4-46ae-b1ba-36a361a2e00b/IncomingWebhook/780e1042788b4503b968583fad62f00c/a55b8555-1a18-4fcd-9e1a-6382eeb92c5e"))
                    {

                        string postContent = "{'text':'" + message + "'}";
                        request.Content = new StringContent(postContent);
                        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                        var response = await httpClient.SendAsync(request);
                    }
                }
            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex);
            }

            SentrySdk.CaptureMessage(message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm(false); // false means that an exception will not be thrown
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
            var eventMessage = Environment.UserName + " Shutdown the TMS";
            LogMessage(eventMessage);
            this.Close();
            Application.Exit();
        }

        //Administration
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            AdminControlPanel acp = new AdminControlPanel();
            acp.Show();
            var eventMessage = Environment.UserName + " Opened Admin Control Panel";
            LogMessage(eventMessage);
        }


        //Statistics
        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            Statistics stats = new Statistics();
            stats.Show();
            var eventMessage = Environment.UserName + " Opened Statistics Panel";
            LogMessage(eventMessage);
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
            var eventMessage = Environment.UserName + " Opened Orders Panel";
            LogMessage(eventMessage);
        }
        //Show Rates
        private void accordionControlElement10_Click(object sender, EventArgs e)
        {

            GetCurrentRate();
        }

        //Invoicing
        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            radDesktopAlert1.CaptionText = "<html><strong>This module is locked while in use.";
            radDesktopAlert1.Show();
            Invoicing invoicing = new Invoicing();
            invoicing.Show();
            var eventMessage = Environment.UserName + " Opened Invoicing Panel";
            LogMessage(eventMessage);
        }
        //Transport Planning
        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            Tp tp = new Tp();
            tp.Show();
            var eventMessage = Environment.UserName + " Opened Transport Planning Panel";
            LogMessage(eventMessage);
        }

        private static void GetCurrentRate()
        {

            var accessKey = "cfb2e6fefbb0b44fe84b89287788f089";
            var currencyFrom = "GBP";
            var currencyTo = "EUR";
            int amount = 1;


            var url = "https://api.currencylayer.com/convert?access_key=" + accessKey + "&from=" + currencyFrom + "&to=" + currencyTo + "&amount=" + amount + "";
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

            dynamic data = JObject.Parse(result);
            int time = data.info.timestamp;
            DateTimeOffset dateTimeOffSet = DateTimeOffset.FromUnixTimeSeconds(time);
            DateTime dateTime = dateTimeOffSet.DateTime;
            var caption = "Hourly Rates GBP to EUR";
            var details = "This was last updated at: " + dateTime;
            RadMessageBox.Show(data.result.ToString(), caption, MessageBoxButtons.OK, details);

        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            ToolsUtiltiesMenu tuMenu = new ToolsUtiltiesMenu();
            tuMenu.Show();
            var eventMessage = Environment.UserName + " Opened Tools and Utilities Panel";
            LogMessage(eventMessage);
        }
        //Fleet Management
        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            FleetManagement fMngt = new FleetManagement();
            fMngt.Show();
            var eventMessage = Environment.UserName + " Opened Fleet Management Panel";
            LogMessage(eventMessage);
        }
        //Mail Merge
        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            MailMerge mm = new MailMerge();
            mm.Show();
            var eventMessage = Environment.UserName + " Opened MailMerge Panel";
            LogMessage(eventMessage);
        }
    }
}
