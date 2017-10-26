using SecondeApplication.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisir un choix :");
            string choix = Console.ReadLine();

            Console.WriteLine($"vous avez saisi {choix}");



            string cheminFichier = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clients.csv");

            try
            {
                IEnumerable<Personne> personnes = CsvHelper.LireFichier(cheminFichier);

                // Affichage de toutes les personnes chargées
                foreach (var item in personnes)
                {
                    Console.WriteLine(item.ToString());
                }
            }catch(FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Une erreur inattendue est survenue {e.ToString()}");
            }

            Console.ReadKey();
        }


    }
}
