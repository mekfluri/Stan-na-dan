using FluentNHibernate.Mapping;
using StanNaDanv2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Mapiranja
{
    internal class KuhinjaMapiranja : SubclassMap<Kuhinja>
    {
        public KuhinjaMapiranja()
        {
            Table("Kuhinja");

            DiscriminatorValue("Kuhinja");

            Map(x => x.Posudje, "POSUDJE");
        }
    }
}
