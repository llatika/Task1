using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1.Controllers
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

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult MyAction(string button)
        {
            return View("TestView");
        }

        public ActionResult Inception()
        {

            return View();
        }
        public ActionResult Prioritisation()
        {

            return View();
        }
        public ActionResult Implementation()
        {

            return View();
        }


        public ActionResult FollowUp()
        {

            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult New()
        {
            return View();
        }

        public ActionResult Database()
        {
            return View();
        }

    }
}











        