using System;
using System.Collections.Generic;
using System.Text;

using LibraryUtilitaires.Google.Mail;

namespace LibraryUtilitaires.Trace.Appenders
{
    public class MailLogAppender : ILogAppender
    {
        private string mail;

        public MailLogAppender(string mail)
        {
            this.mail = mail;
        }

        public void Write(string level, object message)
        {
            switch (level)
            {
                case "ERROR":
                case "FATAL":
                    // Envoie du message à l'utilisateur
                    SmtpGMail client = new SmtpGMail();

                    string subject = "Erreur dans l'application .";
                    StringBuilder body = new StringBuilder();
                    body.AppendFormat("Bonjour, </b><br />Voici l'erreur :<br /> {0}", message);


                    client.SendMessage(this.mail, subject, body.ToString());
                    break;
            }
        }
    }
}
