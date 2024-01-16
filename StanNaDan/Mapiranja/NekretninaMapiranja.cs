using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Mapiranja
{
    internal class NekretninaMapiranja:ClassMap<StanNaDanv2.Entiteti.Nekretnina>
    {
        public NekretninaMapiranja()
        {
          
            Table("NEKRETNINA");
            try
            {
                DiscriminateSubClassesOnColumn("").Formula("CASE WHEN (FStan = 1 AND FKuca = 0) " +
                    "THEN  'stan' WHEN (FStan = 0 AND FKuca = 1) " +
                    "THEN 'kuca' ELSE 'Nepoznato' END");
            Id(x => x.nekretninaID,"ID_NEKRETNINE").GeneratedBy.Increment() ;
       
            Map(x => x.povrsina).Column("POVRSINA");

            Map(x => x.broj_spavacih_soba).Column("BROJ_SPAVACIH_SOBA");

            Map(x => x.broj_kupatila).Column("BROJ_KUPATILA");

            Map(x => x.kucnibroj).Column("KUCNI_BROJ");

            Map(x => x.ime_ulice).Column("IME_ULICE");

            Map(x => x.broj_terasa).Column("BROJ_TERASA");

            Map(x => x.TV_PRIKLJUCAK).Column("TV_PRIKLJUCAK");

            Map(x => x.internet).Column("INTERNET");
            Map(x => x.FKuca).Column("FKUCA");

            Map(x => x.FStan).Column("FSTAN");

                // Map(x => x.TIP).Column("TIP");
            References(x => x.kvart).Column("KVARTID").LazyLoad();
            References(x => x.vlasnik).Column("VLASNIKID").LazyLoad();
            References(x => x.agencija).Column("AGENCIJAID").LazyLoad();

            //References(x => x.iznajmljenaUNajmu, "NEKRETNINAID").Nullable().Cascade.All();
                //References(x=>x.iznajmljenaUNajmu).Column("NEKRETNINAID").Nullable();
            HasOne(x => x.iznajmljenaUNajmu)
                   .Constrained()
                   .ForeignKey();

            /*HasOne(x => x.iznajmljenaUNajmu)
                .PropertyRef(x => x.IznajmljenaNekretnina)
                .Cascade.All()
                .ForeignKey("NEKRETNINAID");*/

                HasMany(x => x.dodaci).KeyColumn("NEKRETNINAID").LazyLoad().Cascade.All().Inverse();


        }
            
                catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show($"An error occurred: {ec.Message}\n\nStack Trace:\n{ec.StackTrace}");
             
            }

        }




}
    }

