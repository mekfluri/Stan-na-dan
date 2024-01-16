using StanNaDanv2.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class NajamView
    {
        public int NajamId { get; set; }

        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }

        public double CenaPoDanu { get; set; }
        public int BrojDana { get; set; }

        public double UkupnaCena { get; set; }

        public double Popust { get; set; }
        public double CenaSaPopustom { get; set; }

        public AgentView Agent { get; set; }
        public AgencijaView Agencija { get; set; }
        public NekretninaView IznajmljenaNekretnina { get; set; }
        public PoslovniceView IznajmilaPoslovnica { get; set; }

        public NajamView(int najamId, DateTime datumPocetka, DateTime datumZavrsetka, double cenaPoDanu, int brojDana, double ukupnaCena, double popust, double cenaSaPopustom)
        {
            NajamId = najamId;
            DatumPocetka = datumPocetka;
            DatumZavrsetka = datumZavrsetka;
            CenaPoDanu = cenaPoDanu;
            BrojDana = brojDana;
            UkupnaCena = ukupnaCena;
            Popust = popust;
            CenaSaPopustom = cenaSaPopustom;
        }

        public NajamView()
        {
        }
    }
}
