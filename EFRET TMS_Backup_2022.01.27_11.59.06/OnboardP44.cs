using System;
using System.Data.SqlClient;
using System.Net.Mail;
using Sentry;
using Telerik.WinControls;

namespace EFRET_TMS
{
    public partial class OnboardP44 : Telerik.WinControls.UI.RadForm
    {
        private string _CompanyCode;
        private static string _CompanyEmail;
        private static string _CompanyName;
        private static string _CompanyContact;
        private static int _sent;
        public OnboardP44()
        {
            InitializeComponent();
        }


        //This function grabs the contact information for a given company code.
        public static void getCompanyInfo(string CompanyCode)
        {
            // Define the connection and query string.
            string queryString = "SELECT * FROM [axs].[dbo].[Company] WHERE CompanyCode='" + CompanyCode + "'";
            string connectionString = @"Server=EFRET-APP-01\EFRET;Database=axs;Trusted_Connection=True;";

            try
            {
                //Use the connection to execute a SQL command.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        //Grab the following fields into the instance.
                        while (reader.Read())
                        {
                            _CompanyEmail = reader["CompanyEmail"].ToString();
                            _CompanyName = reader["CompanyName"].ToString();
                            _CompanyContact = reader["CompanyContact"].ToString();
                        }
                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                // Check Sentry for the error.
                SentrySdk.CaptureException(ex);
            }
        }

        public static void sendInvite(string CompanyCode)
        {
            if (_CompanyEmail!="")
            {
                //We should probs do something about storing credentials like this.
                string _sender = "P44@efret.net";
                string _password = "Tom66409";

                //Email structure
                string p44ref =
                    "<a href=' https://eu12.voc.project44.com/portal/v2/public/connect/8b601a7d-7ff2-4a55-85e1-ddaa2cddee86'>Invite Link</a>";
                string subject = "[" + CompanyCode + "] Project44 Track and Trace Invitation";
                string welcome = "Good afternoon, " + _CompanyContact;
                string to = _CompanyEmail;//company email
                string from = _sender;

                //Emails to contact
                MailAddress copy = new MailAddress("charles.duval@efret.net");
                MailAddress CCIntergrationsP44 = new MailAddress("integration.europe@project44.com");

                //Email construction with given parameters.
                MailMessage message = new MailMessage(from, to);

                message.CC.Add(copy);
                message.CC.Add(CCIntergrationsP44);
                
                
                message.Subject = subject;
                message.IsBodyHtml = true;
                //Define the body of the email.
                message.Body = welcome + @" <br>Automation is the only way forward, Project44 is part of this. <br>

This is paid by Efret Ltd.  <br>

This allows for Efret Ltd to have a near real time feed on the location of your fleet which ties into our TMS platform, allowing us to provide you a better service.  
No more endless emails and phone calls during the day.  <br>

Unless mistaken, you have not yet linked to this system? this will cause an unnecessary amount of extra work.  <br>

Any questions, feel free to ask our IT Team.<br>
Link to Track and Trace On-boarding: " + p44ref + @"
 <br>
Contact details: <br>
Email: itsupport@efret.net <br>
Phone number: +44(0)1202-132-760 <br>
 <br>

We would greatly appreciate it if you could log in and add your trackable assets as soon as humanly possible.<br> <strong> Failure to do so will result in late payments </strong><br>
Note: This is a automatic email from a unmonitored mailbox. Do NOT reply to this address. Thank you.
 <br>
Kind Regards, ";

                //Define the SMTP protocol, using O365.

                SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;

                // Credentials are necessary if the server requires the client
                // to authenticate before it will send email on the client's behalf.
                client.UseDefaultCredentials = false;
                System.Net.NetworkCredential credentials =
                    new System.Net.NetworkCredential(_sender, _password);
                client.Credentials = credentials;

                try
                {
                    client.Send(message);
                    _sent = 1;
                }
                catch (Exception ex)
                {
                    _sent = -1;

                    SentrySdk.CaptureException(ex);
                }
                
            }
            else
            {
                RadMessageBox.Show("No Email For " + _CompanyName);
            }
           
        }

        private void sent()
        {
            if (_sent == 1)
            { 
                labelControl1.Text = _CompanyEmail + " has been invited.";

            }

            if (_sent == -1)
            {
                labelControl1.Text = "Failed to invite the company to P44.";

            }
            
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            //We set the _sent to zero so each attempt will throw its own code.
            _sent = 0;
            _CompanyCode = radButtonTextBox1.Text;
            // We attempt to get the company contact information.
            getCompanyInfo(_CompanyCode);
            // We use the contact information from the company code to send the invite.
            sendInvite(_CompanyCode);
            //Did it send?
            sent();
        }

        private void OnboardP44_Load(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
