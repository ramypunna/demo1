using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RivicSystems_AspNetMvcDemo.Controllers
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

        public ActionResult StudentList()
        {
            ViewBag.StudentList = new List<string>()
            {
                "Ramesh",
                "Vijay",
                "Bindu",
                "Naveesh",
                "Sachin"
            };

            return View();
        }
    }
}