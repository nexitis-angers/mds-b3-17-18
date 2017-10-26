using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondeApplication.Model 
{
    public class Personne : IComparable<Personne>
    {
        #region Properties

        /// <summary>
        /// Affecte ou obtient le nom de la personne
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Affecte ou obtient le prénom
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// Affecte ou obtient la civilité
        /// </summary>
        public string Civilite { get; set; }
        /// <summary>
        /// Affecte ou obtient l'adresse
        /// </summary>
        public string Adresse { get; set; }
        /// <summary>
        /// Affecte ou obtient le code postal
        /// </summary>
        public string CodePostal { get; set; }
        /// <summary>
        /// Affecte ou obtient la ville
        /// </summary>
        public string Ville { get; set; }
        /// <summary>
        /// Affecte ou obtient l'email
        /// </summary>
        public string Email { get; set; }
        #endregion

        #region Constructors

        #endregion

        #region Methods
        public override int GetHashCode()
        {
            return !string.IsNullOrEmpty(Email) ? Email.GetHashCode() : 0;

            //if(Email != null && Email != "")
            //{
            //    return Email.GetHashCode();
            //}
            //else
            //{
            //    return 0;
            //}
        }

        public override bool Equals(object obj)
        {
            return GetHashCode().Equals(obj.GetHashCode());
        }

        public override string ToString()
        {
            return $"{Civilite} {Prenom} {Nom} - {Email}";
        }

        public int CompareTo(Personne other)
        {
            return GetHashCode().CompareTo(other.GetHashCode());
        }
        #endregion
    }
}
