using DesignPattern.AbstractFactory.Carosserie;
using DesignPattern.AbstractFactory.LieuRoulage;
using DesignPattern.AbstractFactory.Moteur;
using DesignPattern.AbstractFactory.Moto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class ConcreteFactoryMotoCross : AbstractFactory
    {
        public override AbstractCarosserie CreerCarosserie()
        {
            return new CarosserieCross();
        }

        public override AbstractLieuRoulage CreerLieuRoulage()
        {
            return new Chemin();
        }

        public override AbstractMoteur CreerMoteur()
        {
            return new MoteurCross();
        }

        public override AbstractMoto CreerMoto()
        {
            return new MotoCross(CreerCarosserie(), CreerMoteur(), CreerLieuRoulage());
        }
    }
}
