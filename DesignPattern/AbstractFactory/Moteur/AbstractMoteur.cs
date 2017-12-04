using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.Moteur
{
    public abstract class AbstractMoteur
    {
        public int VMax { get; private set; }

        public AbstractMoteur(int vMax)
        {

        }

        public override string ToString()
        {
            return $"Vitesse max : {VMax}";
        }
    }
}
