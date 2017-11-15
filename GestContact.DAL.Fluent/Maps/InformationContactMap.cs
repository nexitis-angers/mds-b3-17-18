using FluentNHibernate.Mapping;
using GestContact.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestContact.DAL.Fluent.Maps
{
    public class InformationContactMap : ClassMap<InformationContact>
    {
        public InformationContactMap()
        {
            Table("InformationContact");
            Id(ic => ic.Id).GeneratedBy.Native();
            Map(ic => ic.Email).Length(50);
            Map(ic => ic.Telephone).Length(10);
            Map(ic => ic.TypeInformationContact).Not.Nullable().UniqueKey("uk_InformationContact").CustomType<TypeInformationContactEnumMapper>();
            References(ic => ic.Employe).Not.Nullable().UniqueKey("uk_InformationContact");
        }
    }

    /// <summary>
    /// Décrit comment l'énumation doit-être mappée, ici on souhaite mapper sous forme d'un int
    /// </summary>
    public class TypeInformationContactEnumMapper : NHibernate.Type.PersistentEnumType
    {
        public TypeInformationContactEnumMapper() : base(typeof(TypeInformationContact))
        {

        }
    }
}
