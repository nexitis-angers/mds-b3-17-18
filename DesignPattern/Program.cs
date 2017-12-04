using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryMethod = DesignPattern.FactoryMethod;
using AbstractFactory = DesignPattern.AbstractFactory;


namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestFactoryMethod();
            TestAbstractFactory();

            Console.ReadKey();
        }


        static void TestFactoryMethod()
        {
            List<string> fichiersATraiter = new List<string>();
            fichiersATraiter.Add("Clients.csv");
            fichiersATraiter.Add("Clients.xml");
            fichiersATraiter.Add("Clients.json");
            fichiersATraiter.Add("Clients.bin");

            FactoryMethod.Factory factory = new FactoryMethod.ImportFichierFactory();

            foreach (var fichier in fichiersATraiter)
            {
                try
                {
                    FactoryMethod.TraitementAbstrait traitement = factory.InstancierMoteurTraitement(fichier);
                    traitement.Execute();
                    
                }catch(SystemException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void TestAbstractFactory()
        {
            AbstractFactory.AbstractFactory factoryMotoCross = new AbstractFactory.ConcreteFactoryMotoCross();
            AbstractFactory.Client clientMotoCross = new AbstractFactory.Client(factoryMotoCross);
            clientMotoCross.Execute();
        }
    }
}
