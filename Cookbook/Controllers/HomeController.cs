using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookbook.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["message"] = "Bienvenue sur mon site";
            ViewBag.MonMessage = "Test";
            return View();
        }
    }
}