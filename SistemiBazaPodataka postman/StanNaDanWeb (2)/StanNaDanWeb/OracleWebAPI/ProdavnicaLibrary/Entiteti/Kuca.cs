using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public class Kuca : Nekretnina
    {
        public virtual int SPRATNOST { get; set; }

        public virtual Boolean DVORISTE { get; set; }
        public Kuca()
        {

        }
    }
}
