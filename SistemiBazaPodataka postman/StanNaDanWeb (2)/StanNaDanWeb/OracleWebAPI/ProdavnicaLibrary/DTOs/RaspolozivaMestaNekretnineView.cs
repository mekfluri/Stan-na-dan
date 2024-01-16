using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class RaspolozivaMestaNekretnineView
    {
        public string raspoloziva_mesta { get; set; }
        public NekretninaView nekretnina { get; set; }
        public RaspolozivaMestaNekretnineView(string raspoloziva_mesta, NekretninaView nekretnina)
        {
            this.raspoloziva_mesta = raspoloziva_mesta;
            this.nekretnina = nekretnina;
        }
        public RaspolozivaMestaNekretnineView() { }
    }
}
