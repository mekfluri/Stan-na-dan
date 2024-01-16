using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StanNaDanv2.Entiteti;

namespace StanNaDanv2.Mapiranja
{
    public class SajtMapiranja:ClassMap<StanNaDanv2.Entiteti.Sajt>
    {
          public SajtMapiranja()
        {
            Table("SAJTOVI");

            CompositeId(x => x.ID)
                        .KeyReference(x => x.nekretnina, "NEKRETNINAID")
                        .KeyProperty(x => x.sajt, "SAJT");
        }

    }
}
