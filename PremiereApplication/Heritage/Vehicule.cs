using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereApplication.Heritage
{
    public abstract class Vehicule
    {
        /// <summary>
        /// Affecte ou obtient le constructeur du véhicule
        /// </summary>
        public string Constructeur { get; set; }

        public Vehicule(string constructeur)
        {
            this.Constructeur = constructeur;
        }

        public abstract void Avancer();
    }
}
