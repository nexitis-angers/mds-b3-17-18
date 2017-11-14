using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TroisiemeApplication.Model
{
    [XmlRoot("Customer")]
    public class Client
    {
        /// <summary>
        /// Affecte ou obtient l'id du client
        /// </summary>
        [XmlAttribute("Id")]
        public int Id { get; set; }
        /// <summary>
        /// Affecte ou obtient le nom
        /// </summary>
        [XmlElement("LastName")]
        public string Nom { get; set; }
        /// <summary>
        /// Affecte ou obtient le prénom
        /// </summary>
        [XmlElement("FirstName")]
        public string Prenom { get; set; }
        /// <summary>
        /// Affecte ou obtient le commentaire sur le client
        /// </summary>
        [XmlIgnore()]
        public string Commentaire { get; set; }

        /// <summary>
        /// Affecte ou obtient le commentaire protégé par une instruction CData
        /// </summary>
        [XmlElement("Comment")]
        public XmlCDataSection CommentaireCData
        {
            get
            {
                XmlDocument xmlDoc = new XmlDocument();
                return xmlDoc.CreateCDataSection(this.Commentaire);
            }
            set
            {
                Commentaire = value.Value;
            }
        }

        /// <summary>
        /// Affecte ou obtient la date de naissance
        /// </summary>
        [XmlIgnore()]
        public DateTime DateNaissance { get; set; }

        /// <summary>
        /// Affecget ou obtient la date de naissance formattée
        /// </summary>
        [XmlElement("BirthDate")]
        public string DateNaissanceFormattee
        {
            get
            {
                return DateNaissance.ToString("dd/MM/yyyy", CultureInfo.CurrentCulture);
            }
            set
            {
                DateNaissance = DateTime.ParseExact(value, "dd/MM/yyyy", CultureInfo.CurrentCulture);
            }
        }

        /// <summary>
        /// Affecte ou obtient la liste des factures du client
        /// </summary>
        [XmlArray("Orders")]
        [XmlArrayItem("Order")]
        public List<Facture> Factures { get; set; } = new List<Facture>();

        public Client()
        {
            //Factures = new List<Facture>();
        }
    }
}
