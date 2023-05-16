using Estate_Agency.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace Estate_Agency.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public void SendMail(ContactModel contactModel)
        {
            MailAddress From = new MailAddress("estate.agency2023@yandex.ru", "TEST");
            MailAddress To = new MailAddress("estate.agency2023@yandex.ru");
            MailMessage mailMessage = new MailMessage(From, To);
            mailMessage.Subject = "Estate Agency";
            mailMessage.Body = contactModel.Ask; // message text
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            smtp.Credentials = new NetworkCredential("estate.agency2023@yandex.ru", "qwerty123654789qwerty");
            smtp.EnableSsl = true;
            smtp.Send(mailMessage);
        }
    }
}
