using Cookbook.DTO.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cookbook.Api.Controllers
{
    public class ProfileController : ApiController
    {
        /// <summary>
        /// Obtenir l'ensemble des profils utilisateurs
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/profiles")]
        public HttpResponseMessage GetAll()
        {
            using (GestContactEntities context = new GestContactEntities())
            {
                //List<ProfileDTO> dtos = new List<ProfileDTO>();
                //foreach (var p in context.Profiles)
                //{
                //    dtos.Add(new ProfileDTO()
                //    {
                //        Id = p.Id,
                //        Name = p.Name
                //    });
                //}
                
                return Request.CreateResponse(HttpStatusCode.OK,
                    context.Profiles
                    .Select(p =>
                        new ProfileDTO()
                        {
                            Id = p.Id,
                            Name = p.Name
                        }).ToList());
            }
        }

    }
}
