using FluentNHibernate.Mapping;
using GestContact.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContact.DAL.Fluent.Maps
{
    public class CiviliteMap : ClassMap<Civilite>
    {
        public CiviliteMap()
        {
            Table("Civilite"); // Définir le nom de la table
            Id(c => c.Id).GeneratedBy.Native(); // Mappage de l'id en laissant NHibernate décider de la gestion de l'incrément
            Map(c => c.LibelleCourt).Not.Nullable().Length(5).UniqueKey("uk_Civilite"); // Mappage du champ LibelleCourt, avec ajout d'un index unique sur ce champ
            Map(c => c.LibelleLong).Not.Nullable().Length(20).Index("ix_Civilite_LibelleLong"); // Mappage du champ LibelleLong, avec ajout d'un index de performance
        }
    }
}
