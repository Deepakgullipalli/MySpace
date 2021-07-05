using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Exchange.WebServices.Data;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Connect to Exchange Web Services as user1 at contoso.com.
                ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2010_SP2);
                service.Credentials = new WebCredentials("anusidhartha@outlook.com", "sidharth!D9 ");
                service.AutodiscoverUrl("anusidhartha@outlook.com");

                // Create the e-mail message, set its properties, and send it to user2@contoso.com, saving a copy to the Sent Items folder. 
                EmailMessage message = new EmailMessage(service);
                message.Subject = "Interesting";
                message.Body = "The proposition has been considered.";
                message.ToRecipients.Add("anusidhartha@outlook.com");
                message.Attachments.AddFileAttachment("C:\\Users\\anusi\\Desktop\\SriramGullipalli.pdf");
                message.SendAndSaveCopy();

                // Write confirmation message to console window.
                Console.WriteLine("Message sent!");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
