using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.Carosserie
{
    public abstract class AbstractCarosserie
    {
        public bool AUneBulle { get; set; }

        public bool AUneImmatriculation { get; set; }

        public bool ADesPhares { get; set; }


        public AbstractCarosserie(bool bulle, bool immat, bool phares)
        {
            this.AUneBulle = bulle;
            this.AUneImmatriculation = immat;
            this.ADesPhares = phares;
        }

        public override string ToString()
        {
            StringBuilder sbCaracteristiques = new StringBuilder();
            sbCaracteristiques.AppendLine($"Carosserie {this.GetType().Name}");
            sbCaracteristiques.AppendLine($"Bulle : {this.AUneBulle}");
            sbCaracteristiques.AppendLine($"Plaque Immat : {this.AUneImmatriculation}");
            sbCaracteristiques.AppendLine($"Phares : {this.ADesPhares}");

            return sbCaracteristiques.ToString();
        }
    }
}
