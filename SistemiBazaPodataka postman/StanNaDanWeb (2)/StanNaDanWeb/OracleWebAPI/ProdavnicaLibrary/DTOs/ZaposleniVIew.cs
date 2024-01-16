using StanNaDanv2;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class ZaposleniView
    {
        public string maticni_broj_zaposlenog { get; set; }
        public string ime { get; set; }
        public bool FSef { get; set; }
        public bool FAgent { get; set; }

        public DateTime datum_zaposlenja { get; set; }

        public PoslovniceView Poslovnica { get; set; }
        public AgencijaView Agencija { get; set; }
        public ZaposleniView()
        {

        }
        public ZaposleniView(string maticni_broj, string ime, bool isSef, bool isAgent, DateTime datum_zaposlenja, PoslovniceView poslovnica, AgencijaView agencija)
        {
            this.maticni_broj_zaposlenog = maticni_broj;
            this.ime = ime;
            this.FSef = isSef;
            this.FAgent = isAgent;
            this.datum_zaposlenja = datum_zaposlenja;
            this.Poslovnica = poslovnica;
            this.Agencija = agencija;
        }

    }
}
