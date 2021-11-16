using System;
using System.Data.SqlClient;
using System.Net.Mail;
using Sentry;

namespace EFRET_TMS
{
    public partial class OnboardP44 : Telerik.WinControls.UI.RadForm
    {
        private string _CompanyCode;
        private static string _CompanyEmail;
        private static string _CompanyName;
        private static string _CompanyContact;

        public OnboardP44(string CompanyCode)
        {
            InitializeComponent();
            _CompanyCode = CompanyCode;
            getCompanyInfo(CompanyCode);
            sendInvite(_CompanyCode);
            
        }


        public static void getCompanyInfo(string CompanyCode)
        {
            string queryString = "SELECT * FROM [axs].[dbo].[Company] WHERE CompanyCode='" + CompanyCode + "'";
            string connectionString = @"Server=EFRET-APP-01\EFRET;Database=axs;Trusted_Connection=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
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

                SentrySdk.CaptureException(ex);
            }
        }

        public static void sendInvite(string CompanyCode)
        {
            //We should probs do something about storing credentials like this.
            string _sender = "P44@efret.net";
            string _password = "Tom66409";

            string subject = "[" + CompanyCode + "] Project44 Track and Trace Invitation";
            string welcome = "Good afternoon " + _CompanyContact;
            string to = _CompanyEmail;//company email
            string from = _sender;
            MailMessage message = new MailMessage(from, to);
            message.Subject = subject;
            message.Body = welcome+@" Automation is the only way forward, Project44 is part of this. 

This is paid by Efret Ltd. 

This allows for Efret Ltd to have a near real time feed on the location of your fleet which ties into our TMS platform, allowing us to provide you a better service.  
No more endless emails and phone calls during the day. 

Unless mistaken, you have not yet linked to this system? this will cause an unnecessary amount of extra work. 

Any questions, feel free to ask our IT Team.

Link to Track and Trace On-boarding: 

Contact details: 
Email: itsupport@efret.net 
Phone number: 01202-132-760 


We would greatly appreciate it if you could log in and add your trackable assets as soon as humanly possible. 

Kind Regards, ";
            
            
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
            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex);
            }

        }
    }
}
