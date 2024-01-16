using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public class Agent : Zaposleni
    {
        public virtual string strucna_sprema{get;set;}

        public virtual IList<SpoljniSaradnik> spoljni_saradnik { get; set; }
        public virtual IList<Najam> ucestvovaoNajmovi { get; set; }
        public Agent() {
            spoljni_saradnik = new List<SpoljniSaradnik>();
            ucestvovaoNajmovi = new List<Najam>();
        }  


    }
}
