using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContact.Entities
{
    public class Civilite : Entity  IComparable<Civilite>
    {
        #region Properties
        /// <summary>
        /// Affecte ou obtient le libellé court
        /// </summary>
        public virtual string LibelleCourt { get; set; }
        /// <summary>
        /// Affecte ou obtient le libellé long
        /// </summary>
        public virtual string LibelleLong { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Calcul du HashCode de l'objet (ce qui le rend unique d'un point du vue métier)
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return !string.IsNullOrEmpty(LibelleCourt) ? LibelleCourt.GetHashCode() : 0;
        }

        /// <summary>
        /// Surcharge de la méthode Equals afin que celle-ci se repose sur le calcul du HashCode
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return GetHashCode().Equals(obj.GetHashCode());
        }

        /// <summary>
        /// Implémentation de la méthode de comparaison de 2 objets entre eux
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public virtual int CompareTo(Civilite other)
        {
            return GetHashCode().CompareTo(other.GetHashCode());
        }
        #endregion

    }
}
