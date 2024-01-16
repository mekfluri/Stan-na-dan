using StanNaDanv2.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class KuhinjaView
    {
        public int KuhinjaId { get; set; }
        public bool Posudje { get; set; }
        public string TipDodatka;
        public NekretninaView nekretnina { get; set; }

        public KuhinjaView(int id, string tipDodatka, bool posudje)
        {
            KuhinjaId = id;
            Posudje = posudje;
            TipDodatka = tipDodatka;
        }

        public KuhinjaView()
        {
        }
    }
}
