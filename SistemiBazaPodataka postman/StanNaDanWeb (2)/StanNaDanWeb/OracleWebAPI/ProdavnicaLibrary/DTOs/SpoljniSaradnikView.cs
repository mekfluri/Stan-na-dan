using StanNaDanv2.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class SpoljniSaradnikView
    {
        public SpoljniSaradnikID Id { get; set; }
        public string Ime { get; set; }
        public DateTime DatumAngazovanja { get; set; }
        public double Procenat { get; set; }

        public SpoljniSaradnikView(SpoljniSaradnikID Id, string ime, DateTime datumAngazovanja, double procenat)
        {
            this.Id = Id;
            Ime = ime;
            DatumAngazovanja = datumAngazovanja;
            Procenat = procenat;
        }

        public SpoljniSaradnikView()
        {
        }
    }
}
