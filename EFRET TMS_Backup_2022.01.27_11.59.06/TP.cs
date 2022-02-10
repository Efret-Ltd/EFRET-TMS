using DevExpress.XtraScheduler;
using System;

namespace EFRET_TMS
{
    public partial class Tp : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Tp()
        {
            InitializeComponent();
            schedulerDataStorage1.AppointmentsInserted += OnApptChangedInsertedDeleted;
            schedulerDataStorage1.AppointmentsChanged += OnApptChangedInsertedDeleted;
            schedulerDataStorage1.AppointmentsDeleted += OnApptChangedInsertedDeleted;

        }
        private void MapAppointmentData()
        {
            schedulerDataStorage1.Appointments.Mappings.AllDay = "AllDay";
            schedulerDataStorage1.Appointments.Mappings.Description = "Description";
            // Required mapping.
            schedulerDataStorage1.Appointments.Mappings.End = "EndDate";
            schedulerDataStorage1.Appointments.Mappings.Label = "Label";
            schedulerDataStorage1.Appointments.Mappings.Location = "Location";
            schedulerDataStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            schedulerDataStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            // Required mapping.
            schedulerDataStorage1.Appointments.Mappings.Start = "StartDate";
            schedulerDataStorage1.Appointments.Mappings.Status = "Status";
            schedulerDataStorage1.Appointments.Mappings.Subject = "Subject";
            schedulerDataStorage1.Appointments.Mappings.Type = "Type";
            schedulerDataStorage1.Appointments.Mappings.ResourceId = "ResourceIDs";
        }

        private void MapResourceData()
        {
            schedulerDataStorage1.Resources.Mappings.Id = "ResourceID";
            schedulerDataStorage1.Resources.Mappings.Caption = "ResourceName";
        }

        private void TP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'axsDevDataSet.Schedule' table. You can move, or remove it, as needed.
            scheduleTableAdapter.Fill(axsDevDataSet.Schedule);

            schedulerDataStorage1.Appointments.ResourceSharing = true;
            schedulerControl1.GroupType = SchedulerGroupType.Resource;
            schedulerControl1.Start = DateTime.Today;

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