using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class FizickoLiceView
    {
        public int maticni_broj { get; set; }
        public string ime { get; set; }
        public string ime_roditelja { get; set; }
        public string prezime { get; set; }
        public string drzava { get; set; }
        public string mesto { get; set; }
        public virtual string adresa { get; set; }
        public virtual DateTime datum_rodjenja { get; set; }
        public virtual string email { get; set; }
        public virtual VlasnikView vlasnik { get; set; }

        public virtual IList<BrojeviTelefonaFizickogLicaView> brojevi { get; set; }
        public FizickoLiceView(int mat_br, string ime, string ime_rod, string prezime, string drzava, string mesto, string adresa, DateTime datum_rodjenja, string email)
        {
            this.maticni_broj = mat_br;
            this.ime = ime;
            this.ime_roditelja = ime_rod;
            this.prezime = prezime;
            this.drzava = drzava;
            this.mesto = mesto;
            this.adresa = adresa;
            this.datum_rodjenja = datum_rodjenja;
            this.email = email;
            brojevi = new List<BrojeviTelefonaFizickogLicaView>();
        }

        public FizickoLiceView()
        {

        }
    }
}
