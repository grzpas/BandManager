using System.Net;
using System.Net.Mail;

namespace Utils.Internet
{
    /// <summary>
    /// Todo: Move hardcoded values to configuration.
    /// </summary>
    public class Email
    {
        public static void SendEmail(string strFrom, string strTo, string strSubject, string strBody)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress(strFrom)
            };
            mailMessage.To.Add(new MailAddress(strTo));
            mailMessage.Subject = strSubject;
            mailMessage.Body = strBody;

            var smtpClient = new SmtpClient("188.40.103.151", 25);
            var networkCredentials = new NetworkCredential("band@progressband.pl", "yaya2000");
            smtpClient.Credentials = networkCredentials;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Timeout = 100000;

            smtpClient.Send(mailMessage);
        }
    }
}
