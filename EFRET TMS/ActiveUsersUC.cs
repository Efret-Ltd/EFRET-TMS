using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFRET_TMS
{
    public partial class ActiveUsersUC : UserControl
    {
        public ActiveUsersUC()
        {
            InitializeComponent();
            toastNotificationsManager1.ShowNotification("690dd219-6b14-4ad5-be71-34acb45781d6");
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
