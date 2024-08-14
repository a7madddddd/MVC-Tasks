using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test_view___controller.Controllers
{
    public class HomeController : Controller
    {
            [HttpPost]
        public ActionResult Index(FormCollection form1) {

           
            return View();
        }
        public ActionResult Index()
        {

            return View();
        }


        
        public ActionResult About(FormCollection form1)
        {

            ViewBag.age = form1["num"];
            ViewBag.name = form1["name"];
            ViewBag.Message = "Your application description page.";
            return View();
        }


        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
    }
    