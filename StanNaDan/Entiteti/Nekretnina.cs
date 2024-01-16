using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public abstract class Nekretnina
    {
        public virtual int nekretninaID { get; protected set; }
        public virtual int kucnibroj { get; set; }
        public virtual string ime_ulice { get; set; }
        public virtual int povrsina { get; set; }
        public virtual int broj_kupatila { get; set; }
        public virtual int broj_terasa { get; set; }
        public virtual int broj_spavacih_soba { get; set; }
        public virtual bool internet { get; set; }
        public virtual bool TV_PRIKLJUCAK { get; set; }
        public virtual int kvartID { get; set; }
        public virtual Kvart kvart { get; set; }
        public virtual Vlasnik vlasnik { get; set; }
        public virtual Agencija agencija { get; set; }
        public virtual Najam iznajmljenaUNajmu { get; set; }
        public virtual IList<Dodaci> dodaci { get; set; }

        public virtual bool FStan{get;set;}
        public virtual bool FKuca { get; set; }
 
        public virtual IList<Sajt> sajtovi { get; set; }
        public virtual IList<RaspolozivaMesta> raspoloziva_mesta{ get; set; }
        // public virtual IList<SajtNekretnine> sajtovi{ get; set; }


        public Nekretnina() {
            dodaci = new List<Dodaci>();
            sajtovi = new List<Sajt>();
            raspoloziva_mesta=new List<RaspolozivaMesta>();
        }
    }
}
