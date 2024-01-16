using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    internal class DodatnaOprema : Dodaci
    {
        public virtual string TipDodatneOpreme { get; set; }
        public virtual double Doplata { get; set; }

    }
}
