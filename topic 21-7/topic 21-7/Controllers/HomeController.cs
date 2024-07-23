using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace topic_21_7.Controllers
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
        public ActionResult page1()
        {
            ViewBag.Message = " page1";
            return View();
        }
        public ActionResult page2()
        {
            ViewBag.Message = " page2";
            return View();
        }
        public ActionResult page3()
        {
            ViewBag.Message = " page3";
            return View();
        }
        public ActionResult page4()
        {
            ViewBag.Message = " page4";
            return View();
        }
        public ActionResult page5()
        {
            ViewBag.Message = " page5";
            return View();
        }


    }
}