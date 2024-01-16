using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using StanNaDanv2.Entiteti;

namespace StanNaDanv2.Mapiranja
{
    class BrojeviTelefonaPravnogLicaMapiranja : ClassMap<BrojeviTelefonaPravnogLica>
    {
        public BrojeviTelefonaPravnogLicaMapiranja()
        {
            Table("BROJEVI_TELEFONA_PRAVNOG_LICA");

            CompositeId(x => x.ID)
                .KeyReference(x => x.pravnolicebroj, "PIB_FK")
                .KeyProperty(x => x.broj_telefona, "BROJ_TELEFONA");
        }
    }
}
