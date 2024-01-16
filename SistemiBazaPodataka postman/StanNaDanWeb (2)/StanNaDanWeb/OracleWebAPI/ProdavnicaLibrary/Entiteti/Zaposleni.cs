using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{ 

    public  class Zaposleni
    {

        public virtual string maticni_broj_zaposlenog{get; set;}
        public virtual string ime { get; set; }
       
        public virtual DateTime datum_zaposlenja { get; set; }
        public virtual bool FSef { get; set; }
        public virtual bool FAgent { get; set; }
 
        public virtual Poslovnica Poslovnica { get; set; }
        public virtual Agencija agencija { get; set; }

        public Zaposleni() { }
        
    }
}
