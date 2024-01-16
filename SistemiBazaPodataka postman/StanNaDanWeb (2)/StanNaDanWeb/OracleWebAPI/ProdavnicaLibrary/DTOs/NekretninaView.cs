using StanNaDanv2;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class NekretninaView
    {
        public virtual AgencijaView agencija { get; set; }
        public virtual VlasnikView vlasnik { get; set; }
        public virtual KvartView kvart { get; set; }
        public virtual int kvartID { get; set; }
        public int nekretninaID { get; set; }
        public int kucnibroj { get; set; }
        public string ime_ulice { get; set; }
        public int povrsina { get; set; }
        public int broj_kupatila { get; set; }
        public int broj_terasa { get; set; }
        public int broj_spavacih_soba { get; set; }
        public bool internet { get; set; }
        public bool TV_PRIKLJUCAK { get; set; }
        public string TIP { get; set; }
        public bool FKuca { get; set; }
        public bool FStan { get; set; }


        public NekretninaView(int nekretninaID, int kucnibroj, string ime_ulice, int povrsina, int broj_kupatila,
       int broj_terasa, int broj_spavacih_soba, bool internet, bool TV_PRIKLJUCAK, string TIP, int kvartID, bool fkuca, bool fstan)
        {
            this.nekretninaID = nekretninaID;
            this.kucnibroj = kucnibroj;
            this.ime_ulice = ime_ulice;
            this.povrsina = povrsina;
            this.broj_kupatila = broj_kupatila;
            this.broj_terasa = broj_terasa;
            this.broj_spavacih_soba = broj_spavacih_soba;
            this.internet = internet;
            this.TV_PRIKLJUCAK = TV_PRIKLJUCAK;
            this.TIP = TIP;
            this.kvartID = kvartID;
            this.FStan = fstan;
            this.FKuca = fkuca;
        }
        public NekretninaView() { }

    }
}
