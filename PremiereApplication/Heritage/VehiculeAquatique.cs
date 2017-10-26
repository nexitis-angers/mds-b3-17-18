using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereApplication.Heritage
{
    public class VehiculeAquatique : Vehicule, IKlaxonner
    {
        public VehiculeAquatique(string constructeur) : base(constructeur)
        {

        }

        public override void Avancer()
        {
            Console.WriteLine("Je navigue");
        }

        public void Klaxonner()
        {
            Console.WriteLine("Bruouououoouuhhhhhh");
        }
    }
}
