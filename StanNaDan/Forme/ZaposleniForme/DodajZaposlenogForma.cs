using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace StanNaDanv2.Forme
{
    public partial class DodajZaposlenogForma : Form
    {
        PoslovnicaBasic poslovnica;
        public DodajZaposlenogForma()
        {
            InitializeComponent();
        }
        public DodajZaposlenogForma(PoslovnicaBasic p)
        {
            InitializeComponent();
            poslovnica = p;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZaposleniBasic radnik = new ZaposleniBasic();
            radnik.maticni_broj_zaposlenog = textBox1.Text;
            radnik.ime = textBox3.Text;
            radnik.datum_zaposlenja = dateTimePicker1.Value;
            radnik.Poslovnica = poslovnica;
            radnik.Agencija = poslovnica.pripadaAgenciji;
            radnik.FSef = false;
            radnik.FAgent = false;
           

            DTOManager.dodajZaposlenog(radnik);

            //Dodavanje RadiU
          //  dodajRadniOdnos();

            MessageBox.Show("Uspesno ste dodali novog zaposlenog!");
            this.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DodajZaposlenogForma_Load(object sender, EventArgs e)
        {

        }
    }
}
