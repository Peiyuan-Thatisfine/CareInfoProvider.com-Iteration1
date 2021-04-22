using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Iteration1_demo1.Controllers
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
        public ActionResult Statistics()
        {
            ViewBag.Message = "Statistics Page";

            return View();
        }

        public ActionResult ElderAbuseInformation()
        {
            ViewBag.Message = "Elder Abuse Information";

            return View();
        }

        public ActionResult MelbourneNursingHome()
        {
            ViewBag.Message = "Melbourne NursingHome Page";

            return View();
        }

        public ActionResult WhatIsElderAbuse()
        {
            ViewBag.Message = "What is the elder abuse Page";

            return View();
        }

        public ActionResult HowToIdentify()
        {
            ViewBag.Message = "How to identify";

            return View();
        }
        public ActionResult ElderAbuseInNursingHome()
        {
            ViewBag.Message = "What is the elder abuse Page";

            return View();
        }
        public ActionResult HowToHelp()
        {
            ViewBag.Message = "What is the elder abuse Page";

            return View();
        }

        public ActionResult Sta()
        {
            ViewBag.Message = "Types";

            return View();
        }

        public ActionResult TypesOfAbuse()
        {
            ViewBag.Message = "Types of elder abuse";
            return View();
        }
    }
}