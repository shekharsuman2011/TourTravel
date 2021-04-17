using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrialTours.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public ActionResult TermsConditions()
        {
            return View();
        }
        public ActionResult CookieConsent()
        {
            return View();
        }
        public ActionResult Experiences()
        {
            return View();
        }
    }
}