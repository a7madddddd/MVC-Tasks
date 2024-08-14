using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace test_product.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult About(string productName, string productPrice, string productImage)
        {
            List<Dictionary<string, string>> products = Session["Products"] as List<Dictionary<string, string>>;

            if (products == null)
            {
                products = new List<Dictionary<string, string>>();
            }


            Dictionary<string, string> product = new Dictionary<string, string>
            {
                {"Name",productName},
                {"Price", productPrice},
                {"Image",productImage}
            };

            products.Add(product);
            Session["Products"] = products;

            return View();
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<Dictionary<string, string>> products = Session["Products"] as List<Dictionary<string, string>>;

            if (products == null)
            {
                products = (List<Dictionary<string, string>>)Session["Products"];
            }

            return View(products);
        }

        public ActionResult About()
        {
        
            return View();
        
        }



            public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}