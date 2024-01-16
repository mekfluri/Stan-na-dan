using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using StanNaDanv2.Entiteti;

namespace StanNaDanv2.Mapiranja 
{
    class AgencijaMapiranja : ClassMap<StanNaDanv2.Entiteti.Agencija>
    {
        public AgencijaMapiranja()
        {
            Table("AGENCIJA");

            Id(x => x.Id, "ID_AGENCIJE").GeneratedBy.TriggerIdentity();

            Map(x => x.naziv, "NAZIV");

            HasMany(x => x.poslovnice).KeyColumn("AGENCIJAID").Cascade.All().Inverse();

            HasMany(x => x.nekretnine).KeyColumn("AGENCIJAID").Cascade.All().Inverse();

            HasMany(x => x.zaposleni).KeyColumn("AGENCIJAID").Cascade.All().Inverse();

            HasMany(x => x.najmovi).KeyColumn("AGENCIJAID").Cascade.All().Inverse();

            HasMany(x=>x.vlasnikAgencije).KeyColumn("AGENCIJAID").Cascade.All().Inverse();

        }
    }
}
