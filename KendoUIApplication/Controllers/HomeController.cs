using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() 
        {
            return View();
        }

        public ActionResult About()
        {
            var things = new List<string>()
                {
                    "Foo",
                    "Bar",
                    "Baz"
                };
            return Json(things, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}