using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public class PravnoLice
    {
        public virtual int PIB { get; set; }
        public virtual string ime { get; set; }
        public virtual string adresa_firme { get; set; }
        public virtual string ime_kontakt_osobe { get; set; }
        public virtual string email { get; set; }

        public virtual Vlasnik vlasnik { get; set; }

        public virtual IList<BrojeviTelefonaPravnogLica> brojevi { get; set; }

        public PravnoLice()
        {
            brojevi = new List<BrojeviTelefonaPravnogLica>();
        }

    }
}
