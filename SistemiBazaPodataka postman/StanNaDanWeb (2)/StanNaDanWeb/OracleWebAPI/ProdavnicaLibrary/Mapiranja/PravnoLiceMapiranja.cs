using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StanNaDanv2.Entiteti;
using FluentNHibernate.Mapping;

namespace StanNaDan.Mapiranja
{
    public class PravnoLiceMapiranja : ClassMap<PravnoLice>
    {
         public PravnoLiceMapiranja()
        {
            Table("PRAVNO_LICE");

            Id(x => x.PIB, "PIB").GeneratedBy.Increment();

            Map(x => x.ime, "IME");
            Map(x => x.adresa_firme, "ADRESA_FIRME");
            Map(x => x.ime_kontakt_osobe, "IME_KONTAKT_OSOBE");
            Map(x => x.email, "EMAIL");

            //References(x => x.vlasnik).Column("VLASNIKID").LazyLoad();
            References(x => x.vlasnik, "VLASNIKID").Unique();

            



        }
    }
}
