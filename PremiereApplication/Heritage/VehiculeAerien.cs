using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereApplication.Heritage
{
    public class VehiculeAerien : Vehicule
    {
        public VehiculeAerien(string constructeur) : base(constructeur)
        {

        }

        public override void Avancer()
        {
            Console.WriteLine("Je vole");

        }
    }
}
