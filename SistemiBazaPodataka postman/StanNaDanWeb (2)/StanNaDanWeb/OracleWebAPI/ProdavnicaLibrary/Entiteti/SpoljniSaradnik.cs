using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public class SpoljniSaradnik
    {
        public virtual SpoljniSaradnikID Id { get; set; }

        public virtual string Ime { get; set; }

        public virtual DateTime DatumAngazovanja { get; set; }

        public virtual double Procenat { get; set; }

        public virtual Najam UcestvovaoUNajam { get; set; }

        public SpoljniSaradnik()
        {
            Id = new SpoljniSaradnikID();
        }
    }
}
