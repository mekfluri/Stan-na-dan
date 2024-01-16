using FluentNHibernate.Mapping;
using StanNaDanv2.Entiteti;

namespace StanNaDanv2.Mapiranja
{
    public class NajamMapiranja : ClassMap<Najam>
    {
        public NajamMapiranja()
        {
            Table("Najmovi");

            Id(x => x.Id, "ID_NAJMA").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumPocetka, "DATUM_POCETKA");
            Map(x => x.DatumZavrsetka, "DATUM_ZAVRSETKA");
            Map(x => x.CenaPoDanu, "CENA_PO_DANU");
            Map(x => x.BrojDana, "BROJ_DANA");
            Map(x => x.UkupnaCena, "UKUPNA_CENA");
            Map(x => x.Popust, "POPUST");
            Map(x => x.CenaSaPopustom, "CENA_SA_POPUSTOM");
            Map(x => x.ZaradaOdDrugihUsluga, "ZARADA_OD_DODATNIH_USLUGA");
            Map(x => x.ZbirCena, "ZBIR_CENA");
            Map(x => x.ProvizijaAgencije, "PROVIZIJA_AGENCIJE");

            References(x => x.OrganizujeAgencija).Column("AGENCIJAID");
            References(x => x.OrganizujePoslovnica).Column("POSLOVNICAID");
            References(x => x.UcestvovaoAgent).Column("MATBR_AGENTA");
            /*HasOne(x => x.IznajmljenaNekretnina)
                .PropertyRef(x => x.iznajmljenaUNajmu)
                .Cascade.All()
                .ForeignKey("NEKRETNINAID");*/

            /*HasOne(x => x.IznajmljenaNekretnina)
                   .Constrained()
                   .ForeignKey()
                   .Cascade.All();*/
            References(x => x.IznajmljenaNekretnina,"NEKRETNINAID").Nullable().Unique();
            //HasOne(x => x.IznajmljenaNekretnina).Constrained().ForeignKey().Cascade.All();

            /*References(x => x.UcestvovaoSaradnik)
                .Columns("MATBR_AGENTA", "TELEFON")
                .PropertyRef(x => x.UcestvovaoUNajam)
                .Column("NAJAMID");*/

           /* References(x => x.UcestvovaoSaradnik)
                .Columns("MATBR_AGENTA", "TELEFON")
                .PropertyRef(x=>x.UcestvovaoUNajam)
                .Column("NAJAMID");*/
        }
    }
}

//Spoljni saradnik -> najam
//(matbr_agenta,telefon) -> ID_NAJMA
//najamID