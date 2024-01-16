using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Mapiranja
{
    internal class DodatnaOpremaMapiranja : SubclassMap<StanNaDanv2.Entiteti.DodatnaOprema>
    {
        public DodatnaOpremaMapiranja()
        {
            Table("DodatnaOprema");

            DiscriminatorValue("DodatnaOprema");

            Map(x => x.TipDodatneOpreme, "TIP_DODATNE_OPREME");
            Map(x => x.Doplata, "DOPLATA");
        }
    }
}
