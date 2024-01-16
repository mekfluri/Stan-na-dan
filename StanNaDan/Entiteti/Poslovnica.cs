using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public class Poslovnica
    {
        public virtual int Id { get; set; }
        public virtual string adresa { get; set; }
        public virtual string radno_vreme { get; set; }
        public virtual int zbir_cena { get; set; }
        public virtual int provizija_agencije { get; set; }
       
        public virtual IList<Kvart> kvartovi { get; set; }
        public virtual IList<Najam> listaNajmova { get; set; }
        public virtual Agencija PripadaAgenciji { get; set; }
        public virtual IList<Zaposleni> zaposleni { get; set; }
    
        public Poslovnica()
        {
            kvartovi = new List<Kvart>();
            zaposleni = new List<Zaposleni>();
        }
    
    }
    
}
