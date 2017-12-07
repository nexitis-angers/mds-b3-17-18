using Cookbook.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Cookbook.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string returnUrl)
        {

            return View(new LoginVM() { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public ActionResult Index(LoginVM vm)
        {
            if (ModelState.IsValid)
            {
                // TODO : Checker l'existence du compte dans la BDD
                FormsAuthentication.SetAuthCookie(vm.Email, false);
            }

            // Protection contre une redirection vers un potentiel site de fishing grâce au fait
            // de vérifier si l'URL de redirection est bien locale à notre site
            if (string.IsNullOrEmpty(vm.ReturnUrl) || !Url.IsLocalUrl(vm.ReturnUrl))
                return RedirectToAction("Index", "Home");
            else
                return Redirect(vm.ReturnUrl);
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}