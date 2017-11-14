using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroisiemeApplication.Model
{
    public class Facture
    {
        /// <summary>
        /// Affecte ou obtient le numéro de la facture
        /// </summary>
        public string NumeroFacture { get; set; }
        /// <summary>
        /// Affecte ou obtient le montant de la facture
        /// </summary>
        public double Montant { get; set; }
    }
}
