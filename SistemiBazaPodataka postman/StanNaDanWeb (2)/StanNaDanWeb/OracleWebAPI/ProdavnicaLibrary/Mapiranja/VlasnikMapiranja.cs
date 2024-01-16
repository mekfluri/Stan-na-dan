using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using StanNaDanv2.Entiteti;

namespace StanNaDanv2.Mapiranja
{
    class VlasnikMapiranja : ClassMap<Vlasnik>
    {
        public VlasnikMapiranja()
        {
            Table("VLASNIK");

            Id(x => x.Id, "ID_VLASNIKA").GeneratedBy.TriggerIdentity();

            Map(x => x.broj_bankovnog_racuna, "BROJ_BANKOVNOG_RACUNA");
            Map(x => x.banka, "BANKA");

        
            References(x => x.agencija).Column("AGENCIJAID").Unique().Cascade.All();
            HasOne(x => x.pravnolice).PropertyRef(x => x.vlasnik);
           
            HasOne(x => x.fizickolice).PropertyRef(x => x.vlasnik);
            HasMany(x => x.nekretnine).KeyColumn("VLASNIKID").LazyLoad().Cascade.All().Inverse();




        }

    }
}
