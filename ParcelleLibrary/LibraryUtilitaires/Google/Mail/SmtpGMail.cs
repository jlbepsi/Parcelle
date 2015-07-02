using System;
using System.Net;
using System.Net.Mail;

namespace LibraryUtilitaires.Google.Mail
{
    public class SmtpGMail : SmtpClient
    {
        public SmtpGMail()
            : base("smtp.gmail.com", 587)
        {
            EnableSsl = true;
            Credentials = new NetworkCredential("your.account@gmail.com", "your.password");
        }

        public void SendMessage(string to, string subject, string body)
        {
            MailMessage mail = new MailMessage("an.email.address@bla.com", to, subject, body);
            mail.IsBodyHtml = true;

            Send(mail);
        }
    }
}
