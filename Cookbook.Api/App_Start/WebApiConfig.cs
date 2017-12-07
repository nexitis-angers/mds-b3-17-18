using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Cookbook.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web
            // Suppression du formatter XML pour forcer à utiliser le formatter JSON
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
