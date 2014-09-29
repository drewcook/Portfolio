using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        [HttpPost]
        public ActionResult Index(Models.Contact contacts)
        {
            //create connection to database
            Models.PortfolioEntities db = new Models.PortfolioEntities();
            //add our contact to the new contactform
            db.Contacts.Add(contacts);
            //save changes
            db.SaveChanges();
            //kick user to thankyou page
            return RedirectToAction("Thankyou", "Contact");
        }

        public ActionResult Thankyou()
        {
            return View();
        }
    }
}
