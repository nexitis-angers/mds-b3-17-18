using Cookbook.App_Start;
using Cookbook.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace Cookbook
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }

        /// <summary>
        /// Méthode qui est déclenchée à chaque requête
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            
            var roles = Roles.GetAllRoles();
            
            //Roles.CreateRole("admin");
            //Roles.
            //if(!Roles.RoleExists("admin"))
            //{
            //    var profiles = ProfileService.GetAllProfilesAsync();
            //}

            //System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("fr");
        }
    }
}
