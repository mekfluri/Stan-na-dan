using StanNaDanv2.Forme.DodaciForme.formeDodavanje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanNaDanv2.Forme
{
    public partial class DodajDodatak : Form
    {
        int nekretninaID;
        public DodajDodatak(int n)
        {
            nekretninaID = n;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //DodaciBasic dodatak = new DodaciBasic();

            //dodatak.NekretninaDodatka = nekretnina;
            if (radioButtonDodatnaOprema.Checked)
            {
                DodatnaOpremaBasic dodatak = new DodatnaOpremaBasic();
                dodatak.nekretnina = DTOManager.vratiNekretninu(nekretninaID);
                dodatak.TipDodatka = "DodatnaOprema";
                //forma
                DodajDodatnuOpremuForma forma = new DodajDodatnuOpremuForma(dodatak);
                forma.ShowDialog();
                forma.Close();

            }
            else if (radioButtonKrevet.Checked)
            {
                KrevetBasic krevet = new KrevetBasic();
                krevet.nekretnina = DTOManager.vratiNekretninu(nekretninaID);
                krevet.TipDodatka = "Krevet";
                
                //forma
                DodajKrevetForma forma = new DodajKrevetForma(krevet);
                forma.ShowDialog();
                forma.Close();

            }
            else if (radioButtonKuhinja.Checked)
            {
                KuhinjaBasic dodatak = new KuhinjaBasic();
                dodatak.nekretnina = DTOManager.vratiNekretninu(nekretninaID);
                dodatak.TipDodatka = "Kuhinja";
                //forma
                DodajKuhinjuForma forma = new DodajKuhinjuForma(dodatak);
                forma.ShowDialog();
                forma.Close();
            }else if (radioButtonParkingMesto.Checked)
            {
                ParkingMestoBasic dodatak = new ParkingMestoBasic();
                dodatak.nekretnina = DTOManager.vratiNekretninu(nekretninaID);
                dodatak.TipDodatka = "ParkingMesto";
                //forma
                DodajParkingMestoForma forma = new DodajParkingMestoForma(dodatak);
                forma.ShowDialog();
                forma.Close();
            }

        }

        private void DodajDodatak_Load(object sender, EventArgs e)
        {
            
            
        }
        
    }
}
