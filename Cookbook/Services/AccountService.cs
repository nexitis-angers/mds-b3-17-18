using Cookbook.DTO.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cookbook.Services
{
    public class AccountService : BaseService
    {
        /// <summary>
        /// Envoi une requête de création d'un compte
        /// </summary>
        /// <param name="dto"></param>
        public static async Task<string> CreateAccount(AccountDTO dto)
        {
            HttpResponseMessage message = await Client.PostAsJsonAsync("api/lorem/accounts", dto);
            message.EnsureSuccessStatusCode();

            return message.Headers.Location.ToString();
        }
    }
}