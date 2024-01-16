using StanNaDanv2.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class DodatnaOpremaView
    {
        public int DodatnaOpremaId { get; set; }
        public string TipDodatka { get; set; }
        public string TipDodatneOpreme { get; set; }
        public double Doplata { get; set; }

        public NekretninaView nekretnina { get; set; }

        public DodatnaOpremaView(int id, string tip, double dopl)
        {
            DodatnaOpremaId = id;
            TipDodatneOpreme = tip;
            Doplata = dopl;
        }

        public DodatnaOpremaView()
        {
        }
    }
}
