using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPIplusEF.Controllers
{
    public class HomeController2 : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home 2 Page";

            return View();
        }
    }
}
