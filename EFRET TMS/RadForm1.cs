using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Threading;
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
            // ReSharper disable once VirtualMemberCallInConstructor
            Text = @"Welcome to EFRET " + Environment.UserName;
            GetRate();
            PostTeamsLogin();
            Connect("192.168.10.78", Environment.MachineName);

        }

        static void Connect(String server, String message)
        {
            try
            {
                Int32 port = 13000;
                TcpClient client = new TcpClient(server, port);

                NetworkStream stream = client.GetStream();

                int count = 0;
                while (count++ < 1)
                {
                    // Translate the Message into ASCII.
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                    // Send the message to the connected TcpServer. 
                    stream.Write(data, 0, data.Length);
                    RadMessageBox.Show("Connecting", message);

                    // Bytes Array to receive Server Response.
                    data = new Byte[256];
                    String response = String.Empty;

                    // Read the Tcp Server Response Bytes.
                    Int32 bytes = stream.Read(data, 0, data.Length);
                    response = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    RadMessageBox.Show("Recieved", response);

                    Thread.Sleep(2000);
                }

                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                RadMessageBox.Show("Exception: {0}", e.Message);
            }
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
            accordionControlElement10.Text = @"Current Rate: " + rate;
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            var eventMessage = Environment.UserName + " Shutdown the TMS";
            LogMessage(eventMessage);
            Close();
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
         
            Movements Movement = new Movements();
            Movement.Show();
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
            radDesktopAlert1.CaptionText = "<html><strong>This module is locked while in use.</html>";
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
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            String result = String.Empty;
            
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                if (dataStream != null)
                {
                    StreamReader reader = new StreamReader(dataStream);
                    result = reader.ReadToEnd();
                    reader.Close();
                }

                if (dataStream != null) dataStream.Close();
            }

            dynamic data = JObject.Parse(result);
            int time = data.info.timestamp;
            DateTimeOffset dateTimeOffSet = DateTimeOffset.FromUnixTimeSeconds(time);
            DateTime dateTime = dateTimeOffSet.DateTime;
            var caption = "Hourly Rates GBP to EUR";
            var details = "This was last updated at: " + dateTime;
            RadMessageBox.Show(data.result.ToString(), caption, MessageBoxButtons.OK, details);

        }
        //Tools and Utilities Menu.
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
            Process LiveMap = new Process();
            LiveMap.StartInfo.FileName = "P44OverviewMap.exe";
            LiveMap.StartInfo.WorkingDirectory = @"\\efret-dev-01\Users\sysadmin\Source\Repos\P44OverviewMap\P44OverviewMap\bin\DebugVersion";
            LiveMap.Start();
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

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            ABRouting abRouting = new ABRouting();
            Debug.Assert(abRouting != null, nameof(abRouting) + " != null");
            using (abRouting)
            {
                abRouting.Show();
            }
        }

        // Trailer Damage
        private void accordionControlElement16_Click(object sender, EventArgs e)
        {
            TrailerHistory th = new TrailerHistory();
                th.Show();
                var eventMessage = Environment.UserName + " Opened Trailer History Panel";
                LogMessage(eventMessage);
        }

        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            TasksBoard TB = new TasksBoard();
          TB.Show();
            

            var eventMessage = Environment.UserName + " Opened Tasks Board Panel";
            LogMessage(eventMessage);
        }
    }
}
