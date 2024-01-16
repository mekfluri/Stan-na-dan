using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StanNaDanv2.Entiteti;
using FluentNHibernate.Mapping;

namespace StanNaDanv2.Mapiranja
{
    class FizickoLiceMapiranja : ClassMap<FizickoLice>
    {
        public FizickoLiceMapiranja()
        {

            Table("FIZICKO_LICE");

            Id(x => x.maticni_broj, "MATICNI_BROJ").GeneratedBy.Increment();

            Map(x => x.ime, "IME");
            Map(x => x.ime_roditelja, "IME_RODITELJA");
            Map(x => x.prezime, "PREZIME");
            Map(x => x.drzava, "DRZAVA");
            Map(x => x.mesto, "MESTO");
            Map(x => x.adresa, "ADRESA");
            Map(x => x.datum_rodjenja, "DATUM_RODJENJA");
            Map(x => x.email, "EMAIL");
           

            //References(x => x.vlasnik).Column("VLASNIKID").LazyLoad();
            References(x => x.vlasnik, "VLASNIKID").Unique();

            


        }
    }
}
