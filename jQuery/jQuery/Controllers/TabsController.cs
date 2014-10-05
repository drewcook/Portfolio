using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQuery.Controllers
{
    public class TabsController : Controller
    {
        //
        // GET: /Tabs/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Tab1()
        {
            return PartialView();
        }

        public ActionResult Tab2()
        {
            return PartialView();
        }

        public ActionResult Tab3()
        {
            return PartialView();
        }
    }
}
