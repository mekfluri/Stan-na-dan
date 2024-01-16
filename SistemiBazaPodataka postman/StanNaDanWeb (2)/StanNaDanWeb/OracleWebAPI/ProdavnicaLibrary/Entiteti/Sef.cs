using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
   public class Sef:Zaposleni
    {
        public virtual DateTime datum_postavljanja { get; set; }
        public Sef() { }
    }
}
