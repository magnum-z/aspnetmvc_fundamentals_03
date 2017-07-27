using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_03_Task_Add.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            ViewBag.Page = "Home";
            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Page = "Products";
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Page = "Services";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Page = "About";

            return View();
        }        
    }
}