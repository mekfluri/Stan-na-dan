using StanNaDanv2.Entiteti;
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
    public partial class DodajNajam : Form
    {
        public DodajNajam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nekretninaID = Int32.Parse(textBoxNekretninaID.Text);
            string maticniBrojAgenta = textBoxAgentMATBR.Text;
            int agencijaID = Int32.Parse(textBoxAgencijaID.Text);
            DateTime datumPocetka = DatumPocetkaNajma.Value;
            DateTime datumZavrsetka = DatumKrajaNajma.Value;

            double CenaPoDanu = double.Parse(textBoxCenaPoDanu.Text);
            int brojDana =(int)((datumZavrsetka - datumPocetka).TotalDays);

            double UkupnaCena = CenaPoDanu * brojDana;

            Entiteti.Nekretnina nekretnina = DTOManager.vratiNekretninu(nekretninaID);//DTOManager.vratiNekretninu(nekretninaID);
            Entiteti.Agent agent = DTOManager.vratiAgentaNeBasic(maticniBrojAgenta);//DTOManager.vratiAgenta(maticniBrojAgenta);
            Entiteti.Agencija agencija = DTOManager.vratiAgencijuNeBasic(agencijaID);// DTOManager.vratiAgenciju(agencijaID);
            double Popust = (double)(numericUpDown1.Value);
            
            NajamBasic najam = new NajamBasic(-1, datumPocetka, datumZavrsetka, CenaPoDanu, brojDana, UkupnaCena, Popust, UkupnaCena * Popust, agent, agencija,nekretnina);
            DTOManager.dodajNajam(najam);
            Close();
        }

        private void DodajNajam_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
