using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularWithMVCSample.Controllers
{
    public class RoutesDemoController : Controller
    {
        [OutputCache(Location = System.Web.UI.OutputCacheLocation.Client, Duration = 300)]
        public ActionResult One()
        {
            return View();
        }

        public ActionResult OnePartial()
        {
            return PartialView();
        }

        [OutputCache(Location = System.Web.UI.OutputCacheLocation.Client, VaryByParam = "donuts", Duration = 300)]
        public ActionResult Two(int donuts = 1)
        {
            ViewBag.Donuts = donuts;
            return View();
        }

        [OutputCache(Location = System.Web.UI.OutputCacheLocation.Server, VaryByParam = "donuts", Duration = 300)]
        public ActionResult Three()
        {
            return View();
        }
    }
}