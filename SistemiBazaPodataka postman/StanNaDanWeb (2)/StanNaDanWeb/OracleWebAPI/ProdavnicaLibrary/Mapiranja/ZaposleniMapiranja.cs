using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using StanNaDanv2.Entiteti;


namespace StanNaDanv2.Mapiranja
{
    public class ZaposleniMapiranja : ClassMap<StanNaDanv2.Entiteti.Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            Table("ZAPOSLENI");

            DiscriminateSubClassesOnColumn("zaposleni")
                .Formula("CASE WHEN (FSef = 1 AND FAgent = 0) THEN 'sef' " +
                         "WHEN (FSef = 0 AND FAgent = 1) THEN 'agent' " +
                         "WHEN (FSef = 0 AND FAgent = 0) THEN 'zaposleni' " +
                         "ELSE 'Nepoznato' END")
                .Not.Nullable();

            Id(x => x.maticni_broj_zaposlenog, "MATICNI_BROJ_ZAPOSLENOG").GeneratedBy.Assigned();

            Map(x => x.ime, "ime");
            Map(x => x.datum_zaposlenja, "DATUM_ZAPOSLENJA");
            Map(x => x.FSef).Column("FSef");
            Map(x => x.FAgent).Column("FAgent");
            References(x => x.Poslovnica).Column("POSLOVNICAID");
            References(x => x.agencija).Column("AGENCIJAID");

           
        }
    }

}
