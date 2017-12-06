using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cookbook.DTO.Accounts
{
    public class AccountDTO
    {
        /// <summary>
        /// Affecte ou obtient l'email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Affecte ou obtient le mot de passe
        /// </summary>
        public string Password { get; set; }

    }
}