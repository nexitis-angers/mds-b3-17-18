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
    public class Client
    {
        private AbstractMoteur moteur;

        private AbstractCarosserie carosserie;

        private AbstractLieuRoulage lieuRoulage;

        private AbstractMoto moto;

        public Client(AbstractFactory factory)
        {
            moto = factory.CreerMoto();
            moteur = factory.CreerMoteur();
            carosserie = factory.CreerCarosserie();
            lieuRoulage = factory.CreerLieuRoulage();
        }

        public void Execute()
        {
            Console.WriteLine(moto.ToString());
        }
    }
}
