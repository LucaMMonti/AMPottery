using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace servicios
{
    public class EmailService
    {
        private MailMessage email; //A quien se lo voy a enviar, el cuerpo, el asunto etc.
        private SmtpClient server; //Servidor mediante voy a enviar ese email.

        public EmailService()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("ampottery1@gmail.com", "urquiza1229");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp.gmail.com";
        }

        public void armarCorreo(string emailDestino, string asunto, string cuerpo)
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponder@AMpottery.com");
            email.To.Add(emailDestino);
            email.Subject = asunto;
            email.IsBodyHtml = true;
            email.Body = cuerpo;
        }

        public void enviarEmail()
        {
            try
            {
                server.Send(email);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
