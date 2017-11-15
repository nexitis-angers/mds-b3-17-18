using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContact.Entities
{
    public enum TypeInformationContact { Personnel, Professionnel }

    public class InformationContact : Entity, IComparable<InformationContact>
    {
        #region Properties
        /// <summary>
        /// Affecte ou obtient le type d'information de contact
        /// </summary>
        public virtual TypeInformationContact TypeInformationContact { get; set; }
        /// <summary>
        /// Affecte ou obtient l'email
        /// </summary>
        public virtual string Email { get; set; }
        /// <summary>
        /// Affecte ou obtient le numéro de téléphone
        /// </summary>
        public virtual string Telephone { get; set; }
        /// <summary>
        /// Affecte ou obtient l'employé auquel l'information est rattachée
        /// </summary>
        public virtual Employe Employe { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Surcharge du HashCode qui se base sur le type d'information de contact de chaque employé
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return TypeInformationContact.GetHashCode() ^
                (Employe != null ? Employe.GetHashCode() : 0);
        }

        /// <summary>
        /// Surcharge de la méthode de comparaison de 2 Information de contact
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return GetHashCode().Equals(obj.GetHashCode());
        }

        /// <summary>
        /// Implémentation de la méthode de comparaison de 2 informations de contact
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public virtual int CompareTo(InformationContact other)
        {
            return GetHashCode().CompareTo(other.GetHashCode());
        }
        #endregion
    }
}
