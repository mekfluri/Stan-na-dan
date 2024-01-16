using FluentNHibernate.Mapping;
using StanNaDanv2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Mapiranja
{
    internal class KrevetMapiranja : SubclassMap<Krevet>
    {
        public KrevetMapiranja()
        {
            Table("Krevet");

            DiscriminatorValue("Krevet");

            Map(x => x.Dimenzije, "DIMENZIJE");
            Map(x => x.TipKreveta, "TIP_KREVETA");
        }
    }
}
