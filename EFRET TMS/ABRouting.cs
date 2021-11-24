using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

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
            gMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new GMap.NET.PointLatLng(50.784764, -1.8565017);
            gMapControl1.Zoom = 

        }
    }
}
