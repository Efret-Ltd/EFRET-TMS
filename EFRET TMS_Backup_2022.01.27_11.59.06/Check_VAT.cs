using System;
using System.Drawing;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace EFRET_TMS
{
    public partial class CheckVat : Telerik.WinControls.UI.RadForm
    {
        public CheckVat()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //When user clicks button, we do get request to VAT check endpoint.
            // http://apilayer.net/api/validate

            if (textEdit1.Text != null)
            {
                var accessKey = "ca14f90ed6ad8d71fa92689bc6d0acb6";
                var vatNumber = textEdit1.Text;
                var url = "http://apilayer.net/api/validate?access_key=" + accessKey + "&vat_number=" + vatNumber;
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

                bool isValid = data.valid;
                var vatNum = data.vat_number;
                var companyName = data.company_name;
                var companyAddress = data.company_address;

                if (isValid)
                {
                    radLabel1.ForeColor = Color.DodgerBlue; 
                    radLabel1.Text = companyName.ToString()+@"
"+companyAddress.ToString()+ vatNum.ToString();

                }
                else
                {
                    radLabel1.ForeColor = Color.DarkRed;
                    radLabel1.Text = @"Not a valid VAT";
                }


            }

        }
    }
}
