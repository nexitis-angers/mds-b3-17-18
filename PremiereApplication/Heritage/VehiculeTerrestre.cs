using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereApplication.Heritage
{
    public class VehiculeTerrestre : Vehicule, IKlaxonner
    {
        /// <summary>
        /// Affecte ou obtient le nombre de roues du véhicule
        /// </summary>
        public int NombreDeRoues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="constructeur"></param>
        public VehiculeTerrestre(string constructeur, int nombreDeRoues) : base(constructeur)
        {
            this.NombreDeRoues = nombreDeRoues;
        }

        public override void Avancer()
        {
            Console.WriteLine("Je roule");
        }

        void IKlaxonner.Klaxonner()
        {
            Console.WriteLine("Tut tut");
        }
    }
}
