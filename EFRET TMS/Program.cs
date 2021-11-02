using System;
using System.Linq;
using System.Windows.Forms;
using IO.Ably;
using IO.Ably.Realtime;
using Sentry;

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
            var user = Environment.UserName;
            var ably = new AblyRealtime("27XrvA.i-tlMA:o2F5CnEta2QfQbOf");
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
                ///Networking Stuff
                /// 
                // We hook an on connected event.
                ably.Connection.On(ConnectionEvent.Connected, args =>
                {
                    SentrySdk.CaptureMessage(user + " connected to ably.");
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
                // We find the channel and publish a greeting to other clients so everyone is aware who is online.
                IRealtimeChannel channel = ably.Channels.Get("main");
                var greetingMessage = user + " logged into EFRET TMS.";

                // Publish a message to the  channel
                channel.Publish("greeting", greetingMessage);
                channel.Subscribe("greeting", (message) =>
                {
                    SentrySdk.CaptureMessage(message.Data.ToString());
                }); 
                Application.EnableVisualStyles(); 
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new RadForm1());
            }
        }
    }
}