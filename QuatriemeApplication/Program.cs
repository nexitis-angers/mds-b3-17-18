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
            civiliteRepository = new Repositories.CiviliteRepository(connection);

            //InsertCivilite("M.", "Monsieur");
            //InsertCivilite("Mme", "Madame");
            //InsertCivilite("Mle", "Mademoiselle");
            UpdateCivilite(1, "Mr", "Monsieur");
            DeleteCivilite(3);
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
    }
}
