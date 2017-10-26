using PremiereApplication.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereApplication.Heritage
{
    public sealed class Moto : VehiculeTerrestre, IComparable<Moto>
    {
        private int puissance;
        /// <summary>
        /// Obtient ou affecte la puissance de la moto
        /// </summary>
        /// <exception cref="HighPowerException">Déclenchement de l'exception, si la valeur est supérieure à 106</exception>
        public int Puissance
        {
            get { return puissance; }
            set {
                if (value > 106)
                    throw new HighPowerException(value);

                puissance = value;

            }
        }


        //public int Puissance { get; set; }

        public Moto(string constructeur) : base(constructeur, 2)
        {

        }

        public override int GetHashCode()
        {
            unchecked
            {
                return Puissance.GetHashCode();
            }
        }

        public override bool Equals(object obj)
        {
            return GetHashCode().Equals(obj.GetHashCode());
        }

        public int CompareTo(Moto other)
        {
            return GetHashCode().CompareTo(other.GetHashCode());
        }

        public override string ToString()
        {
            return "Moto de marque " + Constructeur + " de puissance " + Puissance + "cv.";
        }
    }
}
