using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuatriemeApplication.Entities
{
    public class Civilite
    {
        /// <summary>
        /// Affecte ou obtient l'id de la civilité
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Affecte ou obtient le libellé court
        /// </summary>
        public string LibelleCourt { get; set; }
        /// <summary>
        /// Affecte ou obtient le libellé long
        /// </summary>
        public string LibelleLong { get; set; }
    }
}
