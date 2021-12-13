using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFRET_TMS
{
    public partial class TrailerHistory : XtraForm
    {
        public TrailerHistory()
        {
            InitializeComponent();
        }


        private void TrailerHistory_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'axsTrailerHistory1.TrailerHistory' table. You can move, or remove it, as needed.
            this.trailerHistoryTableAdapter1.Fill(this.axsTrailerHistory1.TrailerHistory);
        }

        }
    }
    
