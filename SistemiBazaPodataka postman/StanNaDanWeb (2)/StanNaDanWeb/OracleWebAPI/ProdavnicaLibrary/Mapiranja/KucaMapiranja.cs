using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Mapiranja
{
    internal class KucaMapiranja:SubclassMap<StanNaDanv2.Entiteti.Kuca>
    {
        public KucaMapiranja()
        {
       
            DiscriminatorValue("kuca");
          

            Map(x => x.SPRATNOST).Column("SPRATNOST");

            Map(x => x.DVORISTE).Column("DVORISTE");
        }
    }
}
