using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public class Najam
    {
        public virtual int Id { get; protected set; }

        public virtual DateTime DatumZavrsetka { get; set; }

        public virtual DateTime DatumPocetka { get; set; }

        public virtual double CenaPoDanu { get; set; }

        public virtual int BrojDana { get; set; }

        public virtual double UkupnaCena { get; set; }

        public virtual double Popust { get; set; }

        public virtual double CenaSaPopustom { get; set; }

        public virtual double ZaradaOdDrugihUsluga { get; set; }

        public virtual Nekretnina IznajmljenaNekretnina { get; set; }
        public virtual Agent UcestvovaoAgent { get; set; }
        public virtual Agencija OrganizujeAgencija { get; set; }
        public virtual Poslovnica OrganizujePoslovnica { get; set; }
        public virtual SpoljniSaradnik UcestvovaoSaradnik { get; set; }
        public virtual double ZbirCena { get; set; }

        public virtual double ProvizijaAgencije { get; set; }
    }
}
