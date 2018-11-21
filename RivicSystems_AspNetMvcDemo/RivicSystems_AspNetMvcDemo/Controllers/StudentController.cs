using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RivicSystems_AspNetMvcDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Details()
        {
            var obj = new Student()
            {
                StudentId = 101,
                StudentName = "Bindu",
                StudentAddress = "Texas"
            };

            return View(obj);
        }


    }
}