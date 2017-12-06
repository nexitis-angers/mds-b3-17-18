using Cookbook.DTO.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cookbook.Api.Controllers
{
    public class AccountController : ApiController
    {
        [HttpGet]
        [Route("api/accounts")]
        public HttpResponseMessage Get()
        {
            List<string> accounts = new List<string>();
            accounts.Add("Cedric Daniel");
            accounts.Add("Toto");

            return Request.CreateResponse(HttpStatusCode.OK, accounts);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/{token}/accounts")]
        public HttpResponseMessage Create(string token, [FromBody]AccountDTO dto)
        {
            try
            {
                // TODO : Sauvegarde en BDD
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

    }
}
