using FluentNHibernate.Mapping;
using StanNaDanv2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Mapiranja
{
    public class SamoZaposleniMapiranja : SubclassMap<SamoZaposleni>
    {
        public SamoZaposleniMapiranja()
        {
            Table("ZAPOSLENI");
            DiscriminatorValue("zaposleni");
        
        }
    }
}
