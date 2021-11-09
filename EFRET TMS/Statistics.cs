using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EFRET_TMS
{
    public partial class Statistics : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    { 
        private DateRange dateRageFrom = new DateRange();
        public Statistics()
        {
            InitializeComponent();
        }
        //Purchase Report
        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            dateRageFrom = new DateRange();
            Controls.Add(dateRageFrom);
            dateRageFrom.BringToFront();
        }
        //Sales Report
        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            dateRageFrom = new DateRange();
            Controls.Add(dateRageFrom);
            dateRageFrom.BringToFront();
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }
        //Purchase Ferry Report
        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            dateRageFrom = new DateRange();
            Controls.Add(dateRageFrom);
            dateRageFrom.BringToFront();
        }
        //Ferry Sales Report
        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            dateRageFrom = new DateRange();
            Controls.Add(dateRageFrom);
            dateRageFrom.BringToFront();
        }
    }
}
