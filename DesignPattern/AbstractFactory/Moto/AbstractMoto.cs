using DesignPattern.AbstractFactory.Carosserie;
using DesignPattern.AbstractFactory.LieuRoulage;
using DesignPattern.AbstractFactory.Moteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.Moto
{
    public abstract class AbstractMoto
    {
        public AbstractCarosserie Carosserie { get; set; }

        public AbstractMoteur Moteur { get; set; }

        public AbstractLieuRoulage LieuRoulage { get; set; }

        public AbstractMoto(AbstractCarosserie carosserie, AbstractMoteur moteur, AbstractLieuRoulage lieuRoulage)
        {
            this.Carosserie = carosserie;
            this.Moteur = moteur;
            this.LieuRoulage = lieuRoulage;
        }

        public override string ToString()
        {
            StringBuilder sbMoto = new StringBuilder();
            sbMoto.AppendLine($"Je suis une {this.GetType().Name.ToLower()}");
            sbMoto.AppendLine($"Carosserie : {Carosserie.ToString()}");
            sbMoto.AppendLine($"Moteur : {Moteur}");
            sbMoto.AppendLine($"Lieu Roulage:  {LieuRoulage}");

            return sbMoto.ToString();
        }
    }
}
