using StanNaDanv2.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class DodaciView
    {
        public int DodaciId { get; set; }
        public string TipDodatka { get; set; }

        public int nekretninaID{ get; set; }
        public string tipNekretnine { get; set; }
        public DodaciView(int dodaciId, string tipDodatka, int nekretninaID, string tipNekretnine)
        {
            DodaciId = dodaciId;
            TipDodatka = tipDodatka;
            this.nekretninaID = nekretninaID;
            this.tipNekretnine = tipNekretnine;
        }

        public DodaciView()
        {
        }
    }
}
