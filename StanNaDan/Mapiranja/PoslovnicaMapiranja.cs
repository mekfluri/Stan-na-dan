using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StanNaDanv2.Entiteti;
using FluentNHibernate.Mapping;

namespace StanNaDanv2.Mapiranja
{
    public class PoslovnicaMapiranja : ClassMap<Poslovnica>
    {
        public PoslovnicaMapiranja()
        {
            Table("POSLOVNICA");

            Id(x => x.Id, "ID_POSLOVNICE").GeneratedBy.TriggerIdentity();

            Map(x => x.adresa, "ADRESA");
            Map(x => x.radno_vreme, "RADNO_VREME");
            

            References(x => x.PripadaAgenciji).Column("AGENCIJAID").LazyLoad();
            HasMany(x => x.kvartovi).KeyColumn("POSLOVNICAID").LazyLoad().Cascade.All().Inverse();
            HasMany(x=>x.listaNajmova).KeyColumn("POSLOVNICAID").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.zaposleni).KeyColumn("POSLOVNICAID").LazyLoad().Cascade.All().Inverse();

        }

    }
}
