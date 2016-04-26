using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GSBASSIST
{
    class mail
    {
       private static void Envoi(string lemail,string lutilisateur)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpC = new SmtpClient("smtp.gmail.com");
                //From address to send email
                mail.From = new MailAddress("dembele.albert@gmail.com");
                //To address to send email
                mail.To.Add(lemail);
                mail.Body = lutilisateur+"Votre materiel viens d'etre pris en charge par notre technicien";
                mail.Subject = "EQUIPEMENT PRIS EN CHARGE";
                smtpC.Port = 587;
                //Credentials for From address
                smtpC.Credentials = new System.Net.NetworkCredential("EmailID", "password");
                smtpC.EnableSsl = true;
                smtpC.Send(mail);
                Console.WriteLine("REUSSI.???");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetBaseException());
                Console.ReadLine();
            }
        }
    }
}
