using SOLID.DIP.Solution.Interfaces;
using System.Net.Mail;

namespace SOLID.DIP.Solution
{
    public class EmailServices : IEmailServices
    {
        public void Send(string from, string to, string subject, string message)
        {
            var mail = new MailMessage();
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = subject;
            mail.Body = message;
            client.Send(mail);
        }
    }
}
