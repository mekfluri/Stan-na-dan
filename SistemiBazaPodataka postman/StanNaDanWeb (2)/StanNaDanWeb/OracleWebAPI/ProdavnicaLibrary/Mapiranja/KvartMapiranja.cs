using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Mapiranja
{
    internal class KvartMapiranja:ClassMap<StanNaDanv2.Entiteti.Kvart>
    {
        public KvartMapiranja()
        {
            Table("KVART");

            Id(x => x.kvartID, "ID_KVARTA ").GeneratedBy.Increment();


            Map(x => x.gradska_zona, "GRADSKA_ZONA");

            Map(x => x.broj_nekretnina).Column("BROJ_NEKRETNINA");

            References(x => x.poslovnica).Column("POSLOVNICAID").LazyLoad();
          HasMany(x => x.nekretnine).KeyColumn("KVARTID").LazyLoad();

         //  References(x => x.poslovicaID, "POSLOVNICAID").Unique();

        }
    }
}
