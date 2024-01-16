using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Mapiranja
{
    internal class DodaciMapiranja : ClassMap<StanNaDanv2.Entiteti.Dodaci>
    {
        public DodaciMapiranja()
        {
            Table("DODACI");
            DiscriminateSubClassesOnColumn("TIP_DODATKA");

            Id(x => x.Id, "ID_DODATKA").GeneratedBy.TriggerIdentity();

            //Map(x => x.TipDodatka).Column("TIP_DODATKA");
            References(x => x.nekretnina).Column("NEKRETNINAID");
        }
    }
}
