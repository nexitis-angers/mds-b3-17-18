using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.AbstractFactory.Carosserie;
using DesignPattern.AbstractFactory.LieuRoulage;
using DesignPattern.AbstractFactory.Moteur;

namespace DesignPattern.AbstractFactory.Moto
{
    public class MotoCross : AbstractMoto
    {
        public MotoCross(AbstractCarosserie carosserie, AbstractMoteur moteur, AbstractLieuRoulage lieuRoulage) : base(carosserie, moteur, lieuRoulage)
        {
        }
    }
}
