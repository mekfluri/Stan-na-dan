using StanNaDanv2.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class KrevetView
    {
        public int KrevetId { get; set; }
        public string TipDodatka { get; set; }
        public string TipKreveta { get; set; }

        public string DimenzijeKreveta { get; set; }

        public NekretninaView nekretnina { get; set; }

        public KrevetView(int id, string tipKreveta, string tipDodatka, string dim)
        {
            KrevetId = id;
            TipKreveta = tipKreveta;
            TipDodatka = tipDodatka;
            DimenzijeKreveta = dim;
        }

        public KrevetView()
        {
        }
    }
}
