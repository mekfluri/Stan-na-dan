using StanNaDanv2;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class StanView : NekretninaView
    {
        public int SPRAT { get; set; }
        public Boolean LIFT { get; set; }
        public StanView() { }
        public StanView(int sPRAT, bool lIFT, int nekretninaID, int kucnibroj, string ime_ulice, int povrsina, int broj_kupatila,
       int broj_terasa, int broj_spavacih_soba, bool internet, bool TV_PRIKLJUCAK, string TIP, int kvartID, bool fkuca, bool fstan)
            : base(nekretninaID, kucnibroj, ime_ulice, povrsina, broj_kupatila, broj_terasa, broj_spavacih_soba, internet, TV_PRIKLJUCAK, TIP, kvartID, fkuca, fstan)
        {
            SPRAT = sPRAT;
            LIFT = lIFT;
        }
    }
}
