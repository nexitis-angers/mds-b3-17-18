using Cookbook.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Cookbook.Filters
{
    public class CultureAttribute : ActionFilterAttribute
    {
        private string culture = "fr";

        public CultureAttribute(string culture)
        {
            this.culture = culture;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string lang = filterContext.RouteData.Values["lang"] as string ?? culture;
            // ?? Opérateur ternaire Identique à string lang = !string.IsNullOrEmpty(filterContext.RouteData.Values["lang"] as string) ? filterContext.RouteData.Values["lang"] as string : culture;

            if(lang != culture)
            {
                try
                {
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);

                    Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
                }
                catch (Exception)
                {
                    throw new InvalidCultureException(lang);
                }
            }
        }
    }
}