using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public class PlacementService
  {
    public static void sendmail(string to, string body)
    {
      try
      {
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
        mail.From = new MailAddress("malkaspaintings@gmail.com");
        mail.To.Add(to);

        mail.Body = "הכיתוב שאתם רוצות לשלוח";
        //אפשר לעשות פה שווה ל - בודי  שקבלתם));
        //לשים את ההזמנה שלנו
        SmtpServer.Port = 587;
        SmtpServer.Credentials = new System.Net.NetworkCredential("malkaspaintings@gmail.com", "Malkaart332");
        SmtpServer.EnableSsl = true;

        SmtpServer.Send(mail);
      }
      catch (Exception e)
      {
        throw e;
      }

    }
  }
}
