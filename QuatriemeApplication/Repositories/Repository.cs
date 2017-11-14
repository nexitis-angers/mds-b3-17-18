using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuatriemeApplication.Repositories
{
    public abstract class Repository
    {
        /// <summary>
        /// Affecte ou obtient la connexion ouverte
        /// </summary>
        protected SqlConnection Connection { get; private set; }

        public Repository(SqlConnection connection)
        {
            this.Connection = connection;
        }

        /// <summary>
        /// Execute une requête de type NonQuery en gérant la connexion à la base de données
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        protected int ExecuteNonQuery(SqlCommand command)
        {
            try
            {
                // Ouverture de la connexion
                Connection.Open();
                // ExecuteNonQuery => Insert, Update, Delete
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                // Fermeture de la connexion
                Connection.Close();
            }
        } 
    }
}
