using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Cookbook
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Suppression du formatter XML au profit du Formatter JSON
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
