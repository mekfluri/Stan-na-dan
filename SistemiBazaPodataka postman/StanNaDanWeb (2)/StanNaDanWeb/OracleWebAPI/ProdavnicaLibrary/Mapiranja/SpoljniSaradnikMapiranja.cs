using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Mapiranja
{
    internal class SpoljniSaradnikMapiranja : ClassMap<StanNaDanv2.Entiteti.SpoljniSaradnik>
    {
        public SpoljniSaradnikMapiranja()
        {
            Table("SPOLJNI_SARADNIK");

            CompositeId(x => x.Id)
                .KeyReference(x => x.UnajmioAgent, "MATBR_AGENTA")
                .KeyProperty(x => x.BrojTelefona, "TELEFON");

            Map(x => x.Ime, "IME");
            Map(x => x.DatumAngazovanja, "DATUM_ANGAZOVANJA");
            Map(x => x.Procenat, "PROCENAT");

            //References(x => x.UcestvovaoUNajam).Column("NAJAMID");
        }
    }
}
