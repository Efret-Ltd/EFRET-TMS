using IO.Ably;
using IO.Ably.Realtime;
using Sentry;
using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace EFRET_TMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
             * Before we do anything, we start a ably sentry instance to log all future errors.
             * We pipe Ably events into sentry to log traffic between clients.
             */
            var user = Environment.UserName;
            ClientOptions clientOptions = new ClientOptions("27XrvA.i-tlMA:o2F5CnEta2QfQbOf");
            AblyRealtime ably = new AblyRealtime(clientOptions);
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://9cdd12dd70d24f6a8666e7784722f6f7@o1039968.ingest.sentry.io/6008805";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
            }))
            {
                // Networking Stuff
                // We hook an on connected event.
                // We keep form out of connection events because offline mode would be very hard to design otherwise.
                ably.Connection.On(ConnectionEvent.Connected, args =>
                {
                    SentrySdk.CaptureMessage(user + " connected to ably.");
                    // We find the channel and publish a greeting to other clients so everyone is aware who is online.
                    IRealtimeChannel channel = ably.Channels.Get("main");
                    channel.Attach((success, error) =>
                    {
                        SentrySdk.CaptureMessage(user + " connected to main channel.");
                    });

                    var greetingMessage = "[" + DateTime.Now + "] " + user + " logged into EFRET TMS.";

                    channel.Publish("LOGIN", greetingMessage, async (success, error) =>
                    {
                        PaginatedResult<IO.Ably.Message> resultPage = await channel.HistoryAsync(null);
                        IO.Ably.Message lastMessage = resultPage.Items[0];
                        var messageId = lastMessage.Id.ToString();
                        var messageData = lastMessage.Data.ToString();


                    });
                    channel.Subscribe(message =>
                    {
                        RadMessageBox.Show($"Message: {message.Name}\n{message.Data}");
                    });


                });
                ably.Connection.On(ConnectionEvent.Failed, args =>
                {
                    SentrySdk.CaptureMessage(user + " failed to connect to ably.");
                });
                ably.Connection.On(ConnectionEvent.Closed, args =>
                {
                    SentrySdk.CaptureMessage(user + " closed connection to ably.");
                });
                ably.Connection.On(ConnectionEvent.Closing, args =>
                {
                    SentrySdk.CaptureMessage(user + " attempted to close connection to ably.");
                });
                /*  ConnectionEvent.Connecting
                 * This gets fired before we successfully or failed to connect. Be worth adding further logging scripts to ensure
                 * users are able to reconnect on failure.
                */
                ably.Connection.On(ConnectionEvent.Connecting, args =>
                {
                    SentrySdk.CaptureMessage(user + " connecting to ably.");
                });
                ably.Connection.On(ConnectionEvent.Disconnected, args =>
                {
                    SentrySdk.CaptureMessage(user + " disconnected from ably.");
                });
                ably.Connection.On(ConnectionEvent.Initialized, args =>
                {
                    SentrySdk.CaptureMessage(user + " initalized connection to ably.");
                });
                ably.Connection.On(ConnectionEvent.Suspended, args =>
                {
                    SentrySdk.CaptureMessage(user + " suspended connection to ably.");

                });
                ably.Connection.On(ConnectionEvent.Update, args =>
                {
                    SentrySdk.CaptureMessage(user + " updated connection to ably.");
                });


                //We now launch the RadForm with a splashscreen manager.
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new RadForm1());
            }
        }
    }
}