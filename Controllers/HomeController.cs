using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        //GET Home/Index
        public ActionResult Index()
        {
            return View();
        }

        //GET Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
       
        //GET Home/Contact
        public ActionResult Contact()
        {
          
            ViewBag.Message = "Having trouble? Send us message.";

            return View();
        }

        [HttpPost]    //action selector
        public ActionResult Contact(string message)
        {
            //TODO : send message to HQ
            ViewBag.Message = "Thanks, we got your message.";

            return View();
        }
        public ActionResult Foo()
        {
            return View ("About");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5ATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            //return Content(serial);
            //retrun new HttpStatusCodeResult(403);
            //return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
            return RedirectToAction("Index");
        }
    }
}