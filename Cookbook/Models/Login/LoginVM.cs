using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cookbook.Models.Login
{
    public class LoginVM
    {
        #region Properties
        /// <summary>
        /// Affecte ou obtient l'email
        /// </summary>
        [Required]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string Email { get; set; }
        /// <summary>
        /// Affecte ou obtient le mot de passe
        /// </summary>
        [Required]
        public string Password { get; set; }
        #endregion
    }
}