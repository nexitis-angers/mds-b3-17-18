using GestContact.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContact.DAL.Fluent.Repositories
{
    public class EmployeRepository : Repository<Employe>
    {
        public static IEnumerable<Employe> GetEmployesByCivilite(string libelleCourtCivilite)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                Employe employeAlias = null;
                Civilite civiliteAlias = null;

                // Equivalent SQL
                // Select * from Employe employeAlias
                // Inner Join Civilite civiliteAlias on employeAlias.Civilite_id = civiliteAlias.Id
                // Where civiliteAlias.libelleCourt = libelleCourtCivilite
                return session.QueryOver<Employe>(() => employeAlias)
                    .Inner.JoinAlias(() => employeAlias.Civilite, () => civiliteAlias)
                    .Where(() => civiliteAlias.LibelleCourt == libelleCourtCivilite)
                    .List();
            }
        }

    }
}
