using StanNaDanv2.Entiteti;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace StanNaDanv2
{
    #region Zaposleni
    public class ZaposleniBasic
    {
        public string maticni_broj_zaposlenog { get; set; }
        public string ime { get; set; }
        public bool FSef { get; set; }
        public bool FAgent { get; set; }

        public DateTime datum_zaposlenja { get; set; }

        public PoslovnicaBasic Poslovnica { get; set; }
        public AgencijaBasic Agencija { get; set; }
        public ZaposleniBasic()
        {

        }
        public ZaposleniBasic(string maticni_broj, string ime, bool isSef, bool isAgent, DateTime datum_zaposlenja, PoslovnicaBasic poslovnica, AgencijaBasic agencija)
        {
            this.maticni_broj_zaposlenog = maticni_broj;
            this.ime = ime;
            this.FSef = isSef;
            this.FAgent = isAgent;
            this.datum_zaposlenja = datum_zaposlenja;
            this.Poslovnica = poslovnica;
            this.Agencija = agencija;
        }

    }

    public class SefBasic : ZaposleniBasic
    {
        public DateTime datum_postavljanja { get; set; }
        public SefBasic() { }
        public SefBasic(DateTime datum_postavljanja, string maticni_broj, string ime, bool isSef, bool isAgent, DateTime datum_zaposlenja, PoslovnicaBasic poslovnica, AgencijaBasic agencija)
            : base(maticni_broj, ime, isSef, isAgent, datum_zaposlenja, poslovnica, agencija) {
            this.datum_postavljanja = datum_postavljanja;
        }
    }
    public class SamoZaposleniBasic : ZaposleniBasic
    {
    
        public SamoZaposleniBasic() { }
        public SamoZaposleniBasic( string maticni_broj, string ime, bool isSef, bool isAgent, DateTime datum_zaposlenja, PoslovnicaBasic poslovnica, AgencijaBasic agencija)
            : base(maticni_broj, ime, isSef, isAgent, datum_zaposlenja, poslovnica, agencija)
        {
          
        }
    }
    public class AgentBasic : ZaposleniBasic
    {
        public string strucna_sprema { get; set; }
        public AgentBasic() { }
        public AgentBasic(string strucna_sprema, DateTime datum_postavljanja, string maticni_broj, string ime, bool isSef, bool isAgent, DateTime datum_zaposlenja, PoslovnicaBasic poslovnica, AgencijaBasic agencija)
            : base(maticni_broj, ime, isSef, isAgent, datum_zaposlenja, poslovnica, agencija) {
            this.strucna_sprema = strucna_sprema;
        }
    }
    public class ZaposleniPregled
    {
        public string maticni_broj { get; set; }
        public string ime { get; set; }
        public DateTime datum_zaposlenja { get; set; }
        public bool FAgent { get; set; }

        public bool FSef { get; set; }


        public ZaposleniPregled(string maticni_broj, string ime, DateTime datum_zaposlenja, bool fAgent, bool fSef)
        {
            this.maticni_broj = maticni_broj;
            this.ime = ime;
            this.datum_zaposlenja = datum_zaposlenja;
            FAgent = fAgent;

            FSef = fSef;

        }
        public ZaposleniPregled() { }
    }
    public class SefPregled : ZaposleniPregled
    {
        public DateTime datum_postavljanja { get; set; }
        public SefPregled(DateTime datum_postavljanja, string maticni_broj, string ime, DateTime datum_zaposlenja, bool fAgent, bool fSef) : base(maticni_broj, ime, datum_zaposlenja, fAgent, fSef)
        {
            this.datum_postavljanja = datum_postavljanja;
        }
        public SefPregled() { }
    }
    public class SamoZaposleniPregled : ZaposleniPregled
    {
    
        public SamoZaposleniPregled(string maticni_broj, string ime, DateTime datum_zaposlenja, bool fAgent, bool fSef) : base(maticni_broj, ime, datum_zaposlenja, fAgent, fSef)
        {
          
        }
        public SamoZaposleniPregled() { }
    }
    public class AgentPregled : ZaposleniPregled
    {
        public string strucna_sprema { get; set; }
        public AgentPregled(string s, string maticni_broj, string ime, DateTime datum_zaposlenja, bool fAgent, bool fSef) : base(maticni_broj, ime, datum_zaposlenja, fAgent, fSef)
        {
            this.strucna_sprema = s;
        }
        public AgentPregled() { }
    }
    #endregion
    #region Nekretnina
    public class NekretninaBasic
    {
        public virtual AgencijaBasic agencija { get; set; }
        public virtual VlasnikBasic vlasnik { get; set; }
        public virtual KvartBasic kvart { get; set; }
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


        public NekretninaBasic(int nekretninaID, int kucnibroj, string ime_ulice, int povrsina, int broj_kupatila,
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
        public NekretninaBasic() { }

    }

    public class KucaBasic : NekretninaBasic
    {
        public int SPRATNOST { get; set; }
        public Boolean DVORISTE { get; set; }
        public KucaBasic(int sPRATNOST, bool dVORISTE, int nekretninaID, int kucnibroj, string ime_ulice, int povrsina, int broj_kupatila,
       int broj_terasa, int broj_spavacih_soba, bool internet, bool TV_PRIKLJUCAK, string TIP, int kvartID, bool fkuca, bool fstan
   )
            : base(nekretninaID, kucnibroj, ime_ulice, povrsina, broj_kupatila, broj_terasa, broj_spavacih_soba, internet, TV_PRIKLJUCAK, TIP, kvartID, fkuca, fstan)
        {
            SPRATNOST = sPRATNOST;
            DVORISTE = dVORISTE;
        }
        public KucaBasic() { }
    }
    public class NekretninaPregled
    {
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
        public virtual bool FKuca{get;set ;}
    public virtual bool FStan{get;set;}
      
 
        public NekretninaPregled(int nekretninaID, int kucnibroj, string ime_ulice, int povrsina, int broj_kupatila,
       int broj_terasa, int broj_spavacih_soba, bool internet, bool TV_PRIKLJUCAK, string TIP, bool fkuca, bool fstan)
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
            this.FKuca = fkuca;
            this.FStan = fstan;

        }
        public NekretninaPregled() { }


    }
    public class KucaPregled:NekretninaPregled
        {
        public int SPRATNOST { get; set; }
        public Boolean DVORISTE { get; set; }
        public KucaPregled(int sPRATNOST, bool dVORISTE, int nekretninaID, int kucnibroj, string ime_ulice, int povrsina, int broj_kupatila,
       int broj_terasa, int broj_spavacih_soba, bool internet, bool TV_PRIKLJUCAK, string TIP, bool fkuca, bool fstan
   )
            : base(nekretninaID, kucnibroj, ime_ulice, povrsina, broj_kupatila, broj_terasa, broj_spavacih_soba, internet, TV_PRIKLJUCAK, TIP, fkuca,fstan)
        {
            SPRATNOST = sPRATNOST;
            DVORISTE = dVORISTE;
        }
        public KucaPregled() { }
    }
    public class StanBasic : NekretninaBasic
    {
        public int SPRAT { get; set; }
        public Boolean LIFT { get; set; }
        public StanBasic() { }
        public StanBasic(int sPRAT, bool lIFT, int nekretninaID, int kucnibroj, string ime_ulice, int povrsina, int broj_kupatila,
       int broj_terasa, int broj_spavacih_soba, bool internet, bool TV_PRIKLJUCAK, string TIP,int kvartID, bool fkuca, bool fstan)
            : base(nekretninaID, kucnibroj, ime_ulice, povrsina, broj_kupatila, broj_terasa, broj_spavacih_soba, internet, TV_PRIKLJUCAK, TIP,kvartID,fkuca,fstan)
        {
            SPRAT = sPRAT;
            LIFT = lIFT;
        }
    }
    public class StanPregled : NekretninaPregled
    {
        public int SPRAT { get; set; }
        public Boolean LIFT { get; set; }
        public StanPregled(int s, Boolean l, int nekretninaID, int kucnibroj, string ime_ulice, int povrsina, int broj_kupatila,
       int broj_terasa, int broj_spavacih_soba, bool internet, bool TV_PRIKLJUCAK, string TIP, bool fkuca, bool fstan
   )
            : base(nekretninaID, kucnibroj, ime_ulice, povrsina, broj_kupatila, broj_terasa, broj_spavacih_soba, internet, TV_PRIKLJUCAK, TIP,fkuca,fstan)
        {
            SPRAT = s;
            LIFT = l;
        }
    }
        #endregion
        #region Kvart
        public class KvartBasic
    {
        public int kvartID { get;  set; }
        public string gradska_zona { get; set; }
        public int broj_nekretnina { get; set; }
        public  PoslovnicaBasic poslovnica { get; set; }
        public  IList<NekretninaBasic> nekretnine { get; set; }
        public KvartBasic(int kvartID, string gradska_zona,  int broj_nekretnina, PoslovnicaBasic poslovnica)
        {
            this.kvartID = kvartID;
            this.gradska_zona = gradska_zona;
            this.broj_nekretnina = broj_nekretnina;
            this.poslovnica = poslovnica;
            nekretnine = new List<NekretninaBasic>();
          
        }
        public KvartBasic() { }
    }
    public class KvartPregled
    {
        public int kvartID { get;  set; }
        public string gradska_zona { get; set; }
        public int broj_nekretnina { get; set; }
        public KvartPregled(int kvartID, string gradska_zona, int broj_nekretnina)
        {
            this.kvartID = kvartID;
            this.gradska_zona = gradska_zona;
            this.broj_nekretnina = broj_nekretnina;
        }
        public KvartPregled() { }
    }

    #endregion




    #region Sajt
    public class SajtNekretnineBasic
    {
        public string sajt { get; set; }
        public NekretninaBasic nekretnina { get; set; }
        public SajtNekretnineBasic(string sajt, NekretninaBasic nekretnina)
        {
            this.sajt = sajt;
            this.nekretnina = nekretnina;
        }
        public SajtNekretnineBasic() { }
    }
    public class RaspolozivaMestaNekretnineBasic
    {
        public string raspoloziva_mesta { get; set; }
        public NekretninaBasic nekretnina { get; set; }
        public RaspolozivaMestaNekretnineBasic(string raspoloziva_mesta, NekretninaBasic nekretnina)
        {
            this.raspoloziva_mesta = raspoloziva_mesta;
            this.nekretnina = nekretnina;
        }
        public RaspolozivaMestaNekretnineBasic() { }
    }







    public class SajtPregled
    {
        public SajtNekretnine sajtID { get; set; }
        public SajtPregled(SajtNekretnine sajt)
        {
            this.sajtID = sajt;
        }

        public SajtPregled() { }
    }

    public class SajtBasic : SajtPregled
    {
        public SajtBasic(SajtNekretnine sajt) : base(sajt)
        {

        }

        public SajtBasic() : base()
        {

        }


    }

    public class RaspolozivaMestaPregled
    {
        public RaspolozivaMestaNekretnine id { get; set; }
        public RaspolozivaMestaPregled(RaspolozivaMestaNekretnine id)
        {
            this.id = id;
        }

        public RaspolozivaMestaPregled()
        {

        }
    }
    public class RaspolozivaMestaBasic : RaspolozivaMestaPregled
    {
        public RaspolozivaMestaBasic(RaspolozivaMestaNekretnine r) : base(r)
        {

        }

        public RaspolozivaMestaBasic() : base()
        {

        }

    }
#endregion

    #region Agencija
    public class AgencijaPregled
    {
        public int AgencijaID { get; set; }
        public string naziv { get; set; }

        public AgencijaPregled(int agID, string naziv)
        {
            this.AgencijaID = agID;
            this.naziv = naziv;
        }
        public AgencijaPregled()
        {

        }


    }

    public class AgencijaBasic : AgencijaPregled
    {
        public virtual IList<PoslovnicaBasic> Poslovnice { get; set; }
       
        public AgencijaBasic(int agID, string naziv) : base(agID, naziv)
        {
            Poslovnice = new List<PoslovnicaBasic>();
          

        }

        public AgencijaBasic() : base()
        {

        }
    }

    #endregion Agencija

    #region Poslovnica 

    public class PoslovnicaPregled
    {
        public int PoslovnicaID { get; set; }
        public string adresa { get; set; }
        public string radno_vreme { get; set; }

        public PoslovnicaPregled(int poID, string adresa, string radno_vreme)
        {
            this.PoslovnicaID = poID;
            this.adresa = adresa;
            this.radno_vreme = radno_vreme;
        }

        public PoslovnicaPregled()
        {

        }

    }
    public class PoslovnicaBasic : PoslovnicaPregled
    {
        public virtual AgencijaBasic pripadaAgenciji { get; set; }

        public PoslovnicaBasic(int poID, string adresa, string radno_vreme) : base(poID, adresa, radno_vreme)
        {

        }

        public PoslovnicaBasic() : base()
        {

        }





    }


    #endregion

    #region VLasnik

    public class VlasnikPregled
    {
        public int VlasnikID { get; set; }
        public string broj_bankovnog_racuna { get; set; }
        public string banka { get; set; }

        public VlasnikPregled(int vlID, string brrac, string banka)
        {
            this.VlasnikID = vlID;
            this.broj_bankovnog_racuna = brrac;
            this.banka = banka;
        }

        public VlasnikPregled()
        {

        }
    }

    public class VlasnikBasic : VlasnikPregled
    {

        public virtual PravnoLiceBasic PravnoL { get; set; }
        public virtual FizickoLiceBasic FizickoL { get; set; }
        public virtual AgencijaBasic AgencijaB { get; set; }

        public VlasnikBasic(int vlID, string brrac, string banka) : base(vlID, brrac, banka)
        {

        }

        public VlasnikBasic() : base()
        {

        }
    }

    #endregion Vlasnik

    #region PravnoLice 

    public class PravnoLicePregled
    {
        public int PIB { get; set; }
        public string ime { get; set; }
        public string adresa_firme { get; set; }
        public string ime_kontakt_osobe { get; set; }
        public string email { get; set; }





        public PravnoLicePregled(int PIB, string ime, string adresa_firme, string imeKonOs, string email)
        {
            this.PIB = PIB;
            this.ime = ime;
            this.adresa_firme = adresa_firme;
            this.ime_kontakt_osobe = imeKonOs;
            this.email = email;

        }

        public PravnoLicePregled()
        {
        }



    }
    public class PravnoLiceBasic : PravnoLicePregled
    {
        public virtual VlasnikBasic vlasnikje { get; set; }
        public virtual IList<BrojeviTelefonaPravnogLicaBasic> brojevi { get; set; }

        public PravnoLiceBasic(int PIB, string ime, string adresa_firme, string imeKonOs, string email) : base(PIB, ime, adresa_firme, imeKonOs, email)
        {
            brojevi = new List<BrojeviTelefonaPravnogLicaBasic>();
        }

        public PravnoLiceBasic() : base()
        {

        }

    }


    #endregion

    #region FizickoLice
    public class FizickoLicePregled
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

        public FizickoLicePregled(int mat_br, string ime, string ime_rod, string prezime, string drzava, string mesto, string adresa, DateTime datum_rodjenja, string email)
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
        }

        public FizickoLicePregled()
        {

        }
    }

    public class FizickoLiceBasic : FizickoLicePregled
    {
        public virtual VlasnikBasic vlasnik { get; set; }

        public virtual IList<BrojeviTelefonaFizickogLicaBasic> brojevi { get; set; }
        public FizickoLiceBasic(int mat_br, string ime, string ime_rod, string prezime, string drzava, string mesto, string adresa, DateTime datum_rodjenja, string email)
                  : base(mat_br, ime, ime_rod, prezime, drzava, mesto, adresa, datum_rodjenja, email)
        {
            brojevi = new List<BrojeviTelefonaFizickogLicaBasic>();
        }

        public FizickoLiceBasic() : base()
        {

        }
    }

    #endregion

    #region BrojeviTelefonaFizickogLica 

    public class BrojeviTelefonaFizickogLicaPregled
    {
        public IDBrTelFL IDbroja { get; set; }

        public BrojeviTelefonaFizickogLicaPregled(IDBrTelFL id)
        {
            this.IDbroja = id;
        }
        public BrojeviTelefonaFizickogLicaPregled()
        {

        }
    }

    public class BrojeviTelefonaFizickogLicaBasic : BrojeviTelefonaFizickogLicaPregled
    {
        public BrojeviTelefonaFizickogLicaBasic(IDBrTelFL id) : base(id)
        {

        }

        public BrojeviTelefonaFizickogLicaBasic() : base()
        {

        }
    }

    public class IDBrTelFLBasic
    {
        public virtual FizickoLiceBasic fizickolicebroj { get; set; }
        public virtual int broj_telefona { get; set; }

        public IDBrTelFLBasic(int broj_telefona)
        {
            this.broj_telefona = broj_telefona;
        }
    }


    #endregion

    #region IDBrTelFl
    public class IDBrTelFlPregeld
    {
        public int brojtelefona { get; set; }

        public IDBrTelFlPregeld()
        {


        }

        public IDBrTelFlPregeld(int brojtel)
        {
            this.brojtelefona = brojtel;
        }

    }

    public class IDBrTelFlBasic : IDBrTelFlPregeld
    {
        public int brojtelefona { get; set; }
        public FizickoLice fizlice { get; set; }

        public IDBrTelFlBasic() : base()
        {

        }

        public IDBrTelFlBasic(int brojtelefona) : base(brojtelefona)
        {

        }
    }




    #endregion

    #region BrojeviTelefonaPravnogLica

    public class BrojeviTelefonaPravnogLicaPregled
    {
        public IDBrTelPL IDbroja { get; set; }

        public BrojeviTelefonaPravnogLicaPregled(IDBrTelPL id)
        {
            this.IDbroja = id;
        }

        public BrojeviTelefonaPravnogLicaPregled()
        {
        }



    }

    public class BrojeviTelefonaPravnogLicaBasic : BrojeviTelefonaPravnogLicaPregled
    {
        public BrojeviTelefonaPravnogLicaBasic(IDBrTelPL id) : base(id)
        {

        }

        public BrojeviTelefonaPravnogLicaBasic() : base()
        {

        }

    }

    public class IDBrTelPLBasic
    {
        public virtual PravnoLiceBasic pravnolicebroj { get; set; }
        public virtual int broj_telefona { get; set; }

        public IDBrTelPLBasic(int broj_telefona)
        {
            this.broj_telefona = broj_telefona;
        }
    }



    #endregion


    #region Dodaci
    public class DodaciBasic
    {
        public int DodaciId { get; set; }
        public string TipDodatka { get; set; }

        public Nekretnina NekretninaDodatka { get; set; }
        public DodaciBasic(int dodaciId, string tipDodatka, Nekretnina nekretnina)
        {
            DodaciId = dodaciId;
            TipDodatka = tipDodatka;
            NekretninaDodatka = nekretnina;
        }

        public DodaciBasic()
        {
        }
    }

    public class DodatnaOpremaBasic
    {
        public int DodatnaOpremaId { get; set; }
        public string TipDodatka { get; set; }
        public string TipDodatneOpreme { get; set; }
        public double Doplata { get; set; }

        public Nekretnina nekretnina { get; set; }

        public DodatnaOpremaBasic(int id, string tip, double dopl, Nekretnina nekretnina)
        {
            DodatnaOpremaId = id;
            TipDodatneOpreme = tip;
            Doplata = dopl;
            this.nekretnina = nekretnina;
        }

        public DodatnaOpremaBasic()
        {
        }
    }

    public class KuhinjaBasic
    {
        public int KuhinjaId { get; set; }
        public bool Posudje { get; set; }
        public string TipDodatka;
        public Nekretnina nekretnina { get; set; }

        public KuhinjaBasic(int id, string tipDodatka, bool posudje, Nekretnina nekretnina)
        {
            KuhinjaId = id;
            Posudje = posudje;
            TipDodatka = tipDodatka;
            this.nekretnina = nekretnina;
        }

        public KuhinjaBasic()
        {
        }
    }
    public class KuhinjaPregled
    {
        public int KuhinjaId { get; set; }
        public bool Posudje { get; set; }
        public string TipNekretnine { get; set; }

        public KuhinjaPregled(int kuhinjaId, bool posudje, string tipNekretnine)
        {
            KuhinjaId = kuhinjaId;
            Posudje = posudje;
            TipNekretnine = tipNekretnine;
        }

        public KuhinjaPregled()
        {

        }
    }

    public class KrevetBasic
    {
        public int KrevetId { get; set; }
        public string TipDodatka { get; set; }
        public string TipKreveta { get; set; }

        public string DimenzijeKreveta { get; set; }

        public Nekretnina nekretnina { get; set; }

        public KrevetBasic(int id, string tipKreveta, string tipDodatka, string dim)
        {
            KrevetId = id;
            TipKreveta = tipKreveta;
            TipDodatka = tipDodatka;
            DimenzijeKreveta = dim;
        }

        public KrevetBasic()
        {
        }
    }
    public class KrevetPregled
    {
        public int KrevetId { get; set; }
        public string TipKreveta { get; set; }
        public string DimenzijeKreveta { get; set; }

        public int NekretninaID { get; set; }
        public string TipNekretnine { get; set; }

        public KrevetPregled(int krevetId, string tipKreveta, string dimenzijeKreveta, int nekretninaID, string tipNekretnine)
        {
            KrevetId = krevetId;
            TipKreveta = tipKreveta;
            DimenzijeKreveta = dimenzijeKreveta;
            NekretninaID = nekretninaID;
            TipNekretnine = tipNekretnine;
        }
    }
    public class ParkingMestoBasic
    {
        public int ParkingMestoId { get; set; }
        public string TipDodatka { get; set; }
        public string Lokacija { get; set; }
        public double CenaParkingMesta { get; set; }
        public Nekretnina nekretnina { get; set; }

        public ParkingMestoBasic(int parkingMestoId, string tipDodatka, string lokacija, double cenaParkingMesta)
        {
            ParkingMestoId = parkingMestoId;
            TipDodatka = tipDodatka;
            Lokacija = lokacija;
            CenaParkingMesta = cenaParkingMesta;
        }

        public ParkingMestoBasic()
        {
        }
    }

    public class ParkingMestoPregled
    {
        public int ParkingMestoId { get; set; }
        public string Lokacija { get; set; }
        public double CenaParkingMesta { get; set; }
        public int nekretninaID { get; set; }
        public string TipNekretnine { get; set; }

        public ParkingMestoPregled(int parkingMestoId, string lokacija, double cenaParkingMesta, int nekretninaID, string tipNekretnine)
        {
            ParkingMestoId = parkingMestoId;
            Lokacija = lokacija;
            CenaParkingMesta = cenaParkingMesta;
            this.nekretninaID = nekretninaID;
            TipNekretnine = tipNekretnine;
        }
        public ParkingMestoPregled()
        {
        }
    }
    public class DodaciPregled
    {
        public int DodaciId { get; set; }
        public string TipDodatka { get; set; }


        public int nekretninaID { get; set; }
         // kuca ili stan
         public string TipNekretnine { get; set; }
        public DodaciPregled(int dodaciId, string tipDodatka, int nekretninaid, string tipNekretnine)
        {
            DodaciId = dodaciId;
            nekretninaID = nekretninaid;
            TipDodatka = tipDodatka;
            this.TipNekretnine = tipNekretnine;
        }
    }
    #endregion

    #region Najam
    public class NajamBasic
    {
        public int NajamId { get; set; }

        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }

        public double CenaPoDanu { get; set; }
        public int BrojDana { get; set; }

        public double UkupnaCena { get; set; }

        public double Popust { get; set; }
        public double CenaSaPopustom { get; set; }

        public Agent Agent { get; set; }
        public Agencija Agencija { get; set; }
        public Nekretnina IznajmljenaNekretnina { get; set; }
        

        public NajamBasic(int najamId, DateTime datumPocetka, DateTime datumZavrsetka, double cenaPoDanu, int brojDana, double ukupnaCena, double popust, double cenaSaPopustom, Agent agent, Agencija agencija
            , Nekretnina iznajmljenaNekretnina)
        {
            NajamId = najamId;
            DatumPocetka = datumPocetka;
            DatumZavrsetka = datumZavrsetka;
            CenaPoDanu = cenaPoDanu;
            BrojDana = brojDana;
            UkupnaCena = ukupnaCena;
            Popust = popust;
            CenaSaPopustom = cenaSaPopustom;
            Agent = agent;
            Agencija = agencija;
            IznajmljenaNekretnina = iznajmljenaNekretnina;
        }

        public NajamBasic()
        {
        }
    }

    public class NajamPregled
    {
        public int NajamId { get; set; }

        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }

        public double CenaPoDanu { get; set; }
        public int BrojDana { get; set; }

        public double UkupnaCena { get; set; }

        public double Popust { get; set; }
        public double CenaSaPopustom { get; set; }

        public string ImeAgenta { get; set; }

        public string NazivAgencije { get; set; }
        public string NazivNekretnine { get; set; }
        public NajamPregled(int najamId, DateTime datumPocetka, DateTime datumZavrsetka, double cenaPoDanu, int brojDana, double ukupnaCena, double popust, double cenaSaPopustom, string imeAgenta, string nazivAgencije, string nazivNekretnine)
        {
            NajamId = najamId;
            DatumPocetka = datumPocetka;
            DatumZavrsetka = datumZavrsetka;
            CenaPoDanu = cenaPoDanu;
            BrojDana = brojDana;
            UkupnaCena = ukupnaCena;
            Popust = popust;
            CenaSaPopustom = cenaSaPopustom;
            ImeAgenta = imeAgenta;
            NazivAgencije = nazivAgencije;
            NazivNekretnine = NazivNekretnine;
        }
    }
    #endregion



    #region SpoljniSaradnik
    public class SpoljniSaradnikBasic
    {
        public SpoljniSaradnikID Id { get; set; }
        public Agent Agent { get; set; }
        public string BrojTelefona { get; set; }
        public string Ime { get; set; }
        public DateTime DatumAngazovanja { get; set; }
        public double Procenat { get; set; }

        public SpoljniSaradnikBasic(SpoljniSaradnikID Id, Agent agent, string brojTelefona, string ime, DateTime datumAngazovanja, double procenat)
        {
            Agent = agent;
            BrojTelefona = brojTelefona;
            Ime = ime;
            DatumAngazovanja = datumAngazovanja;
            Procenat = procenat;
        }

        public SpoljniSaradnikBasic()
        {
        }
    }


    public class SpoljniSaradnikPregled
    {
        public string ImeAgenta { get; set; }
        public string MaticniBrojAgenta { get; set; }
        public string BrojTelefona { get; set; }
        public string Ime { get; set; }

        public DateTime DatumAngazovanja { get; set; }
        public double Procenat { get; set; }

        public string TipNekretnine { get; set; }

        public SpoljniSaradnikPregled(string imeAgenta, string maticniBroj, string brojTelefona, string ime, DateTime datumAngazovanja, double procenat, string tipNekretnine)
        {
            ImeAgenta = imeAgenta;
            MaticniBrojAgenta = maticniBroj;
            BrojTelefona = brojTelefona;
            Ime = ime;
            DatumAngazovanja = datumAngazovanja;
            Procenat = procenat;
            TipNekretnine = tipNekretnine;
        }
    }

    #endregion

}
