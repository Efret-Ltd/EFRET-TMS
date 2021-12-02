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

        private void ABRouting_Load(object sender, EventArgs e)
        {

            GMapProvider.WebProxy = WebRequest.GetSystemWebProxy();
            GMapProvider.WebProxy.Credentials = CredentialCache.DefaultNetworkCredentials;

            
            GMapOverlay markersOverlay = new GMapOverlay("markers");


            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(50.784764, -1.8565017), GMarkerGoogleType.green);

            marker.ToolTipText = "Start of AB Routing";
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markersOverlay);

            startPoint();
        }



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
            GMapOverlay markers = new GMapOverlay("markers");
            gMapControl1.Overlays.Remove(markers);
            gMapControl1.Refresh();
        }
    }
}
