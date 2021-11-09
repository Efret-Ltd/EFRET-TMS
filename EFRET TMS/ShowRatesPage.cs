using System;
using System.IO;
using System.Net;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class ShowRatesPage : XtraForm
    {
        public ShowRatesPage()
        {
            InitializeComponent();
            
            getCurrentRate();


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
            var caption = "Live Rates EUR to GBP";
            var details = "This was last updated at: "+data.info.timestamp.ToString();
            RadMessageBox.Show(data.result.ToString(), caption, MessageBoxButtons.OK, details);

        }

    }
}
