using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularWithMVCSample.Controllers
{
    public class RoutesDemoController : Controller
    {
        public ActionResult One()
        {
            return View();
        }

        public ActionResult OnePartial()
        {
            return PartialView();
        }

        public ActionResult Two(int donuts = 1)
        {
            ViewBag.Donuts = donuts;
            return View();
        }

        public ActionResult Three()
        {
            return View();
        }
    }
}