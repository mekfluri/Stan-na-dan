using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using StanNaDanv2.Entiteti;


namespace StanNaDanv2.Mapiranja
{
    public class BrojeviTelefonaFizickogLicaMapiranja : ClassMap<BrojeviTelefonaFizickogLica>
    {
        public BrojeviTelefonaFizickogLicaMapiranja()
        {
            Table("BROJEVI_TELEFONA_FIZICKOG_LICA");

            CompositeId(x => x.ID)
                .KeyReference(x => x.fizickolicebroj, "MATICNI_BROJ_FK")
                .KeyProperty(x => x.broj_telefona, "BROJ_TELEFONA");
        }
    }
}
