using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduling.Utility
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailjetClient client = new MailjetClient("5736779dd3983b97eed3d675b66149d1", "1ad13ae93cfae439322650abdc55c9a2")
            {
                /*Version = ApiVersion.V3_1,*/
            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
            .Property(Send.FromEmail, "dicentral@hingeto.com")
            .Property(Send.FromName, "Bảo Thi Send Email")
            .Property(Send.Subject, subject)
            .Property(Send.HtmlPart, htmlMessage)
            .Property(Send.Recipients, new JArray {
                new JObject {
                 {"Email", email}
                 }
                });
            MailjetResponse response = await client.PostAsync(request);
        }
    }
}
