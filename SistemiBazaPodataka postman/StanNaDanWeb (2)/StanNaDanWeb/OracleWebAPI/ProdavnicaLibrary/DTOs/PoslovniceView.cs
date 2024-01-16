using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class PoslovniceView
    {
        public int PoslovnicaID { get; set; }
        public string adresa { get; set; }
        public string radno_vreme { get; set; }
        public virtual AgencijaView pripadaAgenciji { get; set; }

        public PoslovniceView(int poID, string adresa, string radno_vreme)
        {
            this.PoslovnicaID = poID;
            this.adresa = adresa;
            this.radno_vreme = radno_vreme;
        }

        public PoslovniceView()
        {

        }

    }
}
