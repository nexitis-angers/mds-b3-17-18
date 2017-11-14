using QuatriemeApplication.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuatriemeApplication.Repositories
{
    public class CiviliteRepository : Repository
    {
        public CiviliteRepository(SqlConnection connection) : base(connection)
        {

        }

        /// <summary>
        /// Sauvegarde la civilité en base de données
        /// </summary>
        /// <param name="civilite">civilite à sauvegarder</param>
        public void SaveCivilite(Civilite civilite)
        {
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.CommandText = "INSERT INTO Civilite(LibelleCourt, LibelleLong) VALUES(@libelleCourt, @libelleLong);";
            insertCommand.Connection = Connection;

            // Paramètres
            insertCommand.Parameters.Add("@libelleCourt", SqlDbType.NVarChar, 50, "LibelleCourt");
            insertCommand.Parameters.Add("@libelleLong", SqlDbType.NVarChar, 50, "LibelleLong");

            insertCommand.Parameters["@libelleCourt"].Value = civilite.LibelleCourt;
            insertCommand.Parameters["@libelleLong"].Value = civilite.LibelleLong;

            int nbResult = ExecuteNonQuery(insertCommand);
            Console.WriteLine($"{nbResult} civilité(s) insérée(s)");
        }

        /// <summary>
        /// Met à jour la civilité passée en paramètre
        /// </summary>
        /// <param name="civilite"></param>
        public void UpdateCivilite(Civilite civilite)
        {
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = this.Connection;
            updateCommand.CommandText = "UPDATE Civilite SET LibelleCourt=@libelleCourt, LibelleLong=@libelleLong WHERE Id = @id";

            updateCommand.Parameters.Add("@libelleCourt", SqlDbType.NVarChar, 50, "LibelleCourt");
            updateCommand.Parameters.Add("@libelleLong", SqlDbType.NVarChar, 50, "LibelleLong");
            updateCommand.Parameters.Add("@id", SqlDbType.Int);

            updateCommand.Parameters["@libelleCourt"].Value = civilite.LibelleCourt;
            updateCommand.Parameters["@libelleLong"].Value = civilite.LibelleLong;
            updateCommand.Parameters["@id"].Value = civilite.Id;

            int nbResult = ExecuteNonQuery(updateCommand);
            Console.WriteLine($"{nbResult} civilité(s) mise(s) à jour");
        }

        /// <summary>
        /// Supprime la civilité dont l'id est passée en paramètre
        /// </summary>
        /// <param name="civiliteId">Identifiant de la civilité à supprimer</param>
        public void DeleteCivilite(int civiliteId)
        {
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = this.Connection;
            deleteCommand.CommandText = "DELETE FROM Civilite WHERE Id = @id";
            
            deleteCommand.Parameters.Add("@id", SqlDbType.Int);
            deleteCommand.Parameters["@id"].Value = civiliteId;

            int nbResult = ExecuteNonQuery(deleteCommand);
            Console.WriteLine($"{nbResult} civilité(s) supprimée(s)");
        }
    }
}
