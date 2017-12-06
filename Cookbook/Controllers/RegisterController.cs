using Cookbook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cookbook.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateAccount(string email, string password)
        {
            AccountService.CreateAccount(new DTO.Accounts.AccountDTO() { Email = email, Password = password });

            return RedirectToAction("Index", "Home");
        }
    }
}