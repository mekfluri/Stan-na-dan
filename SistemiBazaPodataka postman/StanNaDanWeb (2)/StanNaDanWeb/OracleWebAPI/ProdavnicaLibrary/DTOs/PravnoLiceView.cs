using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class PravnoLiceView
    {
        public int PIB { get; set; }
        public string ime { get; set; }
        public string adresa_firme { get; set; }
        public string ime_kontakt_osobe { get; set; }
        public string email { get; set; }
        public virtual VlasnikView vlasnikje { get; set; }
        public virtual IList<BrojeviTelefonaPravnogLicaView> brojevi { get; set; }




        public PravnoLiceView(int PIB, string ime, string adresa_firme, string imeKonOs, string email)
        {
            this.PIB = PIB;
            this.ime = ime;
            this.adresa_firme = adresa_firme;
            this.ime_kontakt_osobe = imeKonOs;
            this.email = email;
            brojevi = new List<BrojeviTelefonaPravnogLicaView>();

        }

        public PravnoLiceView()
        {
        }
    }
}
