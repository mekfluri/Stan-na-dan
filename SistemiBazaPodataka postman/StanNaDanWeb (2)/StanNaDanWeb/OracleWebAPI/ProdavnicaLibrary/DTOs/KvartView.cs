using StanNaDanv2;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class KvartView
    {
        public int kvartID { get; set; }
        public string gradska_zona { get; set; }
        public int broj_nekretnina { get; set; }
        public PoslovniceView poslovnica { get; set; }
        public IList<NekretninaView> nekretnine { get; set; }
        public KvartView(int kvartID, string gradska_zona, int broj_nekretnina, PoslovniceView poslovnica)
        {
            this.kvartID = kvartID;
            this.gradska_zona = gradska_zona;
            this.broj_nekretnina = broj_nekretnina;
            this.poslovnica = poslovnica;
            nekretnine = new List<NekretninaView>();

        }
        public KvartView() { }
    }
}
