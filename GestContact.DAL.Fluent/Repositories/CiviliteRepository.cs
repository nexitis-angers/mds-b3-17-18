using GestContact.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContact.DAL.Fluent.Repositories
{
    public class CiviliteRepository : Repository<Civilite>
    {
        /// <summary>
        /// Obtient une civilité à partir de son libellé court
        /// </summary>
        /// <param name="libelleCourt"></param>
        /// <returns></returns>
        public static Civilite GetByLibelleCourt(string libelleCourt)
        {
            using(ISession session = SessionFactory.OpenSession())
            {
                return session.QueryOver<Civilite>()
                    .Where(civilite => civilite.LibelleCourt == libelleCourt)
                    .SingleOrDefault();
            }
        }

    }
}
