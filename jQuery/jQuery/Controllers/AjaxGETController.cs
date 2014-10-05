using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQuery.Controllers
{
    public class AjaxGETController : Controller
    {
        //
        // GET: /AjaxGET/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cats()
        {
            //return a partial view which is a view without the layout
            return PartialView();
        }

        public ActionResult Dogs()
        {
            return Content(@"<strong>Dogs</strong> are such sweet animals.  They are man's best friend.  They love you all the time who could not like a dog?");
        }

        public ActionResult Birds()
        {
            return PartialView();
        }

    }
}
