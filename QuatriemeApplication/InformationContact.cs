//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuatriemeApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class InformationContact
    {
        public int Id { get; set; }
        public int TypeInfo { get; set; }
        public string Telephone { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public int Personne_id { get; set; }
    
        public virtual Personne Personne { get; set; }
    }
}