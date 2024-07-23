using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_23_7.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(FormCollection form)
        {
            var name = form["Name"];
            var phoneNumber = form["PhoneNumber"];
            var gender = form["Gender"];
            var colors = form["colors"];
            var interests = form.GetValues("Interests");

            TempData["Name"] = name;
            TempData["PhoneNumber"] = phoneNumber;
            TempData["Gender"] = gender;
            TempData["colors"] = colors;
            TempData["Interests"] = interests;

            return RedirectToAction("Display");
        }

        public ActionResult Display()
        {
            ViewBag.Name = TempData["Name"];
            ViewBag.PhoneNumber = TempData["PhoneNumber"];
            ViewBag.Gender = TempData["Gender"];
            ViewBag.colors = TempData["colors"];
            ViewBag.Interests = TempData["Interests"];

            return View();
        }

    }
}