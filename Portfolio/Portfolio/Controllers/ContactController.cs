using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//add using statement to access mail commands
using System.Net.Mail;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.Contact());
        }

        //create a new contact form
        //[HttpPost]
        //public ActionResult Index(Models.Contact contacts)
        //{
        //    //create connection to database
        //    Models.PortfolioEntities db = new Models.PortfolioEntities();
        //    //add our contact to the new contactform
        //    db.Contacts.Add(contacts);
        //    //save changes
        //    db.SaveChanges();
        //    //kick user to thankyou page
        //    return RedirectToAction("Thankyou", "Contact");
        //}

        //create new contact form post to send me an email with the info (instead of addng to the database)
        [HttpPost]
        public ActionResult Index(Models.Contact contactform)
        {
            //sending an email
            //step 1. add using System.Net.Mail;
            //step 2. create a new message, parameters (who its from, who its to)
            MailMessage message = new MailMessage("theRobots@seedpaths.com", "drewcook29@gmail.com");
            //step 3. Set the subject
            message.Subject = "Contact Request from " + contactform.FirstName;
            //step 4. Construct the body with a a thing called stringBuilder
            //intialize the new stringbuilder
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("Hello Drew!  Good day to you!  Guess what?  You have a new contact request.");
            sb.AppendLine();
            sb.AppendLine("Name: " + contactform.FirstName + " " + contactform.LastName);
            sb.AppendLine();
            sb.AppendLine("Email: " + contactform.EmailAddress);
            sb.AppendLine();
            sb.AppendLine("Message: " + contactform.Comment);
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine("We Love You,");
            sb.AppendLine();
            sb.AppendLine("The Robots");
            //step 5. Add the body to the message
            message.Body = sb.ToString();

            //step 6. Declare the SMTP client
            //          aka. the mail server
            SmtpClient smtpClient = new SmtpClient("mail.dustinkraft.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1");
            //step 7. Send the message
            smtpClient.Send(message);
            //done.
            //kick the user to the ThankYou page
            return RedirectToAction("Thankyou", "Contact");
        }

        public ActionResult Thankyou()
        {
            return View();
        }
    }
}
