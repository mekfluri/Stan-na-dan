using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public class Kvart
    {
        public virtual int kvartID{get;protected set;}
        public virtual string gradska_zona { get; set; }
       
        public virtual int broj_nekretnina { get; set; }
        public virtual IList<Nekretnina> nekretnine { get; set; }
        public virtual Poslovnica poslovnica { get; set; }
        public Kvart() {
           nekretnine=new List<Nekretnina>();
        }
    }
}
