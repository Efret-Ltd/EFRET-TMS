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
    public partial class FleetManagement : Telerik.WinControls.UI.RadForm
    {
        public FleetManagement()
        {
            InitializeComponent();
        }

        private void FleetManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trailers.EfretTrailer' table. You can move, or remove it, as needed.
            this.efretTrailerTableAdapter.Fill(this.trailers.EfretTrailer);

        }
    }
}
