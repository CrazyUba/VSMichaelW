using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MichaelW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Post()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Motivation()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Lebenslauf()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}