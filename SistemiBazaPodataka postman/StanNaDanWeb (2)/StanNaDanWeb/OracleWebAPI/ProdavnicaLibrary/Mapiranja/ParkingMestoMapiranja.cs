using FluentNHibernate.Mapping;
using StanNaDanv2.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Mapiranja
{
    internal class ParkingMestoMapiranja : SubclassMap<ParkingMesto>
    {
        public ParkingMestoMapiranja()
        {
            Table("ParkingMesto");

            DiscriminatorValue("ParkingMesto");

            Map(x => x.LokacijaParkingMesta, "LOKACIJA_PARKING_MESTA");
            Map(x => x.CenaParkingMesta, "CENA_PARKING_MESTA");

        }
    }
}
