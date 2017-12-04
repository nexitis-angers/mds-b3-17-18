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
    public abstract class AbstractFactory
    {
        public abstract AbstractCarosserie CreerCarosserie();
        public abstract AbstractMoteur CreerMoteur();
        public abstract AbstractLieuRoulage CreerLieuRoulage();

        public abstract AbstractMoto CreerMoto();
    }
}
