using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using IO.Ably;
using Sentry;

namespace EFRET_TMS
{
    class PostTeams
    {
        public PostTeams(string message) {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"),
                        "https://efret.webhook.office.com/webhookb2/35489fe2-948e-4379-8e68-87d79974aee6@ec714a2e-c5d4-46ae-b1ba-36a361a2e00b/IncomingWebhook/780e1042788b4503b968583fad62f00c/a55b8555-1a18-4fcd-9e1a-6382eeb92c5e"))
                    {

                        string postContent = "{'text':'"+ message +"'}";
                        request.Content = new StringContent(postContent);
                        request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                        var response = httpClient.SendAsync(request);
                    }
                }

            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex);

            }




        }
    }
}
