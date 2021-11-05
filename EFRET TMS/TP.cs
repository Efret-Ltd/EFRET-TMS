using DevExpress.XtraScheduler;
using System;
using System.Data;
using System.Data.SqlClient;

namespace EFRET_TMS
{
    public partial class Tp : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Tp()
        {
            InitializeComponent();
            this.schedulerDataStorage1.AppointmentsInserted += OnApptChangedInsertedDeleted;
            this.schedulerDataStorage1.AppointmentsChanged += OnApptChangedInsertedDeleted;
            this.schedulerDataStorage1.AppointmentsDeleted += OnApptChangedInsertedDeleted;

        }
        private void MapAppointmentData()
        {
            this.schedulerDataStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerDataStorage1.Appointments.Mappings.Description = "Description";
            // Required mapping.
            this.schedulerDataStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerDataStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerDataStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerDataStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerDataStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            // Required mapping.
            this.schedulerDataStorage1.Appointments.Mappings.Start = "StartDate";
            this.schedulerDataStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerDataStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerDataStorage1.Appointments.Mappings.Type = "Type";
            this.schedulerDataStorage1.Appointments.Mappings.ResourceId = "ResourceIDs";
        }

    private void MapResourceData()
        {
            this.schedulerDataStorage1.Resources.Mappings.Id = "ResourceID";
            this.schedulerDataStorage1.Resources.Mappings.Caption = "ResourceName";
        }

        private void TP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'axsDevDataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.axsDevDataSet.Schedule);

            this.schedulerDataStorage1.Appointments.ResourceSharing = true;
            this.schedulerControl1.GroupType = SchedulerGroupType.Resource;
            this.schedulerControl1.Start = DateTime.Today;

            // Specify mappings.
            MapAppointmentData();
            MapResourceData();


        }
     
        // Store modified data in the database
        private void OnApptChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {

        }
    }
}