using Cookbook.DTO.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;

namespace Cookbook.Services
{
    public class ProfileService : BaseService
    {
        /// <summary>
        /// Obtient la liste de tous les profiles de manière asynchrone
        /// </summary>
        public static IEnumerable<ProfileDTO> GetAllProfilesAsync()
        {
            string reponse = Client.GetStringAsync("api/profiles").Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<ProfileDTO>>(reponse);
        }

    }
}