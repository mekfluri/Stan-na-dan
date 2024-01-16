using StanNaDanv2;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class SefView : ZaposleniView
    {
        public DateTime datum_postavljanja { get; set; }
        public SefView() { }
        public SefView(DateTime datum_postavljanja, string maticni_broj, string ime, bool isSef, bool isAgent, DateTime datum_zaposlenja, PoslovniceView poslovnica, AgencijaView agencija)
            : base(maticni_broj, ime, isSef, isAgent, datum_zaposlenja, poslovnica, agencija)
        {
            this.datum_postavljanja = datum_postavljanja;
        }
    }
}
