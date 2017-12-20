using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Cookbook.Api.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class , AllowMultiple = false)]
    public class CheckTokenAttribute : System.Web.Http.Filters.ActionFilterAttribute
    {
        /// <summary>
        /// Affecte ou obtient le nom du paramètre qui stocke le jeton d'authentification à l'API
        /// </summary>
        public string TokenParameterName { get; set; }

        public CheckTokenAttribute() : this("token") { }

        public CheckTokenAttribute(string tokenParameterName)
        {
            this.TokenParameterName = tokenParameterName;
        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            object token = actionContext.ActionArguments[TokenParameterName];

            if (token == null)
            {
                var message = new HttpResponseMessage(HttpStatusCode.BadRequest);
                message.ReasonPhrase = "La requête ne comporte aucun paramètre de type 'token'.";
                throw new HttpResponseException(message);
            }

            //var company = ORMappingCompany.GetCompanyByToken(token.ToString());
            //if (company == null)
            //{
            //    var message = new HttpResponseMessage(HttpStatusCode.NotFound);
            //    message.ReasonPhrase = string.Format("Le jeton {0} est invalide.", token.ToString());
            //    throw new HttpResponseException(message);
            //}

            base.OnActionExecuting(actionContext);
        }
    }
}