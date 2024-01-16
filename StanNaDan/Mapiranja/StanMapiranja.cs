using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StanNaDanv2.Mapiranja
{
    internal class StanMapiranja: SubclassMap<StanNaDanv2.Entiteti.Stan>
    {
        public StanMapiranja()
        {
          

            DiscriminatorValue("stan");


            Map(x => x.SPRAT).Column("SPRAT");

            Map(x => x.LIFT).Column("LIFT");
        }
    }
}
