using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballTeamWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Exit()
        {
            ViewBag.Message = "До скоро!";

            return View();
        }

        public ActionResult Players()
        {
            return View();
        }
    }
}