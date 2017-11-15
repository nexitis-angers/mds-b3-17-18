using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContact.Entities
{
    public class Employe : Entity, IComparable<Employe>
    {
        #region Properties
        /// <summary>
        /// Affecte ou obtient le numéro de matricule
        /// </summary>
        public virtual string Matricule { get; set; }
        /// <summary>
        /// Affecte ou obtient le nom
        /// </summary>
        public virtual string Nom { get; set; }
        /// <summary>
        /// Affecte ou obtient le prénom
        /// </summary>
        public virtual string Prenom { get; set; }
        /// <summary>
        /// Affecte ou obtient l'email
        /// </summary>
        public virtual string Email { get; set; }
        /// <summary>
        /// Affecte ou obtient la civilité
        /// </summary>
        public virtual Civilite Civilite { get; set; }
        /// <summary>
        /// Affecte ou obtient la liste des informations de contact
        /// </summary>
        public virtual ICollection<InformationContact> InformationsContact { get; set; } = new HashSet<InformationContact>();
        #endregion

        #region Methods
        /// <summary>
        /// Ajoute une information de contact à l'employé, en assurant la double relation
        /// </summary>
        /// <param name="info">Information de contact à attribuer à l'employé</param>
        public virtual void AddInformationContact(InformationContact info)
        {
            info.Employe = this;
            InformationsContact.Add(info);
        }

        /// <summary>
        /// Obtient le hashcode de l'objet
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return !string.IsNullOrEmpty(Email) ? Email.GetHashCode() : 0;
        }

        /// <summary>
        /// Surcharge de la méthode Equals afin que celle-ci repose sur le HashCode de l'objet
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return GetHashCode().Equals(obj.GetHashCode());
        }

        /// <summary>
        /// Implémentation de la méthode CompareTo afin que celle-ci repose sur le HashCode de l'objet
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public virtual int CompareTo(Employe other)
        {
            return GetHashCode().CompareTo(other.GetHashCode());
        }
        #endregion
    }
}
