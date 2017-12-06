using Cookbook.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookbook.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View(new LoginVM());
        }

        public ActionResult Login(LoginVM vm)
        {
            if(ModelState.IsValid)
            {
                // TODO : Checker l'existence du compte dans la BDD
            }



            return RedirectToAction("Index");
        }
    }
}