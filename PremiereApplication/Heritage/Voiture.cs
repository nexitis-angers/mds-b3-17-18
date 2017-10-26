using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereApplication.Heritage
{
    public class Voiture : VehiculeTerrestre
    {
        public Voiture(string constructeur) : base(constructeur, 4)
        {

        }
    }
}
