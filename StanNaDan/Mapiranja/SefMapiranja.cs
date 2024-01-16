using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StanNaDanv2.Entiteti;
using FluentNHibernate.Mapping;

namespace StanNaDanv2.Mapiranja
{
    internal class SefMapiranja:SubclassMap<Sef>
    {
        public SefMapiranja()
        {
            Table("ZAPOSLENI");
            DiscriminatorValue("sef");
            Map(x => x.datum_postavljanja, "DATUM_POSTAVLJANJA");
        }
    }
}
