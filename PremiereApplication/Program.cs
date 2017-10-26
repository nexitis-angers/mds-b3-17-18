using PremiereApplication.Exceptions;
using PremiereApplication.Heritage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiereApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //int var1 = 10;
            //int var2 = var1;
            //var2 = 40;

            //Console.WriteLine("Var1 vaut " + var1);
            //Console.WriteLine("Var2 vaur " + var2);

            //Console.ReadKey();

            //Personne personne1 = new Personne() { Nom = "Cedric" };
            //Personne personne2 = personne1;
            //personne2.Nom = "Toto";

            //Console.WriteLine("Personne1 s'appelle " + personne1.Nom);
            //Console.WriteLine("Personne2 s'appelle " + personne2.Nom);


            //Vehicule monVehicule = new Vehicule("Renault");

            //List<Vehicule> monGarage = new List<Vehicule>();

            //monGarage.Add(new VehiculeTerrestre("Peugeot", 4));
            //monGarage.Add(new VehiculeTerrestre("Audi", 4));
            //monGarage.Add(new VehiculeAerien("Cesna"));
            //monGarage.Add(new VehiculeAquatique("Peugeot"));

            //foreach (Vehicule vehicule in monGarage)
            //{
            //    vehicule.Avancer();
            //    if (vehicule is IKlaxonner)
            //        FaireDuBruit(vehicule as IKlaxonner);
            //    //(vehicule as IKlaxonner).Klaxonner();
            //    else
            //        Console.WriteLine("Je suis muet");

            //}

            ////MathHelper monHelper = new MathHelper();
            ////Console.WriteLine(monHelper.Additionner(10, 20));
            //MathHelper.Additionner(10, 30, 40, 50, 20, 30, 5);
            ////Vehicule monVehiculeTerrestre = new VehiculeTerrestre("Peugeot", 4);
            ////monVehiculeTerrestre.Avancer();
            //10.Additionner(20);

            //int valeur1 = 10;
            //MathHelper.Additionner(valeur1, 20);
            //valeur1.Additionner(20);

            //Moto motoA = new Moto("Yamaha") { Puissance = 100 };
            //Moto motoB = new Moto("Yamaha") { Puissance = 100 };

            //Console.WriteLine("MotoA est égale à la moto B ? " + motoA.Equals(motoB));

            //var maMoto = new Moto("");
            //var maPersonne = new { Nom = "Daniel", Prenom = "Cedric", Age = 30 };
            //Console.WriteLine(maPersonne.GetType());
            //Console.WriteLine(maMoto.GetType());

            try
            {
                Moto moto = new Moto("Triumph");
                moto.Puissance = 290;
            }
            catch(HighPowerException hpe)
            {
                //Console.WriteLine($"Une erreur est survenue, {hpe.Message}");
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Attention, la propriété moto est nulle");
            }
            catch (Exception e)
            {
                Console.WriteLine("Une erreur inattendue est survenue " + e.ToString());
                //throw new Exception("J'ai rencontré une erreur. :(", e);
                //throw; // A NE JAMAIS FAIRE
            }
            finally
            {
                Console.WriteLine("Je suis passé dans le finally");
            }
            
            Console.ReadKey();
        }

        static void FaireDuBruit(IKlaxonner objetQuiFaitDuBruit)
        {
            objetQuiFaitDuBruit.Klaxonner();
        }

        static void QuiEstTu(Vehicule vehicule)
        {
            //if (vehicule.GetType() == typeof(VehiculeTerrestre))
            //if (vehicule is VehiculeTerrestre)
            //{
            VehiculeTerrestre monVehicule1 = (vehicule as VehiculeTerrestre);
            VehiculeTerrestre monVehicule2 = ((VehiculeTerrestre)vehicule);

            //((VehiculeTerrestre)vehicule).NombreDeRoues = 2;
            //(vehicule as VehiculeTerrestre).NombreDeRoues = 2;
            //}
        }

        //public void QuiEstTu(VehiculeAquatique vehicule)
        //{

        //}

        //public void QuiEstTu(VehiculeAerien vehicule)
        //{

        //}
    }

    public class Personne
    {
        private string nom;
        /// <summary>
        /// Affecte ou obtient le nom de la personne
        /// </summary>
        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }

        public string Prenom { get; set; }
        
    }
}
