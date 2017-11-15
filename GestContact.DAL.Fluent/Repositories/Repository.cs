using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContact.DAL.Fluent.Repositories
{
    public abstract class Repository<T> where T : Entities.Entity
    {
        /// <summary>
        /// Obtient la Session Factory générée à l'ouverture de la connexion à la BDD
        /// </summary>
        protected static ISessionFactory SessionFactory { get { return InitDatabase.SessionFactory; } }

        /// <summary>
        /// Insère l'objet passée en paramètre
        /// </summary>
        /// <param name="obj"></param>
        public static void Save(T obj)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        if (obj.Id == 0)
                        {
                            // On demande à NHibernate de passer l'état de l'objet transient à un état persisté
                            session.Save(obj);
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Supprime l'objet passée en paramètre
        /// </summary>
        /// <param name="obj"></param>
        public static void Delete(T obj)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(obj);
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Obtient l'ensemble des objets 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<T> GetAll()
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                // QueryOver == From en SQL
                var civilites = session.QueryOver<T>().List();
                return civilites;
            }
        }
        
        /// <summary>
        /// Obtient un objet à partir de son identifiant
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static T GetById(int id)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                return session.QueryOver<T>() // Clause FROM
                    .Where(obj => obj.Id == id) // Clause WHERE
                    .SingleOrDefault(); // OBtient un seul objet ou null si inexistant
            }
        }
    }
}
