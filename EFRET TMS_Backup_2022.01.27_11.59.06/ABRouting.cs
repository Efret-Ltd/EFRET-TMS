using System;
using System.Net;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace EFRET_TMS
{
    public partial class ABRouting : Telerik.WinControls.UI.RadForm
    {
        public ABRouting()
        {
            InitializeComponent();
        }
        /* The below code is a work in progress and will be rewritten.
         *
         *
         */
        private void ABRouting_Load(object sender, EventArgs e)
        {
            // We call for a GMap instance and throw that on the form.

            GMapProvider.WebProxy = WebRequest.GetSystemWebProxy();
            GMapProvider.WebProxy.Credentials = CredentialCache.DefaultNetworkCredentials;

            
            GMapOverlay markersOverlay = new GMapOverlay("markers");


            //This marker represents the start of the route. Should be done by location of loading.
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(50.784764, -1.8565017), GMarkerGoogleType.green);

            marker.ToolTipText = "Start of AB Routing";
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            // We add the markers to the overlay.
            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markersOverlay);

            startPoint();
        }


        // Here we place a marker where the user clicks on the map. The coords are parsed and calculated between legs.
        void AddMarker(string uid, double lat, double lng)
        {
     
             var marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.orange_dot);
            if (marker.Type == GMarkerGoogleType.orange_dot)
            {
                var leg = "Leg:" + lat.ToString() + lng.ToString() + "\n";
                radRichTextEditor1.Text = leg;

            }
            string name = string.Format("{0} - {1}:{2}", uid, lat, lng);
            marker.ToolTip = new GMapToolTip(marker);
            marker.ToolTipText = name;

            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
            gMapControl1.UpdateMarkerLocalPosition(marker);
            gMapControl1.Refresh();
        }

        void AddStop(string uid, double lat, double lng)
        {

            var marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red_big_stop);
            if (marker.Type == GMarkerGoogleType.red_big_stop)
            {
                var leg = "STOP:" + lat.ToString() + lng.ToString() + "\n";
                radRichTextEditor1.Text = leg;

            }
            string name = string.Format("{0} - {1}:{2}", uid, lat, lng);
            marker.ToolTip = new GMapToolTip(marker);
            marker.ToolTipText = name;

            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
            gMapControl1.UpdateMarkerLocalPosition(marker);
            gMapControl1.Refresh();
        }

        private void startPoint()
        {
            //This is highly temporary for more dynamic code later.
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
            gMapControl1.ShowCenter = false;

            //This is where we center the map. This is basepoint.
            gMapControl1.Position = new PointLatLng(50.784764, -1.8565017);
        }

        private void getcoords(object sender, MouseEventArgs e)
        {
            double lat = 0.0;
            double lng = 0.0;
            int markerCount = 0;
            if (e.Button == MouseButtons.Left)
            {
                lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
                //ajout des overlay
                AddMarker("Leg", lat, lng);
            }

            if (e.Button == MouseButtons.Right)
            {
                lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
                //ajout des overlay
                AddStop("STOP", lat, lng);

            }

            gMapControl1.Refresh();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            resetMap();
        }

        private void resetMap()
        {
            //We want to purge all the changes and markers made by the user, including all KM calculations.
            GMapOverlay markers = new GMapOverlay("markers");
            gMapControl1.Overlays.Remove(markers);
            gMapControl1.Refresh();
        }
    }
}
