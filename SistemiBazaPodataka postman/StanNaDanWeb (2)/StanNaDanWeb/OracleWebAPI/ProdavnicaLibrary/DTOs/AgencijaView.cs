using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class AgencijaView
    {
        public int AgencijaID { get; set; }
        public string naziv { get; set; }

        public virtual IList<PoslovniceView> Poslovnice { get; set; }

        public AgencijaView(int agID, string naziv)
        {
            this.AgencijaID = agID;
            this.naziv = naziv;
            Poslovnice = new List<PoslovniceView>();

        }
        public AgencijaView()
        {

        }
    }
}
