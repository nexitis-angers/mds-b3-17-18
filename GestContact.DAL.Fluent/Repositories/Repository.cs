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
                        session.Save(obj);
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
    }
}
