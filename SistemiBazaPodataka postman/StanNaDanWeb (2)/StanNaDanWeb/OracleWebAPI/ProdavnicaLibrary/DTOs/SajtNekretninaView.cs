using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class SajtNekretninaView
    {
        public string sajt { get; set; }
        public NekretninaView Nekretnina { get; set; }
        public SajtNekretninaView(string sajt, NekretninaView nekretnina)
        {
            this.sajt = sajt;
            this.Nekretnina = nekretnina;
        }
        public SajtNekretninaView() { }
    }
}
