using Newtonsoft.Json.Linq;
using RestSharp;
using Sentry;
using System;
using System.Drawing;
using System.IO;
using System.Net;

namespace EFRET_TMS
{
    public sealed partial class ShipmentMap : Telerik.WinControls.UI.RadRibbonForm
    {
        private string _p44Lat;
        private string _p44Long;
        private int _zoom;
        public ShipmentMap(int coid, string latitude, string longitude)
        {
        InitializeComponent();
        _p44Lat = latitude;
         _p44Long = longitude;

         Text = @"Shipment tracking for: " + coid;
          GetMapFromCoords(latitude, longitude,15);
          GetStreetName(latitude, longitude);
        }

        public void GetMapFromCoords(string latitude, string longitude,int zoom)
        {
            _zoom = zoom;
            _p44Lat = latitude;
            _p44Long = longitude;
            string coords = latitude + "," + longitude;
            int pictureWidth = 1024;
            int pictureHeight = 1024;


            HttpWebRequest mapRequest = (HttpWebRequest)WebRequest.Create(
                "https://image.maps.ls.hereapi.com/mia/1.6/mapview?c=" + coords +
                "&z=" + _zoom + "&apiKey=JdeLHTyZLIIKCjldtL0VTEMuXvaGIzkVdIFvLx8yD84&w=" + pictureWidth + "&h=" + pictureHeight + "");
            try
            {
                // returned values are returned as a stream, then read into a string
                using (HttpWebResponse mapResponse = (HttpWebResponse)mapRequest.GetResponse())
                {
                    using (BinaryReader reader = new BinaryReader(mapResponse.GetResponseStream()))
                    {
                        byte[] lnByte = reader.ReadBytes(1 * 2048 * 2048 * 10);
                        using (MemoryStream ms = new MemoryStream(lnByte))
                        {
                            radPictureBox1.Image = Image.FromStream(ms);
                            radPictureBox1.Refresh();
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
        }

        public class Root
        {

        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Hide();
            Dispose();
        }

        
        // ZOOOOOOOOOOOOOOOOOOOOOOOM
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(_zoom <20)
            {
                _zoom = _zoom + 1;
            GetMapFromCoords(_p44Lat, _p44Long, _zoom);
            radPictureBox1.Invalidate();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //I think zero and 1 are too far back to provide any constructive information. Will allow the option to zoom out this far though.
            if (_zoom > 1)
            {
                _zoom = _zoom - 1;
                GetMapFromCoords(_p44Lat, _p44Long, _zoom);
                radPictureBox1.Invalidate();
            }
        }
        
    }
}
