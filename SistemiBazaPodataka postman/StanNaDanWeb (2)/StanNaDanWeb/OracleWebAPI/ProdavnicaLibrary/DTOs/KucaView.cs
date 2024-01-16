using StanNaDanv2;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class KucaView : NekretninaView
    {
        public int SPRATNOST { get; set; }
        public Boolean DVORISTE { get; set; }
        public KucaView(int sPRATNOST, bool dVORISTE, int nekretninaID, int kucnibroj, string ime_ulice, int povrsina, int broj_kupatila,
       int broj_terasa, int broj_spavacih_soba, bool internet, bool TV_PRIKLJUCAK, string TIP, int kvartID, bool fkuca, bool fstan
   )
            : base(nekretninaID, kucnibroj, ime_ulice, povrsina, broj_kupatila, broj_terasa, broj_spavacih_soba, internet, TV_PRIKLJUCAK, TIP, kvartID, fkuca, fstan)
        {
            SPRATNOST = sPRATNOST;
            DVORISTE = dVORISTE;
        }
        public KucaView() { }
    }
}
