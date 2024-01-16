using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    internal class Krevet : Dodaci
    {
        public virtual string TipKreveta { get; set; }
        public virtual string Dimenzije { get; set; }
    }
}
