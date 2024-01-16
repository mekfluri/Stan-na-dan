using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
   public class Stan:Nekretnina
    {
        public virtual int SPRAT { get; set; }
        public virtual Boolean LIFT { get; set; }
        public Stan()
        {

        }
    }
}
