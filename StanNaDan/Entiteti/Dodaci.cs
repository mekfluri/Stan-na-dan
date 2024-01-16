using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public class Dodaci
    {
        public virtual int Id { get; protected set; }

        public virtual string TipDodatka { get; set; }

        public virtual Nekretnina nekretnina { get; set; }


        public Dodaci()
        {

        }

    }
}
