using FluentNHibernate.Mapping;
using GestContact.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContact.DAL.Fluent.Maps
{
    public class EmployeMap : ClassMap<Employe>
    {
        public EmployeMap()
        {
            Table("Employe");
            Id(e => e.Id).GeneratedBy.Native();
            Map(e => e.Matricule).Not.Nullable().Length(10).Index("ix_Employe_Matricule");
            Map(e => e.Email).Not.Nullable().Length(50).UniqueKey("uk_Employe");
            Map(e => e.Nom).Not.Nullable().Length(30).Index("ix_Employe_Nom");
            Map(e => e.Prenom).Length(30);
            References(e => e.Civilite).Not.Nullable().Index("ix_Employe_Civilite");
            HasMany(e => e.InformationsContact).LazyLoad().Cascade.All().Inverse().AsSet();
        }
    }
}
