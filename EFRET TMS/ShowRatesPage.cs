using System;
using System.IO;
using System.Net;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EFRET_TMS
{
    public partial class ShowRatesPage : XtraForm
    {
        public ShowRatesPage()
        {
            InitializeComponent();
            var url = "https://api.exchangerate.host/convert?from=GBP&to=EUR";
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

            var objects = JsonConvert.SerializeObject(new { result });
            this.simpleLabelItem1.Text = objects;


        }


    }
}
