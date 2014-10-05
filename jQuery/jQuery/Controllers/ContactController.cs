using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQuery.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index(Models.ContactForm cf)
        {
            return PartialView("ThankYou");
        }
    }
}
