using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Cookbook
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:"DefaultWithCulture",
                url:"{lang}/{controller}/{action}/{id}",
                constraints:new { lang=@"(\w{2})|(\w{2}-\w{2})" },
                defaults:new { lang="fr", controller = "Home", action = "Index", id = UrlParameter.Optional }
                );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
