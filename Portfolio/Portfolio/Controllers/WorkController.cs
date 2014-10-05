using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class WorkController : Controller
    {
        //
        // GET: /Work/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DragonCombat()
        {
            return View();
        }

        public ActionResult TriviaGame()
        {
            return View();
        }

        public ActionResult PokerPlayer()
        {
            return View();
        }

        public ActionResult GuessThatNumber()
        {
            return View();
        }
    }
}
