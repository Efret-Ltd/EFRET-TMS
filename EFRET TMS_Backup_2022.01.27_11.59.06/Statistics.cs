
using System;

namespace EFRET_TMS
{
    public partial class Statistics : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    { 
        private DateRange _dateRageFrom = new DateRange();
        public Statistics()
        {
            InitializeComponent();
        }
        //Purchase Report
        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            _dateRageFrom = new DateRange();
            Controls.Add(_dateRageFrom);
            _dateRageFrom.BringToFront();
        }
        //Sales Report
        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            _dateRageFrom = new DateRange();
            Controls.Add(_dateRageFrom);
            _dateRageFrom.BringToFront();
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }
        //Purchase Ferry Report
        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            _dateRageFrom = new DateRange();
            Controls.Add(_dateRageFrom);
            _dateRageFrom.BringToFront();
        }
        //Ferry Sales Report
        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            _dateRageFrom = new DateRange();
            Controls.Add(_dateRageFrom);
            _dateRageFrom.BringToFront();
        }
    }
}
