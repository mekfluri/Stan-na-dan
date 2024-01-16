using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StanNaDanv2.Entiteti;

namespace StanNaDanv2.Mapiranja
{
    internal class RaspolozivaMestaMapiranja : ClassMap<StanNaDanv2.Entiteti.RaspolozivaMesta>
    {
        public RaspolozivaMestaMapiranja()
        {
            Table("RASPOLOZIVA_MESTA");

            CompositeId(x => x.ID)
                .KeyReference(x => x.nekretnina, "NEKRETNINAID")
                .KeyProperty(x => x.raspoloziva_mesta, "RASPOLOZIVA_MESTA");


        }
    }
}
