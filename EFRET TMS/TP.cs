using DevExpress.XtraScheduler;
using System;

namespace EFRET_TMS
{
    public partial class TP : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TP()
        {
            InitializeComponent();
            this.schedulerDataStorage1.AppointmentsInserted += OnApptChangedInsertedDeleted;
            this.schedulerDataStorage1.AppointmentsChanged += OnApptChangedInsertedDeleted;
            this.schedulerDataStorage1.AppointmentsDeleted += OnApptChangedInsertedDeleted;

        }

        // Store modified data in the database
        private void OnApptChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {

        }

        private void TP_Load(object sender, EventArgs e)
        {


        }
    }
}