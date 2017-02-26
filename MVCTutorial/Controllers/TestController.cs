using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello World abc";
        }

        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Adam";
            emp.LastName = "Rice";
            emp.Salary = 100;
            ViewData["Employee"] = emp;
            return View("MyView");
        }
    }
}