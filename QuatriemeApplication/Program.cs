using QuatriemeApplication.Entities;
using QuatriemeApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuatriemeApplication
{
    class Program
    {
        /// <summary>
        /// Data Source : Nom du serveur, Ip du serveur,
        /// Initial Catalog : Nom de base de données
        /// Integrated Security : Connexion avec le compte utilisateur local
        /// </summary>
        static readonly SqlConnection connection = new SqlConnection() { ConnectionString = "Data Source=CEDRIC-DEV;Initial Catalog=GestContact;Integrated Security=SSPI;" };

        static CiviliteRepository civiliteRepository = null;

        static void Main(string[] args)
        {
            //civiliteRepository = new Repositories.CiviliteRepository(connection);

            //InsertCivilite("M.", "Monsieur");
            //InsertCivilite("Mme", "Madame");
            //InsertCivilite("Mle", "Mademoiselle");
            //UpdateCivilite(1, "Mr", "Monsieur");
            //DeleteCivilite(3);
            //GetAllCivilites();
            //ListCivilites();
            //GetCivilitesById(1);
            //UpdateCiviliteInORM(2, "Pr", "Professeur");
            InsertCiviliteInORM("Me", "Maître");
            Console.Read();


        }

        #region ADO.NET
        static void GetAllCivilites()
        {
            var civilites = civiliteRepository.GetAll();

            foreach (var civilite in civilites)
            {
                Console.WriteLine($"{civilite.Id}, {civilite.LibelleCourt} {civilite.LibelleLong}");
            }
        }

        static void InsertCivilite(string libelleCourt, string libelleLong)
        {
            Civilite civilite = new Civilite() { LibelleCourt = libelleCourt, LibelleLong = libelleLong };
            civiliteRepository.SaveCivilite(civilite);
        }

        static void UpdateCivilite(int id, string libelleCourt, string libelleLong)
        {
            Civilite civilite = new Civilite() {Id = id, LibelleCourt = libelleCourt, LibelleLong = libelleLong };
            civiliteRepository.UpdateCivilite(civilite);
        }

        static void DeleteCivilite(int id)
        {
            civiliteRepository.DeleteCivilite(id);
        }
        #endregion

        #region EF

        static void ListCivilites()
        {
            using(GestContactEntities entities = new QuatriemeApplication.GestContactEntities())
            {
                foreach (var item in entities.Civilites)
                {
                    Console.WriteLine($"{item.Id}, {item.LibelleCourt}, {item.LibelleLong}");
                }
            }
        }

        static void GetCivilitesById(int id)
        {
            using (GestContactEntities entities = new QuatriemeApplication.GestContactEntities())
            {
                var maCivilite = entities.Civilites.SingleOrDefault(civilite => civilite.Id == id);
               
            }
        }

        static void InsertCiviliteInORM(string libelleCourt, string libelleLong)
        {
            using (GestContactEntities entities = new QuatriemeApplication.GestContactEntities())
            {
                var maCivilite = new QuatriemeApplication.Civilite() { LibelleCourt = libelleCourt, LibelleLong = libelleLong };
                entities.Civilites.Add(maCivilite);
                entities.SaveChanges();

            }
        }

        static void UpdateCiviliteInORM(int id, string libelleCourt, string libelleLong)
        {
            using (GestContactEntities entities = new QuatriemeApplication.GestContactEntities())
            {
                var maCivilite = entities.Civilites.SingleOrDefault(civilite => civilite.Id == id);
                maCivilite.LibelleCourt = libelleCourt;
                maCivilite.LibelleLong = libelleLong;
                entities.SaveChanges();
            }
        }
        #endregion
    }
}
