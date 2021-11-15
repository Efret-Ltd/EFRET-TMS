using System;

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
            efretTrailerTableAdapter.Fill(trailers.EfretTrailer);

        }
    }
}
