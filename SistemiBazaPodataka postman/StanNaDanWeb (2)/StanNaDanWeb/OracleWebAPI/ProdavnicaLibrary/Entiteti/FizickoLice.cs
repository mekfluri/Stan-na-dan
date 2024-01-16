using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public class FizickoLice
    {
        public virtual int maticni_broj { get; set; }
        public virtual  string ime { get; set; }
        public virtual string ime_roditelja { get; set; }
        public virtual string prezime { get; set; }
        public virtual string  drzava { get; set; }
        public virtual string  mesto { get; set; }
        public virtual string adresa { get; set; }
        public virtual DateTime datum_rodjenja { get; set; }
        public virtual string email { get; set; }
        public virtual Vlasnik vlasnik { get; set; }

        public virtual IList<BrojeviTelefonaFizickogLica> brojevi { get; set; }

        public FizickoLice()
        {
            brojevi = new List<BrojeviTelefonaFizickogLica>();
        }
    }
}
