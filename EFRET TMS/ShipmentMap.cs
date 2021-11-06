using RestSharp;
using Sentry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.Json;

namespace EFRET_TMS
{
    public partial class ShipmentMap : Telerik.WinControls.UI.RadRibbonForm
    {
        public ShipmentMap(string latitude, string longitude)
        {
            var coords = latitude + "," + longitude;
            InitializeComponent();
            HttpWebRequest mapRequest = (HttpWebRequest)WebRequest.Create("https://image.maps.ls.hereapi.com/mia/1.6/mapview?c=" + coords + "&z=15&apiKey=JdeLHTyZLIIKCjldtL0VTEMuXvaGIzkVdIFvLx8yD84&i&w=1024&h=1024");

            // returned values are returned as a stream, then read into a string
            using (HttpWebResponse mapResponse = (HttpWebResponse)mapRequest.GetResponse())
            {
                using (BinaryReader reader = new BinaryReader(mapResponse.GetResponseStream()))
                {
                    Byte[] lnByte = reader.ReadBytes(1 * 2048 * 2048 * 10);
                    using (FileStream lxFs = new FileStream(@"map.jpg", FileMode.Create))
                    {
                        lxFs.Write(lnByte, 0, lnByte.Length);

                        lxFs.Close();
                        lxFs.Dispose();
                    }
                    reader.Close();
                    reader.Dispose();
                }

            }


            //Can we load the map with modular design in mind so we can just put the map output on a tile on the dashboard.
            FileStream stream = new FileStream(@"map.jpg", FileMode.Open, FileAccess.Read);
            radPictureBox1.Image = Image.FromStream(stream);
            stream.Close();
            StreetInfo(latitude, longitude);
        }

        public void StreetInfo(string latitude, string longitude)
        {
            try
            {
                var client = new RestClient("https://api.myptv.com/geocoding/v1/locations/by-position/" + latitude +
                                            "/" + longitude + "?language=en");
                var request = new RestRequest(Method.GET);
                request.AddHeader("apiKey",
                    "MjBhYTg3MjRlMWZlNDk2OTk0NzZhMWIzMTU3Zjg1ZWY6ZTMxZTVjMGMtM2I0My00ODAwLThmOWYtNjY5ODk4OWRlMWJm");

                //Response is a JSON object string.
                IRestResponse<Location> response = client.Execute<Location>(request);
                JsonDocument doc = JsonDocument.Parse(response.Content);
                JsonElement root = doc.RootElement;
                barStaticItem1.Name = root[0].ToString();
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

        public class Quality
        {
            public int TotalScore { get; set; }
        }

        public class Location
        {
            public ReferencePosition ReferencePosition { get; set; }
            public Address Address { get; set; }
            public string FormattedAddress { get; set; }
            public string LocationType { get; set; }
            public Quality Quality { get; set; }
        }

        public class Root
        {
            public List<Location> Locations { get; set; }
        }


        public void GetStreetName(string coords)
        {
            //Now we do another request for the location data payload to gather road details.
            string uri = "https://revgeocode.search.hereapi.com/v1/revgeocode";
            string myParameters = "?apiKey=JdeLHTyZLIIKCjldtL0VTEMuXvaGIzkVdIFvLx8yD84&at=" + coords + "&lang=en-US";

            string url = uri + myParameters;
            String serializedResponse = String.Empty;

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    serializedResponse = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                    //var jsonresult = JsonConvert.DeserializeObject<RoadInfo>(serializedResponse);


                }
            }
            catch (Exception ex)
            {
                SentrySdk.CaptureMessage(ex.ToString());

            }
        }

        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
