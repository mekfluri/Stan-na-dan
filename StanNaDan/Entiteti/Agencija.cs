using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public class Agencija
    {
        public virtual int Id { get;  set; }
        public virtual string naziv { get; set; }

        public virtual IList<Poslovnica> poslovnice { get; set; }
        public virtual IList<Najam> najmovi { get; set; }
        public virtual IList<Vlasnik> vlasnikAgencije { get; set; }

        public virtual IList<Nekretnina> nekretnine { get; set; }

        public virtual IList<Zaposleni> zaposleni { get; set; }

        public Agencija()
        {
            poslovnice = new List<Poslovnica>();
            najmovi = new List<Najam>();
            nekretnine=new List<Nekretnina>();
            vlasnikAgencije=new List<Vlasnik>();
            zaposleni = new List<Zaposleni>();
        }
    }
}
