using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public class Vlasnik
    {
        public virtual int Id { get; protected set; }
        public virtual string  broj_bankovnog_racuna { get; set; }
        public virtual string banka { get; set; }

        public virtual Agencija agencija { get; set; }

        public virtual PravnoLice pravnolice { get; set;  }
        public virtual FizickoLice fizickolice { get; set; }
            
        public virtual IList<Nekretnina> nekretnine { get; set; }
        

        public Vlasnik()
        {
            nekretnine = new List<Nekretnina>();
        }

    }
}
