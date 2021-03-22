using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CareInfoProvider.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Course()
        {
            ViewBag.Message = "Course Page";

            return View();
        }

        public ActionResult OtherInfo()
        {
            ViewBag.Message = "OtherInform Page";

            return View();
        }

        public ActionResult MelbourneNursingHome()
        {
            ViewBag.Message = "Nursing home list page.";

            return View();
        }

        public ActionResult SceneSimulation()
        {
            ViewBag.Message = "Simulation.";

            return View();
        }
    }
}