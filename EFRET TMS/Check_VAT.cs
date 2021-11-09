using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class Check_VAT : Telerik.WinControls.UI.RadForm
    {
        public Check_VAT()
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
                var vat_number = textEdit1.Text;
                var url = "http://apilayer.net/api/validate?access_key=" + accessKey + "&vat_number=" + vat_number;
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

                bool isValid = data.valid;
                var countryCode = data.country_code;
                var VATNumber = data.vat_number;
                var companyName = data.company_name;
                var companyAddress = data.company_address;

                if (isValid)
                {
                    radLabel1.ForeColor = Color.DodgerBlue; 
                    radLabel1.Text = companyName.ToString()+"\n"+companyAddress.ToString();

                }
                else
                {
                    radLabel1.ForeColor = Color.DarkRed;
                    radLabel1.Text = "Not a valid VAT";
                }


            }

        }
    }
}
