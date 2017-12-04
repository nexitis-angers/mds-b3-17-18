using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudIO.Tools.BusinessModel;
using StudIO.Tools.BusinessModel.Helpers;
using StudIO.Tools.BusinessModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace GestContact.Entities
{
    public class Class1 : BaseModel, IComparable<Class1>, IEquatable<Class1>
    {
        #region Properties

        #endregion

        #region Constructors
        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Class1()
        {

        }
        #endregion

        #region Methods

        #endregion

        #region Méthodes gérant les égalités et les comparaisons entre les objets
        /// <summary>
        /// Sert de fonction de hachage pour l'objet en cours.
        /// </summary>
        /// <returns>Code de hachage pour l'objet en cours.</returns>
        public override int GetHashCode()
        {
            throw new NotImplementedException("Implémenter le calcul du HashCode...");
            // return HashCodeHelper.GetHashCode(param1, param2);
        }

        /// <summary>
        /// Détermine si l'objet spécifié est identique à l'objet actuel.
        /// </summary>
        /// <param name="obj">Objet à comparer avec l'objet actif. </param>
        /// <returns>true si l'objet spécifié est égal à l'objet actif ; sinon, false.</returns>
        public override bool Equals(object obj)
        {
            return GetHashCode().Equals(obj.GetHashCode());
        }

        /// <summary>
        /// Compare l'objet en cours à un autre objet du même type.
        /// </summary>
        /// <param name="other">Objet à comparer avec cet objet.</param>
        /// <returns>Valeur qui indique l'ordre relatif des objets comparés.</returns>
        public virtual int CompareTo(Class1 other)
        {
            return GetHashCode().CompareTo(other.GetHashCode());
        }

        /// <summary>
        /// Indique si l'objet actuel est égal à un autre objet du même type.
        /// </summary>
        /// <param name="other">Objet à comparer avec cet objet.</param>
        /// <returns>true si l'objet en cours est égal au paramètre other ; sinon, false.</returns>
        public virtual bool Equals(Class1 other)
        {
            return GetHashCode().Equals(other.GetHashCode());
        }
        #endregion
    }
}
