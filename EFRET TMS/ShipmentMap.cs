using Newtonsoft.Json.Linq;
using RestSharp;
using Sentry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;


namespace EFRET_TMS
{
    public sealed partial class ShipmentMap : Telerik.WinControls.UI.RadRibbonForm
    {
        public ShipmentMap(int coid, string latitude, string longitude)
        {
        InitializeComponent();
         radRibbonBar2.Expanded = false;
          Text = @"Shipment tracking for: " + coid;
          GetMapFromCoords(latitude, longitude);
          GetStreetName(latitude, longitude);
        }

        public void GetMapFromCoords(string latitude, string longitude)
        {

            string coords = latitude + "," + longitude;
            int pictureWidth = 1024;
            int pictureHeight = 1024;
            int zoom = 17;


            HttpWebRequest mapRequest = (HttpWebRequest)WebRequest.Create(
                "https://image.maps.ls.hereapi.com/mia/1.6/mapview?c=" + coords +
                "&z=" + zoom + "&apiKey=JdeLHTyZLIIKCjldtL0VTEMuXvaGIzkVdIFvLx8yD84&w=" + pictureWidth + "&h=" + pictureHeight + "");
            try
            {
                // returned values are returned as a stream, then read into a string
                using (HttpWebResponse mapResponse = (HttpWebResponse)mapRequest.GetResponse())
                {
                    if (mapResponse != null)
                        using (BinaryReader reader = new BinaryReader(mapResponse.GetResponseStream()))
                        {
                            byte[] lnByte = reader.ReadBytes(1 * 2048 * 2048 * 10);
                            using (MemoryStream ms = new MemoryStream(lnByte))
                            {
                                radPictureBox1.Image = Image.FromStream(ms);
                                ms.Close();
                            }

                            reader.Close();
                            reader.Dispose();
                        }
                }
            }
            catch (Exception ex)
            {

                SentrySdk.CaptureException(ex);
            }
        }
        
        public void GetStreetName(string latitude, string longitude)
        {

            try
            {
                var client = new RestClient("https://api.myptv.com/geocoding/v1/locations/by-position/" + latitude +
                                            "/" + longitude + "?language=en");
                var request = new RestRequest(Method.GET);
                request.AddHeader("apiKey",
                    "MjBhYTg3MjRlMWZlNDk2OTk0NzZhMWIzMTU3Zjg1ZWY6ZTMxZTVjMGMtM2I0My00ODAwLThmOWYtNjY5ODk4OWRlMWJm");

                //Response is a JSON object string.
                IRestResponse<Loc> response = client.Execute<Loc>(request);
                JObject json = JObject.Parse(response.Content);
                var address = json["locations"][0];
                var formattedAddress = address["formattedAddress"];
                barStaticItem1.Caption = formattedAddress.ToString();

                /*
                 * dynamic data = JObject.Parse(result);
                    dynamic address = data.items;
                 */
            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex);

            }

        }
        public class ReferencePosition
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }

        public class Address
        {
            public string CountryName { get; set; }
            public string State { get; set; }
            public string Province { get; set; }
            public string PostalCode { get; set; }
            public string City { get; set; }
            public string District { get; set; }
            public string Subdistrict { get; set; }
            public string Street { get; set; }
            public string HouseNumber { get; set; }
        }

        public class Loc
        {
            public ReferencePosition ReferencePosition { get; set; }
            public Address Address { get; set; }
            public string FormattedAddress { get; set; }
            /*
            public Quality Quality { get; set; }
*/
        }

        public class Root
        {
/*
            public List<Loc> Locations { get; set; }
*/
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Hide();
            Dispose();
        }

        private void ribbonTab1_Click(object sender, EventArgs e)
        {

        }

        private void radRibbonBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
