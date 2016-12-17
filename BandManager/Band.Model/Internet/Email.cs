using System.Net;
using System.Net.Mail;

namespace Band.Model.Internet
{
    public class Email
    {
        public static void SendEmail(string strFrom, string strTo, string strSubject, string strBody)
        {
            var objMailMessage = new MailMessage();
            var objSMTPUserInfo = new NetworkCredential();
            var objSmtpClient = new SmtpClient();


            objMailMessage.From = new MailAddress(strFrom);
            objMailMessage.To.Add(new MailAddress(strTo));
            objMailMessage.Subject = strSubject;
            objMailMessage.Body = strBody;

            objSmtpClient = new SmtpClient("188.40.103.151", 25);
            objSMTPUserInfo = new NetworkCredential("band@progressband.pl", "yaya2000");
            objSmtpClient.Credentials = objSMTPUserInfo;
            objSmtpClient.UseDefaultCredentials = false;
            objSmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            objSmtpClient.Timeout = 100000;

            objSmtpClient.Send(objMailMessage);
        }
    }
}
