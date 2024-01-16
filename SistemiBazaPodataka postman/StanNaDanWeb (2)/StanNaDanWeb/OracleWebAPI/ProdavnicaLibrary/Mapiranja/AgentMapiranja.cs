using FluentNHibernate.Mapping;
using StanNaDanv2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace StanNaDanv2.Mapiranja
{
    internal class AgentMapiranja:SubclassMap<Agent>
    {

        public AgentMapiranja()
        {

            Table("ZAPOSLENI");
            DiscriminatorValue("agent");
            Map(x => x.strucna_sprema, "STRUCNA_SPREMA");
            HasMany(x => x.spoljni_saradnik).KeyColumn("MATBR_AGENTA").Fetch.Join().Cascade.All();
            HasMany(x => x.ucestvovaoNajmovi).KeyColumn("MATBR_AGENTA").LazyLoad().Cascade.All();
        }
      
      
    }

}

