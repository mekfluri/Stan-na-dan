using StanNaDanv2.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class ParkingMestoView
    {
        public int ParkingMestoId { get; set; }
        public string TipDodatka { get; set; }
        public string Lokacija { get; set; }
        public double CenaParkingMesta { get; set; }
        public NekretninaView nekretnina { get; set; }

        public ParkingMestoView(int parkingMestoId, string tipDodatka, string lokacija, double cenaParkingMesta)
        {
            ParkingMestoId = parkingMestoId;
            TipDodatka = tipDodatka;
            Lokacija = lokacija;
            CenaParkingMesta = cenaParkingMesta;
        }

        public ParkingMestoView()
        {
        }
    }
}
