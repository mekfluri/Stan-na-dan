using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using StanNaDanv2.Entiteti;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using FluentNHibernate.Conventions;

namespace StanNaDanv2
{
   public class DTOManager
    {
        #region Zaposleni
        public static SamoZaposleniBasic vratiZaposlenog(string id)
        {
            SamoZaposleniBasic pb = new SamoZaposleniBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.SamoZaposleni o = s.Get<StanNaDanv2.Entiteti.SamoZaposleni>(id);
                pb.maticni_broj_zaposlenog = o.maticni_broj_zaposlenog;
                pb.ime = o.ime;
                pb.datum_zaposlenja = o.datum_zaposlenja;



                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return pb;
        }
        public static List<SamoZaposleniPregled> VratiSveZaposlenePoslovice(int id)
        {
            List<SamoZaposleniPregled> zaposleni = new List<SamoZaposleniPregled>();
            List<SamoZaposleni> sviZaposleni;
            try
            {
                ISession s = DataLayer.GetSession();

                //IEnumerable<StanNaDanv2.Entiteti.Zaposleni> sviZaposleni = from o in s.Query<StanNaDanv2.Entiteti.Zaposleni>()
                //                                                           where o.poslovicaID == id
                //                                                           select o;
                 sviZaposleni = s.Query<StanNaDanv2.Entiteti.SamoZaposleni>().
                                                 Where(x => x.Poslovnica.Id== id) .ToList();


                foreach (StanNaDanv2.Entiteti.SamoZaposleni r in sviZaposleni)
                {
                   SamoZaposleniPregled zaposleniPregled = new SamoZaposleniPregled
                    {
                        maticni_broj= r.maticni_broj_zaposlenog,
                        ime = r.ime,
                        datum_zaposlenja = r.datum_zaposlenja,
                        FAgent = r.FAgent,
                        FSef = r.FSef
                    };

                    zaposleni.Add(zaposleniPregled);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                // Handle exceptions appropriately, e.g., log or throw
            }

            return zaposleni;
        }
        public static List<SamoZaposleniPregled> VratiSveZaposleneAgencije(int id)
        {
            List<SamoZaposleniPregled> zaposleni = new List<SamoZaposleniPregled>();
            List<SamoZaposleni> sviZaposleni;
            try
            {
                ISession s = DataLayer.GetSession();

                //IEnumerable<StanNaDanv2.Entiteti.Zaposleni> sviZaposleni = from o in s.Query<StanNaDanv2.Entiteti.Zaposleni>()
                //                                                           where o.poslovicaID == id
                //                                                           select o;
                sviZaposleni = s.Query<StanNaDanv2.Entiteti.SamoZaposleni>().
                                                Where(x => x.agencija.Id == id).ToList();


                foreach (StanNaDanv2.Entiteti.SamoZaposleni r in sviZaposleni)
                {
                    SamoZaposleniPregled zaposleniPregled = new SamoZaposleniPregled
                    {
                        maticni_broj = r.maticni_broj_zaposlenog,
                        ime = r.ime,
                        datum_zaposlenja = r.datum_zaposlenja,
                        FAgent = r.FAgent,
                        FSef = r.FSef
                    };

                    zaposleni.Add(zaposleniPregled);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                // Handle exceptions appropriately, e.g., log or throw
            }

            return zaposleni;
        }
       public static List<SamoZaposleniPregled> VratiSveZaposlene()
        {
            List<SamoZaposleniPregled> zaposleni = new List<SamoZaposleniPregled>();
            List<SamoZaposleni> sviZaposleni;
            try
            {
                ISession s = DataLayer.GetSession();


                sviZaposleni = s.Query<StanNaDanv2.Entiteti.SamoZaposleni>().ToList();
                                         


                foreach (StanNaDanv2.Entiteti.SamoZaposleni r in sviZaposleni)
                {
                    SamoZaposleniPregled zaposleniPregled = new SamoZaposleniPregled
                    {
                        maticni_broj = r.maticni_broj_zaposlenog,
                        ime = r.ime,
                        datum_zaposlenja = r.datum_zaposlenja,
                        FAgent = r.FAgent,
                        FSef = r.FSef
                    };

                    zaposleni.Add(zaposleniPregled);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                // Handle exceptions appropriately, e.g., log or throw
            }

            return zaposleni;

        }
        public static void obrisiZaposlenog(string id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SamoZaposleni sef = s.Load<SamoZaposleni>(id);

                if (sef != null)
                {
                    s.Delete(sef);
                    s.Flush();
                }

                s.Close();
            }
            catch (Exception e)
            {
                // Handle exceptions
            }


        }
        public static SamoZaposleniBasic azurirajZaposlenog(SamoZaposleniBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.SamoZaposleni o = s.Load<StanNaDanv2.Entiteti.SamoZaposleni>(r.maticni_broj_zaposlenog);

          
                o.ime = r.ime;
                o.datum_zaposlenja = r.datum_zaposlenja;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return r;

        }
        public static void obrisiZaposlenogIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.SamoZaposleni r = s.Load<StanNaDanv2.Entiteti.SamoZaposleni>(id);
               //ovde veze treba da se obrisu!
                s.Delete(r);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static List<SamoZaposleniPregled> vratiSveZaposlene(AgencijaBasic agencija)
        {
            List<SamoZaposleniPregled> kvartovi = new List<SamoZaposleniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StanNaDanv2.Entiteti.SamoZaposleni> sviRadnici = from o in s.Query<StanNaDanv2.Entiteti.SamoZaposleni>()
                                                                         where o.agencija.Id == agencija.AgencijaID
                                                                         select o;

                foreach (StanNaDanv2.Entiteti.SamoZaposleni r in sviRadnici)
                {
                    kvartovi.Add(new SamoZaposleniPregled(r.maticni_broj_zaposlenog,r.ime,r.datum_zaposlenja,r.FAgent,r.FSef));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return kvartovi;
        }
        public static void dodajZaposlenog(ZaposleniBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Zaposleni o = new StanNaDanv2.Entiteti.Zaposleni();
                o.maticni_broj_zaposlenog = r.maticni_broj_zaposlenog;
                o.ime = r.ime;
                o.datum_zaposlenja = r.datum_zaposlenja;
                StanNaDanv2.Entiteti.Poslovnica p = s.Load<StanNaDanv2.Entiteti.Poslovnica>(r.Poslovnica.PoslovnicaID);
                o.Poslovnica = p;
                o.Poslovnica.Id = p.Id;
                o.FSef = false;
                o.FAgent = false;
                StanNaDanv2.Entiteti.Agencija a = s.Load<StanNaDanv2.Entiteti.Agencija>(p.PripadaAgenciji.Id);
                o.agencija = a;
                o.agencija.Id = a.Id;



                s.SaveOrUpdate(o);



                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion
        #region Sef
        public static SefBasic vratiSefa(string id)
        {
            SefBasic pb = new SefBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Sef o = s.Get<StanNaDanv2.Entiteti.Sef>(id);

                if (o != null)
                {
                    pb.maticni_broj_zaposlenog = o.maticni_broj_zaposlenog;
                    pb.ime = o.ime;
                    pb.datum_zaposlenja = o.datum_zaposlenja;
                    pb.datum_postavljanja = o.datum_postavljanja;
                }

                s.Close();
            }
            catch (Exception ec)
            {
                // Handle exceptions
            }
            return pb;
        }



        public static void DodajSefa(SefBasic r)
        { 
                try
                {
                    ISession s = DataLayer.GetSession();

                    StanNaDanv2.Entiteti.Sef o = new StanNaDanv2.Entiteti.Sef();
                    o.maticni_broj_zaposlenog = r.maticni_broj_zaposlenog;
                    o.ime = r.ime;
                    o.datum_zaposlenja = r.datum_zaposlenja;
                    StanNaDanv2.Entiteti.Poslovnica p = s.Load<StanNaDanv2.Entiteti.Poslovnica>(r.Poslovnica.PoslovnicaID);
                    o.Poslovnica = p;
            
                    o.FSef = true;
                    o.FAgent = false;
                    StanNaDanv2.Entiteti.Agencija a = s.Load<StanNaDanv2.Entiteti.Agencija>(p.PripadaAgenciji.Id);
                    o.agencija = a;
          



                    s.SaveOrUpdate(o);



                    s.Flush();

                    s.Close();
                }
                catch (Exception ec)
                {
                    //handle exceptions
                }
            }
            public static void izmeniSefa(SefBasic sef)
        {
            try {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Sef o = s.Load<Sef>(sef.maticni_broj_zaposlenog);

                o.ime = sef.ime;
                o.datum_postavljanja = sef.datum_postavljanja;
                o.datum_zaposlenja = sef.datum_zaposlenja;
                



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();


            }
            catch(Exception e)
            {

            }
        }
        public static List<SefPregled> VratiSveSefovePoslovice(int id)
        {
            List<SefPregled> zaposleni = new List<SefPregled>();
            List<Sef> sviZaposleni;
            try
            {
                ISession s = DataLayer.GetSession();

                //IEnumerable<StanNaDanv2.Entiteti.Zaposleni> sviZaposleni = from o in s.Query<StanNaDanv2.Entiteti.Zaposleni>()
                //                                                           where o.poslovicaID == id
                //                                                           select o;
                sviZaposleni = s.Query<StanNaDanv2.Entiteti.Sef>().
                                                Where(x => x.Poslovnica.Id == id).ToList();


                foreach (StanNaDanv2.Entiteti.Sef r in sviZaposleni)
                {
                    SefPregled zaposleniPregled = new SefPregled
                    {
                        maticni_broj = r.maticni_broj_zaposlenog,
                        ime = r.ime,
                        datum_zaposlenja = r.datum_zaposlenja,
                        FAgent = r.FAgent,
                        FSef = r.FSef
                    };

                    zaposleni.Add(zaposleniPregled);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                // Handle exceptions appropriately, e.g., log or throw
            }

            return zaposleni;
        }
        public static List<SefPregled> VratiSveSefoveAgencije(int id)
        {
            List<SefPregled> zaposleni = new List<SefPregled>();
            List<Sef> sviZaposleni;
            try
            {
                ISession s = DataLayer.GetSession();

                //IEnumerable<StanNaDanv2.Entiteti.Zaposleni> sviZaposleni = from o in s.Query<StanNaDanv2.Entiteti.Zaposleni>()
                //                                                           where o.poslovicaID == id
                //                                                           select o;
                sviZaposleni = s.Query<StanNaDanv2.Entiteti.Sef>().
                                                Where(x => x.agencija.Id == id).ToList();


                foreach (StanNaDanv2.Entiteti.Sef r in sviZaposleni)
                {
                    SefPregled zaposleniPregled = new SefPregled
                    {
                        maticni_broj = r.maticni_broj_zaposlenog,
                        ime = r.ime,
                        datum_zaposlenja = r.datum_zaposlenja,
                        FAgent = r.FAgent,
                        FSef = r.FSef
                    };

                    zaposleni.Add(zaposleniPregled);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                // Handle exceptions appropriately, e.g., log or throw
            }

            return zaposleni;
        }
        public static void DodajPostojecegSefa(SefBasic sef)
        {
            try
            { 

                ISession s = DataLayer.GetSession();
                StanNaDanv2.Entiteti.Sef o = s.Load<StanNaDanv2.Entiteti.Sef>(sef.maticni_broj_zaposlenog);
                o.ime = sef.ime;
                o.datum_zaposlenja = sef.datum_zaposlenja;
                s.Update(o);
                s.Flush();

                s.Close();


            }
            catch(Exception e)
            {

            }
        }
        public static void obrisiSefa(string id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Sef sef = s.Load<Sef>(id);

                if (sef != null)
                {
                    s.Delete(sef);
                    s.Flush();
                }

                s.Close();
            }
            catch (Exception e)
            {
                // Handle exceptions
            }
        }


        #endregion
        #region Agent

        public static Agent vratiAgentaNeBasic(string id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Agent agent = s.Load<Agent>(id);
                s.Close();

                return agent;
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
                return null;
            }
        }
        public static List<AgentPregled> VratiSveAgenteAgencije(int id)
        {
            List<AgentPregled> zaposleni = new List<AgentPregled>();
            List<Agent> sviZaposleni;
            try
            {
                ISession s = DataLayer.GetSession();

                //IEnumerable<StanNaDanv2.Entiteti.Zaposleni> sviZaposleni = from o in s.Query<StanNaDanv2.Entiteti.Zaposleni>()
                //                                                           where o.poslovicaID == id
                //                                                           select o;
                sviZaposleni = s.Query<StanNaDanv2.Entiteti.Agent>().
                                                Where(x => x.agencija.Id == id).ToList();


                foreach (StanNaDanv2.Entiteti.Agent r in sviZaposleni)
                {
                    AgentPregled zaposleniPregled = new AgentPregled
                    {
                        maticni_broj = r.maticni_broj_zaposlenog,
                        ime = r.ime,
                        strucna_sprema = r.strucna_sprema,
                        FAgent = r.FAgent,
                        FSef = r.FSef
                    };

                    zaposleni.Add(zaposleniPregled);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                // Handle exceptions appropriately, e.g., log or throw
            }

            return zaposleni;
        }
        public static AgentBasic vratiAgenta(string id)
        {
            AgentBasic pb = new AgentBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Agent o = s.Get<StanNaDanv2.Entiteti.Agent>(id);

                if (o != null)
                {
                    pb.maticni_broj_zaposlenog = o.maticni_broj_zaposlenog;
                    pb.ime = o.ime;
                    pb.datum_zaposlenja = o.datum_zaposlenja;
                    pb.strucna_sprema = o.strucna_sprema;
                }

                s.Close();
            }
            catch (Exception ec)
            {
                // Handle exceptions
            }
            return pb;
        }
        public static List<AgentPregled> VratiSveAgentePoslovice(int id)
        {
            List<AgentPregled> zaposleni = new List<AgentPregled>();
            List<Agent> sviZaposleni;
            try
            {
                ISession s = DataLayer.GetSession();

                //IEnumerable<StanNaDanv2.Entiteti.Zaposleni> sviZaposleni = from o in s.Query<StanNaDanv2.Entiteti.Zaposleni>()
                //                                                           where o.poslovicaID == id
                //                                                           select o;
                sviZaposleni = s.Query<StanNaDanv2.Entiteti.Agent>().
                                                Where(x => x.Poslovnica.Id == id).ToList();


                foreach (StanNaDanv2.Entiteti.Agent r in sviZaposleni)
                {
                    AgentPregled zaposleniPregled = new AgentPregled
                    {
                        maticni_broj = r.maticni_broj_zaposlenog,
                        ime = r.ime,
                        strucna_sprema = r.strucna_sprema,
                        FAgent = r.FAgent,
                        FSef = r.FSef
                    };

                    zaposleni.Add(zaposleniPregled);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                // Handle exceptions appropriately, e.g., log or throw
            }

            return zaposleni;
        }
        public static void DodajAgenta(AgentBasic r)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Agent o = new StanNaDanv2.Entiteti.Agent();
                o.maticni_broj_zaposlenog = r.maticni_broj_zaposlenog;
                o.ime = r.ime;
                o.datum_zaposlenja = r.datum_zaposlenja;
                StanNaDanv2.Entiteti.Poslovnica p = s.Load<StanNaDanv2.Entiteti.Poslovnica>(r.Poslovnica.PoslovnicaID);
                o.Poslovnica = p;
         
                o.FSef = false;
                o.FAgent = true;
                StanNaDanv2.Entiteti.Agencija a = s.Load<StanNaDanv2.Entiteti.Agencija>(p.PripadaAgenciji.Id);
                o.agencija = a;
       
                o.strucna_sprema = r.strucna_sprema;


                s.SaveOrUpdate(o);



                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
     
       /* public static void DodajAgenta(AgentBasic sef)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Agent o = new StanNaDanv2.Entiteti.Agent();
                o.maticni_broj_zaposlenog = sef.maticni_broj_zaposlenog;
                o.ime = sef.ime;
                o.tip = sef.tip;
                o.strucna_sprema = sef.strucna_sprema;
                o.datum_zaposlenja = sef.datum_zaposlenja;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();

            }
            catch (Exception e)
            {

            }
        }*/
        public static void izmeniAgenta(AgentBasic sef)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Agent o = s.Load<Agent>(sef.maticni_broj_zaposlenog);

                o.ime = sef.ime;
                o.strucna_sprema = sef.strucna_sprema;
                o.datum_zaposlenja = sef.datum_zaposlenja;




                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();


            }
            catch (Exception e)
            {

            }
        }
        public static void DodajPostojecegAgenta(AgentBasic sef)
        {
            try
            {

                ISession s = DataLayer.GetSession();
                StanNaDanv2.Entiteti.Agent o = s.Load<StanNaDanv2.Entiteti.Agent>(sef.maticni_broj_zaposlenog);
                o.ime = sef.ime;
                o.datum_zaposlenja = sef.datum_zaposlenja;
                s.Update(o);
                s.Flush();

                s.Close();


            }
            catch (Exception e)
            {

            }
        }
        public static void obrisiAgenta(string id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Agent sef = s.Load<Agent>(id);

                s.Delete(sef);
                s.Flush();



                s.Close();

            }
            catch (Exception e)
            {

            }
        }
        #endregion
        #region Kuca

        
        public static KucaBasic vratiKucu(int id)
        {
            KucaBasic pb = new KucaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Kuca o = s.Load<StanNaDanv2.Entiteti.Kuca>(id);
                pb = new KucaBasic(o.SPRATNOST, o.DVORISTE, o.nekretninaID, o.kucnibroj, o.ime_ulice, o.povrsina, o.broj_kupatila, o.broj_terasa, o.broj_spavacih_soba, o.internet, o.TV_PRIKLJUCAK, o.FKuca.ToString(),o.kvartID,o.FKuca,o.FStan);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }
        public static void izmeniKucu(KucaBasic kuca)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Kuca o = s.Load<Kuca>(kuca.nekretninaID);
                o.broj_kupatila = kuca.broj_kupatila;
                o.broj_spavacih_soba = kuca.broj_spavacih_soba;
                o.broj_terasa = kuca.broj_terasa;
                o.kucnibroj = kuca.kucnibroj;
                o.DVORISTE = kuca.DVORISTE;
                o.internet = kuca.internet;
                o.TV_PRIKLJUCAK = kuca.TV_PRIKLJUCAK;
                o.ime_ulice = kuca.ime_ulice;
                o.povrsina = kuca.povrsina;
                o.SPRATNOST = kuca.SPRATNOST;
              
                //veze ne treba

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static void sacuvajKucu(KucaBasic kuca)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Kuca o = new StanNaDanv2.Entiteti.Kuca();

                o.broj_kupatila = kuca.broj_kupatila;
                o.broj_spavacih_soba = kuca.broj_spavacih_soba;
                o.broj_terasa = kuca.broj_terasa;
                o.kucnibroj = kuca.kucnibroj;
                o.DVORISTE = kuca.DVORISTE;
                o.internet = kuca.internet;
                o.TV_PRIKLJUCAK = kuca.TV_PRIKLJUCAK;
                o.ime_ulice = kuca.ime_ulice;
                o.povrsina = kuca.povrsina;
                o.SPRATNOST = kuca.SPRATNOST;
                o.FKuca = true;
                o.FStan = false;

                StanNaDanv2.Entiteti.Vlasnik vlasnik = s.Load<StanNaDanv2.Entiteti.Vlasnik>(kuca.vlasnik.VlasnikID);
                o.vlasnik = vlasnik;
                StanNaDanv2.Entiteti.Kvart kvart= s.Load<StanNaDanv2.Entiteti.Kvart>(kuca.kvartID);
                o.kvart = kvart;
                StanNaDanv2.Entiteti.Agencija agencija= s.Load<StanNaDanv2.Entiteti.Agencija>(vlasnik.agencija.Id);
                o.agencija = agencija;

                o.iznajmljenaUNajmu = new Entiteti.Najam();






                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
       public static List<KucaPregled> vratiSveKuceVlasnika(int id)
        {
            List<KucaPregled> poslovnice = new List<KucaPregled>();
            try
            {


                ISession s = DataLayer.GetSession();

                IEnumerable<StanNaDanv2.Entiteti.Kuca> sveKuce = from o in s.Query<StanNaDanv2.Entiteti.Kuca>()
                                                                 where o.vlasnik.Id == id
                                                                 select o;

                foreach (StanNaDanv2.Entiteti.Kuca r in sveKuce)
                {
                    poslovnice.Add(new KucaPregled(r.SPRATNOST, r.DVORISTE, r.nekretninaID, r.kucnibroj, r.ime_ulice, r.povrsina, r.broj_kupatila, r.broj_terasa, r.broj_spavacih_soba, r.internet, r.TV_PRIKLJUCAK, r.FKuca.ToString(),r.FKuca,r.FStan));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return poslovnice;

        }
        public static void obrisiKucu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kuca kuce = s.Load<Kuca>(id);

                s.Delete(kuce);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static List<KucaPregled> vratiSveKuceAgencije(int id)
        {
            List<KucaPregled> poslovnice = new List<KucaPregled>();
            try
            {


                ISession s = DataLayer.GetSession();

                IEnumerable<StanNaDanv2.Entiteti.Kuca> sveKuce = from o in s.Query<StanNaDanv2.Entiteti.Kuca>()
                                                                           where o.agencija.Id == id
                                                                           select o;

                foreach (StanNaDanv2.Entiteti.Kuca r in sveKuce)
                {
                    poslovnice.Add(new KucaPregled(r.SPRATNOST,r.DVORISTE,r.nekretninaID,r.kucnibroj,r.ime_ulice,r.povrsina,r.broj_kupatila,r.broj_terasa,r.broj_spavacih_soba,r.internet,r.TV_PRIKLJUCAK,r.FKuca.ToString(),r.FKuca,r.FStan));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return poslovnice;
        }
        #endregion
        #region Stan
       public static List<StanPregled> vratiSveStanoveAgencije(int id)
        {
            List<StanPregled> poslovnice = new List<StanPregled>();
            try
            {


                ISession s = DataLayer.GetSession();

                IEnumerable<StanNaDanv2.Entiteti.Stan> sveKuce = from o in s.Query<StanNaDanv2.Entiteti.Stan>()
                                                                 where o.agencija.Id == id
                                                                 select o;

                foreach (StanNaDanv2.Entiteti.Stan r in sveKuce)
                {
                    poslovnice.Add(new StanPregled(r.SPRAT, r.LIFT, r.nekretninaID, r.kucnibroj, r.ime_ulice, r.povrsina, r.broj_kupatila, r.broj_terasa, r.broj_spavacih_soba, r.internet, r.TV_PRIKLJUCAK, r.FKuca.ToString(), r.FKuca, r.FStan));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return poslovnice;
        }
        public static List<StanPregled> vratiSveStanoveVlasnika(int id)
        {
            List<StanPregled> poslovnice = new List<StanPregled>();
            try
            {


                ISession s = DataLayer.GetSession();

                IEnumerable<StanNaDanv2.Entiteti.Stan> sveKuce = from o in s.Query<StanNaDanv2.Entiteti.Stan>()
                                                                 where o.vlasnik.Id == id
                                                                 select o;

                foreach (StanNaDanv2.Entiteti.Stan r in sveKuce)
                {
                    poslovnice.Add(new StanPregled(r.SPRAT, r.LIFT, r.nekretninaID, r.kucnibroj, r.ime_ulice, r.povrsina, r.broj_kupatila, r.broj_terasa, r.broj_spavacih_soba, r.internet, r.TV_PRIKLJUCAK, r.FKuca.ToString(), r.FKuca, r.FStan));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return poslovnice;

        }
        public static void sacuvajStan(StanBasic kuca)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Stan o = new StanNaDanv2.Entiteti.Stan();

                o.broj_kupatila = kuca.broj_kupatila;
                o.broj_spavacih_soba = kuca.broj_spavacih_soba;
                o.broj_terasa = kuca.broj_terasa;
                o.kucnibroj = kuca.kucnibroj;
                o.internet = kuca.internet;
                o.TV_PRIKLJUCAK = kuca.TV_PRIKLJUCAK;
                o.ime_ulice = kuca.ime_ulice;
                o.povrsina = kuca.povrsina;
                o.SPRAT= kuca.SPRAT;
                o.LIFT = kuca.LIFT;
                o.FKuca = false;
                o.FStan = true;

                StanNaDanv2.Entiteti.Vlasnik vlasnik = s.Load<StanNaDanv2.Entiteti.Vlasnik>(kuca.vlasnik.VlasnikID);
                o.vlasnik = vlasnik;
                StanNaDanv2.Entiteti.Kvart kvart = s.Load<StanNaDanv2.Entiteti.Kvart>(kuca.kvartID);
                o.kvart = kvart;
                StanNaDanv2.Entiteti.Agencija agencija = s.Load<StanNaDanv2.Entiteti.Agencija>(vlasnik.agencija.Id);
                o.agencija = agencija;





                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void izmeniStan(StanBasic kuca)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Stan o = s.Load<Stan>(kuca.nekretninaID);
                o.broj_kupatila = kuca.broj_kupatila;
                o.broj_spavacih_soba = kuca.broj_spavacih_soba;
                o.broj_terasa = kuca.broj_terasa;
                o.kucnibroj = kuca.kucnibroj;
                o.LIFT= kuca.LIFT;
                o.internet = kuca.internet;
                o.TV_PRIKLJUCAK = kuca.TV_PRIKLJUCAK;
                o.ime_ulice = kuca.ime_ulice;
                o.povrsina = kuca.povrsina;
                o.SPRAT= kuca.SPRAT;

                //veze ne treba

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static void obrisiStan(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Stan stanovi = s.Load<Stan>(id);

                s.Delete(stanovi);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        #endregion
        #region Kvart
        public static KvartBasic vratiKvart(int id)
        {
            KvartBasic pb = new KvartBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Kvart o = s.Load<StanNaDanv2.Entiteti.Kvart>(id);
                pb.kvartID = o.kvartID;
                pb.gradska_zona = o.gradska_zona;
                pb.broj_nekretnina = o.broj_nekretnina;
             


                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return pb;
        }
        public static void dodajKvart(KvartBasic kvart)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Kvart o = new StanNaDanv2.Entiteti.Kvart();

                o.broj_nekretnina=kvart.broj_nekretnina;
                o.gradska_zona = kvart.gradska_zona;
                StanNaDanv2.Entiteti.Poslovnica a = s.Load<StanNaDanv2.Entiteti.Poslovnica>(kvart.poslovnica.PoslovnicaID);
                o.poslovnica = a;
                o.poslovnica.Id = a.Id;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static void izmeniKvart(KvartBasic kvart)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StanNaDanv2.Entiteti.Kvart o = s.Load<Kvart>(kvart.kvartID);

                //treba veze
                o.broj_nekretnina = kvart.broj_nekretnina;
                o.gradska_zona = kvart.gradska_zona;




                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        public static void obrisiKvart(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kvart kvartovi = s.Load<Kvart>(id);

                s.Delete(kvartovi);
                s.Flush();



                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }
        public static IList<KvartPregled> vratiSveKvartove()
        {
            List<KvartPregled> kvartovi = new List<KvartPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StanNaDanv2.Entiteti.Kvart> sviKvartovi = from o in s.Query<StanNaDanv2.Entiteti.Kvart>()   select o;;
                                                                  
              
                foreach (StanNaDanv2.Entiteti.Kvart r in sviKvartovi)
                {
                    kvartovi.Add(new KvartPregled(r.kvartID,r.gradska_zona,r.broj_nekretnina));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return kvartovi;
        }
        #endregion
        #region Sajt
        /*public static void dodajSajt(SajtNekretnineBasic sajt)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.SajtNekretnine o = new StanNaDanv2.Entiteti.SajtNekretnine();
                o.sajt = sajt.sajt;
                
                //veza treba da se doda
                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

        }*/
        public static StanBasic vratiStan(int id)
        {
            StanBasic pb = new StanBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Stan o = s.Load<StanNaDanv2.Entiteti.Stan>(id);
                pb = new StanBasic(o.SPRAT, o.LIFT, o.nekretninaID, o.kucnibroj, o.ime_ulice, o.povrsina, o.broj_kupatila, o.broj_terasa, o.broj_spavacih_soba, o.internet, o.TV_PRIKLJUCAK, o.FKuca.ToString(), o.kvartID, o.FKuca, o.FStan);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pb;
        }
        /* public static void izmeniSajt(SajtNekretnineBasic sajt)
         {
             try
             {
                 ISession s = DataLayer.GetSession();
                 StanNaDanv2.Entiteti.SajtNekretnine o = s.Load<SajtNekretnine>(sajt.);

                 //treba veze
                 o.broj_nekretnina = kvart.broj_nekretnina;
                 o.gradska_zona = kvart.gradska_zona;




                 s.SaveOrUpdate(o);

                 s.Flush();

                 s.Close();
             }
             catch (Exception ec)
             {
                 //handle exceptions
             }
         }
         public static void obrisiKvart(int id)
         {
             try
             {
                 ISession s = DataLayer.GetSession();
                 Kvart kvartovi = s.Load<Kvart>(id);

                 s.Delete(kvartovi);
                 s.Flush();



                 s.Close();

             }
             catch (Exception ec)
             {
                 //handle exceptions
             }

         }*/

        public static void obrisiSajt(string naziv)
        {
            try
            {


                ISession s = DataLayer.GetSession();



                StanNaDanv2.Entiteti.Sajt p = new Entiteti.Sajt();

                p = s.Query<StanNaDanv2.Entiteti.Sajt>()
                         .Where(b => b.ID.sajt == naziv)
                         .FirstOrDefault();

                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void dodajSajt(NekretninaBasic f, SajtBasic brt)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StanNaDanv2.Entiteti.Nekretnina fl = s.Load<Entiteti.Nekretnina>(f.nekretninaID);

                StanNaDanv2.Entiteti.Sajt sajt = new StanNaDanv2.Entiteti.Sajt();
                StanNaDanv2.Entiteti.SajtNekretnine sajtnek = new StanNaDanv2.Entiteti.SajtNekretnine();

                sajtnek.nekretnina = fl;
                sajtnek.sajt = brt.sajtID.sajt;

                sajt.ID = sajtnek;

                fl.sajtovi.Add(sajt);

                s.Save(sajt);



                s.Flush();

             

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }


        }

        public static List<string> vratiSajtove(int id)
        {
            List<string> sajtovi = new List<string>();
            try
            {
                ISession s = DataLayer.GetSession();

                sajtovi = s.Query<StanNaDanv2.Entiteti.Sajt>()
                    .Where(b => b.ID.nekretnina.nekretninaID == id)
                    .Select(b => b.ID.sajt)
                    .ToList();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return sajtovi;
        }

        #endregion
        #region Agencija

        public static Agencija vratiAgencijuNeBasic(int idAgencije)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Agencija a = s.Load<Agencija>(idAgencije);

                s.Close();
                return a;
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return null;
        }
        public static void dodajAgenciju(AgencijaBasic agen)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Agencija a = new Entiteti.Agencija();

                a.naziv = agen.naziv;



                s.SaveOrUpdate(a);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        public static List<AgencijaPregled> vratiAgencije()
        {
            List<AgencijaPregled> agencije = new List<AgencijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StanNaDanv2.Entiteti.Agencija> sveAgencije = from o in s.Query<StanNaDanv2.Entiteti.Agencija>()
                                                                       select o;

                foreach (StanNaDanv2.Entiteti.Agencija p in sveAgencije)
                {
                    agencije.Add(new AgencijaPregled(p.Id, p.naziv));
                }

                s.Close();
            }
            catch (Exception ec)
            {


            }

            return agencije;
        }

        public static AgencijaBasic vratiAgenciju(int id)
        {
            AgencijaBasic a = new AgencijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Agencija o = s.Load<StanNaDanv2.Entiteti.Agencija>(id);
                a = new AgencijaBasic(o.Id, o.naziv);
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return a;
        }

        public static AgencijaBasic azurirajAgenciju(AgencijaBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Agencija o = s.Load<StanNaDanv2.Entiteti.Agencija>(a.AgencijaID);
                o.naziv = a.naziv;


                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return a;
        }

        public static void obrisiAgenciju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Agencija o = s.Load<StanNaDanv2.Entiteti.Agencija>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion
        #region Poslovnice 

        public static List<PoslovnicaPregled> VratiSvePoslovniceAgencije(int id)
        {
            List<PoslovnicaPregled> poslovnice = new List<PoslovnicaPregled>();
            try
            {


                ISession s = DataLayer.GetSession();

                IEnumerable<StanNaDanv2.Entiteti.Poslovnica> svePoslovnice = from o in s.Query<StanNaDanv2.Entiteti.Poslovnica>()
                                                                           where o.PripadaAgenciji.Id == id
                                                                           select o;

                foreach (StanNaDanv2.Entiteti.Poslovnica r in svePoslovnice)
                {
                    poslovnice.Add(new PoslovnicaPregled(r.Id, r.adresa, r.radno_vreme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return poslovnice;
        }

        public static void dodajPoslovnicu(PoslovnicaBasic v, AgencijaBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Poslovnica vl = new Entiteti.Poslovnica();

                vl.adresa = v.adresa;

                vl.radno_vreme = v.radno_vreme;

                //agencija postoji treba da je ucitamo

                StanNaDanv2.Entiteti.Agencija o = s.Load<StanNaDanv2.Entiteti.Agencija>(a.AgencijaID);

                vl.PripadaAgenciji = o;



                s.Save(vl);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static PoslovnicaBasic azurirajPoslovnicu(PoslovnicaBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Poslovnica o = s.Load<StanNaDanv2.Entiteti.Poslovnica>(a.PoslovnicaID);
                o.adresa = a.adresa;
                o.radno_vreme = a.radno_vreme;


                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return a;
        }


        public static PoslovnicaBasic vratiPoslovnicu(int id)
        {
            PoslovnicaBasic a = new PoslovnicaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Poslovnica o = s.Load<StanNaDanv2.Entiteti.Poslovnica>(id);
                a = new PoslovnicaBasic(o.Id, o.adresa, o.radno_vreme);
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return a;
        }


        public static void obrisiPoslovnicu(int id)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Poslovnica o = s.Load<StanNaDanv2.Entiteti.Poslovnica>(id);



                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        #endregion
        #region VLasnik
        public static List<VlasnikPregled> VratiVlasnikaAgencije(int id)
        {
            List<VlasnikPregled> vlasnik = new List<VlasnikPregled>();

            try
            {


                ISession s = DataLayer.GetSession();

                IEnumerable<StanNaDanv2.Entiteti.Vlasnik> sve = from o in s.Query<StanNaDanv2.Entiteti.Vlasnik>()
                                                              where o.agencija.Id == id
                                                              select o;

                foreach (StanNaDanv2.Entiteti.Vlasnik r in sve)
                {
                    vlasnik.Add(new VlasnikPregled(r.Id, r.broj_bankovnog_racuna, r.banka));
                }

                s.Close();
            }

            catch (Exception ec)
            {
                //handle exceptions
            }

            return vlasnik;
        }

        public static VlasnikBasic vratiVlasnika(int id)
        {
            VlasnikBasic a = new VlasnikBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Vlasnik o = s.Load<StanNaDanv2.Entiteti.Vlasnik>(id);
                a = new VlasnikBasic(o.Id, o.broj_bankovnog_racuna, o.banka);
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return a;
        }

        public static VlasnikBasic azurirajVlasnika(VlasnikBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.Vlasnik o = s.Load<StanNaDanv2.Entiteti.Vlasnik>(a.VlasnikID);
                o.broj_bankovnog_racuna = a.broj_bankovnog_racuna;
                o.banka = a.banka;


                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return a;
        }

        public static List<VlasnikPregled> vratiVlasnike()
        {
            List<VlasnikPregled> vlasnici = new List<VlasnikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StanNaDanv2.Entiteti.Vlasnik> sviVlasnici = from o in s.Query<StanNaDanv2.Entiteti.Vlasnik>()
                                                                      select o;

                foreach (StanNaDanv2.Entiteti.Vlasnik p in sviVlasnici)
                {
                    vlasnici.Add(new VlasnikPregled(p.Id, p.broj_bankovnog_racuna, p.banka));
                }

                s.Close();
            }
            catch (Exception ec)
            {


            }

            return vlasnici;
        }


        public static void dodajVlasnika(VlasnikBasic v, AgencijaBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Vlasnik vl = new Entiteti.Vlasnik();

                vl.banka = v.banka;

                vl.broj_bankovnog_racuna = v.broj_bankovnog_racuna;

                //agencija postoji treba da je ucitamo

                StanNaDanv2.Entiteti.Agencija o = s.Load<StanNaDanv2.Entiteti.Agencija>(a.AgencijaID);

                vl.agencija = o;



                s.SaveOrUpdate(vl);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void obrisiVlasnika(int id)
        {
            //obrisemo fizicko lice 




            try
            {
                ISession s = DataLayer.GetSession();


                List<FizickoLicePregled> novo = VratiFizickoLice(id);
                List<PravnoLicePregled> novi = VratiPravnoLice(id);

                if (novo.Count != 0)
                {

                    StanNaDanv2.Entiteti.FizickoLice f = s.Load<StanNaDanv2.Entiteti.FizickoLice>(novo[0].maticni_broj);

                    obrisiFizickoLice(f.maticni_broj);




                }

                if (novi.Count != 0)
                {

                    StanNaDanv2.Entiteti.PravnoLice p = s.Load<StanNaDanv2.Entiteti.PravnoLice>(novi[0].PIB);

                    obrisiPravnoLice(p.PIB);




                }




                StanNaDanv2.Entiteti.Vlasnik o = s.Load<StanNaDanv2.Entiteti.Vlasnik>(id);



                //obrisemo sva fizicka i pravna lica i sve brojeve telefona

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static List<FizickoLicePregled> VratiFizickoLice(int id)
        {
            List<FizickoLicePregled> fizickalica = new List<FizickoLicePregled>();
            try
            {


                ISession s = DataLayer.GetSession();

                IEnumerable<StanNaDanv2.Entiteti.FizickoLice> svalica = from o in s.Query<StanNaDanv2.Entiteti.FizickoLice>()
                                                                      where o.vlasnik.Id == id
                                                                      select o;

                foreach (StanNaDanv2.Entiteti.FizickoLice r in svalica)
                {
                    fizickalica.Add(new FizickoLicePregled(r.maticni_broj, r.ime, r.ime_roditelja, r.prezime, r.drzava, r.mesto, r.adresa, r.datum_rodjenja, r.email));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return fizickalica;
        }

        public static FizickoLiceBasic vratiFizickoLice(int id)
        {
            FizickoLiceBasic a = new FizickoLiceBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.FizickoLice o = s.Load<StanNaDanv2.Entiteti.FizickoLice>(id);
                a = new FizickoLiceBasic(o.maticni_broj, o.ime, o.ime_roditelja, o.prezime, o.drzava, o.mesto, o.adresa, o.datum_rodjenja, o.email);
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return a;
        }

        public static FizickoLiceBasic azurirajFizickoLice(FizickoLiceBasic fl)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.FizickoLice o = s.Load<StanNaDanv2.Entiteti.FizickoLice>(fl.maticni_broj);
                o.ime = fl.ime;
                o.ime_roditelja = fl.ime_roditelja;
                o.prezime = fl.prezime;
                o.drzava = fl.drzava;
                o.adresa = fl.adresa;
                o.mesto = fl.mesto;
                o.datum_rodjenja = fl.datum_rodjenja;
                o.email = fl.email;


                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return fl;
        }

        public static void obrisiFizickoLice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();



                StanNaDanv2.Entiteti.FizickoLice o = s.Load<StanNaDanv2.Entiteti.FizickoLice>(id);

                //trebba da prodje kroz listu telefona i da obrise svaki 

                foreach (var p in o.brojevi)
                {
                    obrisibrojF(p.ID.broj_telefona);

                }

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void dodajFizickoLice(FizickoLiceBasic v, VlasnikBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.FizickoLice vl = new Entiteti.FizickoLice();

                vl.maticni_broj = v.maticni_broj;
                vl.ime = v.ime;
                vl.ime_roditelja = v.ime_roditelja;
                vl.prezime = v.prezime;
                vl.drzava = v.drzava;
                vl.mesto = v.mesto;
                vl.adresa = v.adresa;
                vl.datum_rodjenja = v.datum_rodjenja;
                vl.email = v.email;


                //agencija postoji treba da je ucitamo

                StanNaDanv2.Entiteti.Vlasnik o = s.Load<StanNaDanv2.Entiteti.Vlasnik>(a.VlasnikID);

                vl.vlasnik = o;



                s.Save(vl);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static List<PravnoLicePregled> VratiPravnoLice(int id)
        {
            List<PravnoLicePregled> pravnalica = new List<PravnoLicePregled>();
            try
            {


                ISession s = DataLayer.GetSession();

                IEnumerable<StanNaDanv2.Entiteti.PravnoLice> svalica = from o in s.Query<StanNaDanv2.Entiteti.PravnoLice>()
                                                                     where o.vlasnik.Id == id
                                                                     select o;

                foreach (StanNaDanv2.Entiteti.PravnoLice r in svalica)
                {
                    pravnalica.Add(new PravnoLicePregled(r.PIB, r.ime, r.adresa_firme, r.ime_kontakt_osobe, r.email));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pravnalica;
        }


        public static PravnoLiceBasic vratiPravnoLice(int id)
        {
            PravnoLiceBasic a = new PravnoLiceBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.PravnoLice o = s.Load<StanNaDanv2.Entiteti.PravnoLice>(id);
                a = new PravnoLiceBasic(o.PIB, o.ime, o.adresa_firme, o.ime_kontakt_osobe, o.email);
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return a;
        }


        public static PravnoLiceBasic azurirajPravnoLice(PravnoLiceBasic pl)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.PravnoLice o = s.Load<StanNaDanv2.Entiteti.PravnoLice>(pl.PIB);
                o.ime = pl.ime;
                o.adresa_firme = pl.adresa_firme;
                o.ime_kontakt_osobe = pl.ime_kontakt_osobe;
                o.email = pl.email;


                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pl;
        }


        public static void dodajPravnoLice(PravnoLiceBasic v, VlasnikBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.PravnoLice pr = new Entiteti.PravnoLice();

                pr.PIB = v.PIB;
                pr.ime = v.ime;
                pr.adresa_firme = v.adresa_firme;
                pr.ime_kontakt_osobe = v.ime_kontakt_osobe;
                pr.email = v.email;




                StanNaDanv2.Entiteti.Vlasnik o = s.Load<StanNaDanv2.Entiteti.Vlasnik>(a.VlasnikID);

                pr.vlasnik = o;



                s.Save(pr);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        public static void obrisiPravnoLice(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StanNaDanv2.Entiteti.PravnoLice o = s.Query<StanNaDanv2.Entiteti.PravnoLice>()
                                                   .Where(b => b.PIB == id)
                                                   .FirstOrDefault();


                o.brojevi.Clear();



                ;


                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion
        #region BrojeviTelefona

        public static List<string> VratiBrojeveTelefona(int idfizlica)
        {
            List<string> brojevi = new List<string>();
            try
            {
                ISession s = DataLayer.GetSession();

                brojevi = s.Query<StanNaDanv2.Entiteti.BrojeviTelefonaFizickogLica>()
                    .Where(b => b.ID.fizickolicebroj.maticni_broj == idfizlica)
                    .Select(b => b.ID.broj_telefona.ToString())
                    .ToList();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return brojevi;
        }

        public static List<string> VratiBrojeveTelefonaP(int id)
        {
            List<string> brojevi = new List<string>();
            try
            {
                ISession s = DataLayer.GetSession();

                brojevi = s.Query<StanNaDanv2.Entiteti.BrojeviTelefonaPravnogLica>()
                    .Where(b => b.ID.pravnolicebroj.PIB == id)
                    .Select(b => b.ID.broj_telefona.ToString())
                    .ToList();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return brojevi;
        }

        public static void dodajbrojfl(FizickoLiceBasic f, BrojeviTelefonaFizickogLicaBasic brt)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StanNaDanv2.Entiteti.FizickoLice fl = s.Load<Entiteti.FizickoLice>(f.maticni_broj);

                StanNaDanv2.Entiteti.BrojeviTelefonaFizickogLica broj = new StanNaDanv2.Entiteti.BrojeviTelefonaFizickogLica();
                StanNaDanv2.Entiteti.IDBrTelFL idje = new StanNaDanv2.Entiteti.IDBrTelFL();

                idje.fizickolicebroj = fl;
                idje.broj_telefona = brt.IDbroja.broj_telefona;

                broj.ID = idje;

                fl.brojevi.Add(broj);

                s.Save(broj);



                s.Flush();

           

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }


        }

        public static void dodajbrojpl(PravnoLiceBasic f, BrojeviTelefonaPravnogLicaBasic brt)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StanNaDanv2.Entiteti.PravnoLice fl = s.Load<Entiteti.PravnoLice>(f.PIB);

                StanNaDanv2.Entiteti.BrojeviTelefonaPravnogLica broj = new StanNaDanv2.Entiteti.BrojeviTelefonaPravnogLica();
                StanNaDanv2.Entiteti.IDBrTelPL idje = new StanNaDanv2.Entiteti.IDBrTelPL();

                idje.pravnolicebroj = fl;
                idje.broj_telefona = brt.IDbroja.broj_telefona;

                broj.ID = idje;

                fl.brojevi.Add(broj);

                s.Save(broj);



                s.Flush();

           

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }


        }


        public static void obrisibrojF(int broj)
        {
            try
            {
                //id je zapravo sam broj telefona i ja mogu da nadjem 

                ISession s = DataLayer.GetSession();



                StanNaDanv2.Entiteti.BrojeviTelefonaFizickogLica p = new Entiteti.BrojeviTelefonaFizickogLica();

                p = s.Query<StanNaDanv2.Entiteti.BrojeviTelefonaFizickogLica>()
                         .Where(b => b.ID.broj_telefona == broj)
                         .FirstOrDefault();

                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void obrisibrojP(int broj)
        {
            try
            {
                //id je zapravo sam broj telefona i ja mogu da nadjem 

                ISession s = DataLayer.GetSession();



                StanNaDanv2.Entiteti.BrojeviTelefonaPravnogLica p = new Entiteti.BrojeviTelefonaPravnogLica();

                p = s.Query<StanNaDanv2.Entiteti.BrojeviTelefonaPravnogLica>()
                         .Where(b => b.ID.broj_telefona == broj)
                         .FirstOrDefault();

                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        #endregion
        #region Dodaci

        public static void obrisiDodatak(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dodaci d = s.Load<Dodaci>(id);

                s.Delete(d);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static List<DodaciPregled> vratiDodatkeNekretnine(int nekretninaID)
        {
            List<DodaciPregled> dodaciPregled = new List<DodaciPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Dodaci> dodaci = new List<Dodaci>();

                dodaci = from o in s.Query<Dodaci>()
                         where o.nekretnina.nekretninaID == nekretninaID
                         select o;

                foreach(Dodaci d in dodaci)
                {
                    dodaciPregled.Add(new DodaciPregled(d.Id, d.TipDodatka, nekretninaID, "kuca"));
                }

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return dodaciPregled;
        }
        public static Entiteti.Dodaci vratiDodatak(int id)
        {
            Entiteti.Dodaci dodatak = null;
            try
            {
                ISession s = DataLayer.GetSession();

                dodatak = s.Load<Dodaci>(id);

                s.Delete(dodatak);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return dodatak;
        }

        public static void azurirajDodatnuOpremu(DodatnaOpremaBasic dodatnaOpremaBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DodatnaOprema dodatna = s.Load<DodatnaOprema>(dodatnaOpremaBasic.DodatnaOpremaId);

                dodatna.Doplata = dodatnaOpremaBasic.Doplata;
                dodatna.TipDodatneOpreme = dodatnaOpremaBasic.TipDodatneOpreme;

                s.Update(dodatna);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {

            }
        }
        public static List<DodaciPregled> vratiSveDodatkePregled()
        {
            List<DodaciPregled> dodaci = new List<DodaciPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Dodaci> sviDodaci = from o in s.Query<Dodaci>()
                                                select o;

                foreach (Dodaci d in sviDodaci)
                {
                    if (d.nekretnina.FKuca == true)
                    {
                        dodaci.Add(new DodaciPregled(d.Id, d.TipDodatka, d.nekretnina.nekretninaID, "Kuca"));
                    }
                    else
                    {
                        dodaci.Add(new DodaciPregled(d.Id,d.TipDodatka, d.nekretnina.nekretninaID, "Stan"));
                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {

            }

            return dodaci;
        }
        public static void obrisiDodatnuOpremu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.DodatnaOprema dodatak = s.Load<DodatnaOprema>(id);
                s.Delete(dodatak);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {

            }
        }



        public static List<DodaciBasic> GetDodaciInfo(int idNekretnine)
        {
            List<DodaciBasic> dodaciInfo = new List<DodaciBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Dodaci> dodaci = from d in s.Query<Dodaci>()
                                             where d.nekretnina.nekretninaID == idNekretnine
                                             select d;
                foreach (Dodaci d in dodaci)
                {
                    dodaciInfo.Add(new DodaciBasic(d.Id, d.TipDodatka, d.nekretnina));
                }

                s.Close();
            }
            catch (Exception ec)
            {

            }

            return dodaciInfo;
        }
        #region DodatnaOprema
        public static DodatnaOpremaBasic vratiDodatnuOpremu(int id)
        {
            DodatnaOpremaBasic d = new DodatnaOpremaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                DodatnaOprema dodatna = s.Load<DodatnaOprema>(id);

                d.Doplata = dodatna.Doplata;
                d.DodatnaOpremaId = dodatna.Id;
                d.TipDodatneOpreme = dodatna.TipDodatneOpreme;
                d.nekretnina = dodatna.nekretnina;

                s.Close();
            }
            catch (Exception ec)
            {

            }
            return d;
        }

        public static List<DodatnaOpremaBasic> vratiDodatnuOpremuNekretnine(int nekretninaID)
        {
            List<DodatnaOpremaBasic> dodatnaInfos = new List<DodatnaOpremaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<DodatnaOprema> oprema = from d in s.Query<DodatnaOprema>()
                                                    where d.nekretnina.nekretninaID == nekretninaID
                                                    select d;

                foreach (DodatnaOprema d in oprema)
                {
                    dodatnaInfos.Add(new DodatnaOpremaBasic(d.Id, d.TipDodatneOpreme, d.Doplata, d.nekretnina));
                }

                s.Close();
            }
            catch (Exception ec)
            {

            }

            return dodatnaInfos;
        }

        public static void izmeniDodatnuOpremu(DodatnaOpremaBasic oprema)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DodatnaOprema d = s.Load<DodatnaOprema>(oprema.DodatnaOpremaId);

                d.Doplata = oprema.Doplata;
                d.TipDodatneOpreme = oprema.TipDodatneOpreme;

                s.SaveOrUpdate(d);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }


        public static void sacuvajDodatnuOpremu(DodatnaOpremaBasic oprema)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DodatnaOprema d = new DodatnaOprema();

                d.Doplata = oprema.Doplata;
                d.TipDodatka = "DodatnaOprema";
                d.TipDodatneOpreme = oprema.TipDodatneOpreme;

                d.nekretnina = s.Load<Nekretnina>(oprema.nekretnina.nekretninaID);

                s.Save(d);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {

            }
        }
        #endregion
        #region Kuhinja

        public static void azurirajKuhinju(KuhinjaBasic kuhinja)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kuhinja kuhinjica = s.Load<Kuhinja>(kuhinja.KuhinjaId);

                kuhinjica.Posudje = kuhinja.Posudje;

                s.Update(kuhinjica);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }
        public static void obrisiKuhinju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kuhinja kuhinja = s.Load<Kuhinja>(id);

                s.Delete(kuhinja);
                s.Flush();
                s.Close();
            }
            catch (Exception e) { }
        }

        public static KuhinjaBasic vratiKuhinju(int id)
        {
            KuhinjaBasic k = new KuhinjaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Kuhinja kuhinja = s.Load<Kuhinja>(id);

                k.KuhinjaId = kuhinja.Id;
                k.Posudje = kuhinja.Posudje;

                s.Close();
            }
            catch (Exception e) { }
            return k;
        }

        public static List<KuhinjaPregled> vratiKuhinjuNekretnine(int nekretninaID)
        {
            List<KuhinjaPregled> kuhinjaInfos = new List<KuhinjaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Kuhinja> kuhinje = from k in s.Query<Kuhinja>()
                                               where k.nekretnina.nekretninaID == nekretninaID
                                               select k;
                foreach (Kuhinja k in kuhinje)
                {
                    if (k.nekretnina.FStan)
                    {
                        kuhinjaInfos.Add(new KuhinjaPregled(k.Id, k.Posudje, "Stan"));
                    }
                    else
                    {
                        kuhinjaInfos.Add(new KuhinjaPregled(k.Id, k.Posudje, "Kuca"));
                    }
                }

                s.Close();
            }
            catch (Exception ec)
            {

            }

            return kuhinjaInfos;
        }

        public static void izmeniKuhinju(KuhinjaBasic kuhinja)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kuhinja k = s.Load<Kuhinja>(kuhinja.KuhinjaId);

                k.Posudje = kuhinja.Posudje;

                s.SaveOrUpdate(k);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static void sacuvajKuhinju(KuhinjaBasic kuhinja)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kuhinja k = new Kuhinja();

                k.nekretnina = s.Load<Nekretnina>(kuhinja.nekretnina.nekretninaID);
                k.Posudje = kuhinja.Posudje;
                k.TipDodatka = "Kuhinja";

                s.SaveOrUpdate(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ec) { }
        }
        #endregion

        #region Krevet
        public static void azurirajKrevet(KrevetBasic krevetBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Krevet krevet= s.Load<Krevet>(krevetBasic.KrevetId);

                krevet.TipKreveta= krevetBasic.TipKreveta;
                krevet.Dimenzije= krevetBasic.DimenzijeKreveta;

                s.Update(krevet);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {

            }
        }
        public static void obrisiKrevet(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Krevet k = s.Load<Krevet>(id);

                s.Delete(k);

                s.Flush();

                s.Close();
            }
            catch (Exception ec) { }
        }


        public static KrevetBasic vratiKrevet(int id)
        {
            KrevetBasic k = new KrevetBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Krevet krevet = s.Load<Krevet>(id);

                k.TipKreveta = krevet.TipKreveta;
                k.KrevetId = krevet.Id;
                k.DimenzijeKreveta = krevet.Dimenzije;

                s.Close();
            }
            catch (Exception ec) { }

            return k;

        }


        public static List<KrevetPregled> vratiKreveteNekretnine(int nekretninaID)
        {
            List<KrevetPregled> krevetiInfos = new List<KrevetPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Krevet> kreveti = from k in s.Query<Krevet>()
                                              where k.nekretnina.nekretninaID == nekretninaID
                                              select k;

                foreach (Krevet k in kreveti)
                {
                    if (k.nekretnina.FStan)
                    {
                        krevetiInfos.Add(new KrevetPregled(k.Id, k.TipKreveta, k.Dimenzije, k.nekretnina.nekretninaID, "Stan"));

                    }
                    else
                    {
                        krevetiInfos.Add(new KrevetPregled(k.Id, k.TipKreveta, k.Dimenzije, k.nekretnina.nekretninaID, "Kuca"));
                    }
                }
                s.Close();
            }
            catch (Exception ec) { }
            return krevetiInfos;
        }

        public static void izmeniKrevet(KrevetBasic krevet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Krevet k = s.Load<Krevet>(krevet.KrevetId);

                k.TipKreveta = krevet.TipKreveta;
                k.Dimenzije = krevet.DimenzijeKreveta;

                s.SaveOrUpdate(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static void sacuvajKrevet(KrevetBasic krevet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Krevet k = new Krevet();

                k.nekretnina = s.Load<Nekretnina>(krevet.nekretnina.nekretninaID);
                k.Dimenzije = krevet.DimenzijeKreveta;
                k.TipKreveta = krevet.TipKreveta;
                k.TipDodatka = "Krevet";

                s.Save(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ec) { }
        }
        #endregion

        #region ParkingMesto

        public static void azurirajParkingMesto(ParkingMestoBasic parkingMesto)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ParkingMesto mesto = s.Load<ParkingMesto>(parkingMesto.ParkingMestoId);

                mesto.LokacijaParkingMesta = parkingMesto.Lokacija;
                mesto.CenaParkingMesta = parkingMesto.CenaParkingMesta;

                s.Update(mesto);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void obrisiParkingMesto(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ParkingMesto parking = s.Load<ParkingMesto>(id);

                s.Delete(parking);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static ParkingMestoBasic vratiParkingMesto(int id)
        {
            ParkingMestoBasic p = new ParkingMestoBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                ParkingMesto parking = s.Load<ParkingMesto>(id);

                p.Lokacija = parking.LokacijaParkingMesta;
                p.CenaParkingMesta = parking.CenaParkingMesta;
                p.ParkingMestoId = parking.Id;

                p.nekretnina = parking.nekretnina;

                s.Close();
            }
            catch (Exception ec) { }
            return p;
        }


        public static List<ParkingMestoPregled> vratiParkingMestaNekretnine(int nekretninaId)
        {
            List<ParkingMestoPregled> parkingInfos = new List<ParkingMestoPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ParkingMesto> parkinzi = from p in s.Query<ParkingMesto>()
                                                     where p.nekretnina.nekretninaID == nekretninaId
                                                     select p;

                foreach (ParkingMesto p in parkinzi)
                {
                    if (p.nekretnina.FKuca)
                    {
                        parkingInfos.Add(new ParkingMestoPregled(p.Id, p.LokacijaParkingMesta, p.CenaParkingMesta, p.nekretnina.nekretninaID, "Kuca"));
                    }
                    else
                    {
                        parkingInfos.Add(new ParkingMestoPregled(p.Id, p.LokacijaParkingMesta, p.CenaParkingMesta, p.nekretnina.nekretninaID, "Stan"));

                    }
                }

                s.Close();
            }
            catch (Exception e) { }

            return parkingInfos;
        }


        public static void izmeniParkingMesto(ParkingMestoBasic parking)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ParkingMesto p = s.Load<ParkingMesto>(parking.ParkingMestoId);

                p.nekretnina = parking.nekretnina;
                p.CenaParkingMesta = parking.CenaParkingMesta;
                p.LokacijaParkingMesta = parking.Lokacija;
                p.TipDodatka = "ParkingMesto";

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }


        public static void sacuvajParkingMesto(ParkingMestoBasic parking)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ParkingMesto p = new ParkingMesto();

                p.LokacijaParkingMesta = parking.Lokacija;
                p.CenaParkingMesta = parking.CenaParkingMesta;
                p.nekretnina = s.Load<Nekretnina>(parking.nekretnina.nekretninaID);
                p.TipDodatka = "ParkingMesto";

                s.Save(p);
                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {

            }
        }
        #endregion
        #endregion
        #region SpoljniSaradnik

        public static SpoljniSaradnik vratiSpoljnogSaradnikaNeBasic(SpoljniSaradnikID id)
        {
            SpoljniSaradnik ss = null;
            try
            {
                ISession s = DataLayer.GetSession();

                ss = s.Load<SpoljniSaradnik>(id);

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return ss;
        }
        public static List<SpoljniSaradnikPregled> vratiSveSpoljneSaradnikeAgenta(string matbr_agenta)
        {
            List<SpoljniSaradnikPregled> saradnici = new List<SpoljniSaradnikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<SpoljniSaradnik> sviSaradnici = from o in s.Query<SpoljniSaradnik>()
                                                            where o.Id.UnajmioAgent.maticni_broj_zaposlenog == matbr_agenta
                                                            select o;

                foreach (SpoljniSaradnik o in sviSaradnici)
                {
                    
                    saradnici.Add(new SpoljniSaradnikPregled(o.Id.UnajmioAgent.ime, o.Id.UnajmioAgent.maticni_broj_zaposlenog, o.Id.BrojTelefona,
                        o.Ime, o.DatumAngazovanja, o.Procenat, "Stan"));
             
                }

                s.Close();
            }
            catch(Exception ec)
            {

            }

            return saradnici;
        }
        public static List<SpoljniSaradnikPregled> vratiSveSpoljneSaradnike()
        {
            List<SpoljniSaradnikPregled> saradnici = new List<SpoljniSaradnikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<SpoljniSaradnik> sviSaradnici = from o in s.Query<SpoljniSaradnik>()
                                                            select o;

                foreach (SpoljniSaradnik o in sviSaradnici)
                {
                   
                    saradnici.Add(new SpoljniSaradnikPregled(o.Id.UnajmioAgent.ime, o.Id.UnajmioAgent.maticni_broj_zaposlenog, o.Id.BrojTelefona,
                        o.Ime, o.DatumAngazovanja, o.Procenat, "Stan"));
                    
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return saradnici;

        }



        public static void dodajSpoljnogSaradnika(SpoljniSaradnikBasic spoljniSaradnikBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpoljniSaradnik saradnik = new SpoljniSaradnik();
                saradnik.Id = new SpoljniSaradnikID();
                saradnik.Id.UnajmioAgent = spoljniSaradnikBasic.Id.UnajmioAgent;
                saradnik.Id.BrojTelefona = spoljniSaradnikBasic.BrojTelefona;

                saradnik.DatumAngazovanja = spoljniSaradnikBasic.DatumAngazovanja;
                //saradnik.UcestvovaoUNajam = spoljniSaradnikBasic.UcestvovaoNajam;
                saradnik.Procenat = spoljniSaradnikBasic.Procenat;


                s.SaveOrUpdate(saradnik);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static SpoljniSaradnikBasic izmeniSpoljnogSaradnika(SpoljniSaradnikBasic saradnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpoljniSaradnik o = s.Load<SpoljniSaradnik>(saradnik.Id);

                o.DatumAngazovanja = saradnik.DatumAngazovanja;
                //o.UcestvovaoUNajam = saradnik.UcestvovaoNajam;
                o.Procenat = saradnik.Procenat;

                s.Update(o);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return saradnik;
        }


        public static SpoljniSaradnikBasic vratiSpoljnogSaradnika(SpoljniSaradnikID id)
        {
            SpoljniSaradnikBasic ss = new SpoljniSaradnikBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                SpoljniSaradnik sp = s.Load<SpoljniSaradnik>(id);

                ss = new SpoljniSaradnikBasic(sp.Id, sp.Id.UnajmioAgent, sp.Id.BrojTelefona, sp.Ime, sp.DatumAngazovanja, sp.Procenat);
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return ss;
        }


        public static void obrisiSpoljnogSaradnika(SpoljniSaradnikID id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpoljniSaradnik saradnik = s.Load<SpoljniSaradnik>(id);

                s.Delete(saradnik);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        #endregion
        #region Najam

        public static List<NajamPregled> vratiNajmoveAgentaNotNull(string matbr_agenta)
        {
            List<NajamPregled> najmovi = new List<NajamPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Najam> sviNajmovi = from o in s.Query<Najam>()
                                                where o.UcestvovaoAgent.maticni_broj_zaposlenog == matbr_agenta && o.UcestvovaoSaradnik == null
                                                select o;

                foreach(Najam n in sviNajmovi)
                {
                    if (n.IznajmljenaNekretnina.FKuca)
                    {
                        najmovi.Add(new NajamPregled(n.Id, n.DatumPocetka, n.DatumZavrsetka,
                            n.CenaPoDanu, n.BrojDana, n.UkupnaCena, n.Popust, n.CenaSaPopustom,
                            n.UcestvovaoAgent.ime, n.OrganizujeAgencija.naziv, "Kuca"));
                    }
                    else
                    {
                        najmovi.Add(new NajamPregled(n.Id, n.DatumPocetka, n.DatumZavrsetka,
                           n.CenaPoDanu, n.BrojDana, n.UkupnaCena, n.Popust, n.CenaSaPopustom,
                           n.UcestvovaoAgent.ime, n.OrganizujeAgencija.naziv, "Stan"));
                    }
                }

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }


            return najmovi;
        }

        public static Najam vratiNajamNeBasic(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Najam najam = s.Load<Najam>(id);

                s.Close();

                return najam;
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);

                return null;
            }
        }
        public static List<NajamBasic> vratiSveNajmoveBasic()
        {
            List<NajamBasic> najmovi = new List<NajamBasic>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Najam> sviNajmovi = from o in s.Query<Najam>()
                                                select o;

                foreach (Najam n in sviNajmovi)
                {
                    najmovi.Add(new NajamBasic(n.Id, n.DatumPocetka, n.DatumZavrsetka, n.CenaPoDanu, n.BrojDana, n.UkupnaCena, n.Popust
                        , n.CenaSaPopustom, n.UcestvovaoAgent, n.OrganizujeAgencija, n.IznajmljenaNekretnina));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return najmovi;
        }

        public static List<NajamPregled> vratiSveNajmovePregled()
        {
            List<NajamPregled> najmovi = new List<NajamPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Najam> sviNajmovi = from o in s.Query<Najam>()
                                                select o;

                foreach (Najam n in sviNajmovi)
                {
                    if (n.IznajmljenaNekretnina.FStan)
                    {
                        najmovi.Add(new NajamPregled(n.Id, n.DatumPocetka, n.DatumZavrsetka, n.CenaPoDanu, n.BrojDana, n.UkupnaCena, n.Popust,
                            n.CenaPoDanu, n.UcestvovaoAgent.ime, n.OrganizujeAgencija.naziv, "Stan"));
                    }
                    else
                    {
                        najmovi.Add(new NajamPregled(n.Id, n.DatumPocetka, n.DatumZavrsetka, n.CenaPoDanu, n.BrojDana, n.UkupnaCena, n.Popust,
                           n.CenaPoDanu, n.UcestvovaoAgent.ime, n.OrganizujeAgencija.naziv, "Kuca"));
                    }
                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return najmovi;
        }


        public static void dodajNajam(NajamBasic najam)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Najam n = new Najam();
                n.BrojDana = najam.BrojDana;
                n.CenaPoDanu = najam.CenaPoDanu;

                n.UcestvovaoAgent = najam.Agent;
                n.OrganizujeAgencija = najam.Agencija;
                n.IznajmljenaNekretnina = najam.IznajmljenaNekretnina;

                n.DatumPocetka = najam.DatumPocetka;
                n.DatumZavrsetka = najam.DatumZavrsetka;

                n.UkupnaCena = najam.UkupnaCena;

                s.SaveOrUpdate(n);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }


        public static NajamBasic azurirajNajam(NajamBasic n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Najam najam = s.Load<Najam>(n.NajamId);

                najam.DatumPocetka = n.DatumPocetka;
                najam.DatumZavrsetka = n.DatumZavrsetka;

                najam.BrojDana = n.BrojDana;
                najam.CenaPoDanu = n.CenaPoDanu;
                najam.UkupnaCena = n.UkupnaCena;

                najam.Popust = n.Popust;
                najam.CenaSaPopustom = n.CenaSaPopustom;

                s.Update(najam);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return n;
        }

        public static NajamBasic vratiNajam(int id)
        {
            NajamBasic nb = new NajamBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Najam n = s.Load<Najam>(id);

                nb = new NajamBasic(n.Id, n.DatumPocetka, n.DatumZavrsetka, n.CenaPoDanu, n.BrojDana, n.UkupnaCena, n.Popust, n.CenaSaPopustom, n.UcestvovaoAgent, n.OrganizujeAgencija, n.IznajmljenaNekretnina);

                s.Close();
            }
            catch (Exception ec) { Console.WriteLine(); }
            return nb;
        }

        public static void obrisiNajamIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Najam n = s.Load<Najam>(id);

                s.Delete(n);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        


        public static Nekretnina vratiNekretninu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nekretnina n = s.Load<Nekretnina>(id);

                s.Close();
                return n;
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return null;
        }


        public static List<NajamPregled> vratiSveNajmovePregledAgencije(AgencijaBasic agencija)
        {
            List<NajamPregled> listaNajmova = new List<NajamPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Najam> najmovi = from o in s.Query<Najam>()
                                      where o.OrganizujeAgencija.Id == agencija.AgencijaID
                                      select o;

                foreach(Najam n in najmovi)
                {
                    listaNajmova.Add(new NajamPregled(n.Id, n.DatumPocetka, n.DatumZavrsetka, n.CenaPoDanu, n.BrojDana, n.UkupnaCena, n.Popust,
                        n.CenaSaPopustom, n.UcestvovaoAgent.ime, n.OrganizujeAgencija.naziv, n.IznajmljenaNekretnina.ime_ulice));
                }

                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return listaNajmova;
        }
        #endregion
        #region Mesta

        public static List<string> vratiMesta(int id)
        {
            List<string> mesta = new List<string>();
            try
            {
                ISession s = DataLayer.GetSession();

                mesta = s.Query<StanNaDanv2.Entiteti.RaspolozivaMesta>()
                    .Where(b => b.ID.nekretnina.nekretninaID == id)
                    .Select(b => b.ID.raspoloziva_mesta)
                    .ToList();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return mesta;
        }


        public static void obrisiMesto(string naziv)
        {
            try
            {


                ISession s = DataLayer.GetSession();



                StanNaDanv2.Entiteti.RaspolozivaMesta p = new Entiteti.RaspolozivaMesta();

                p = s.Query<StanNaDanv2.Entiteti.RaspolozivaMesta>()
                         .Where(b => b.ID.raspoloziva_mesta == naziv)
                         .FirstOrDefault();

                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }


        public static void dodajRaspolozivoMesto(NekretninaBasic f, RaspolozivaMestaBasic brt)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StanNaDanv2.Entiteti.Nekretnina fl = s.Load<Entiteti.Nekretnina>(f.nekretninaID);

                StanNaDanv2.Entiteti.RaspolozivaMesta mesto = new StanNaDanv2.Entiteti.RaspolozivaMesta();
                StanNaDanv2.Entiteti.RaspolozivaMestaNekretnine mesnek = new StanNaDanv2.Entiteti.RaspolozivaMestaNekretnine();

                mesnek.nekretnina = fl;
                mesnek.raspoloziva_mesta = brt.id.raspoloziva_mesta;

                mesto.ID = mesnek;

                fl.raspoloziva_mesta.Add(mesto);

                s.Save(mesto);



                s.Flush();

       

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }


        }

        #endregion
    }
}
