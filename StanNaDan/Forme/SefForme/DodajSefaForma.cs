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
    public partial class DodajSefaForma : Form
    {
        PoslovnicaBasic poslovnica;
        public DodajSefaForma()
        {
            InitializeComponent();
        }
        public DodajSefaForma(PoslovnicaBasic pos)
        {
            InitializeComponent();
            poslovnica = pos;
        }



        private void DodajSefa_Load(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            SefBasic o = new SefBasic();
            o.maticni_broj_zaposlenog = maticni_broj.Text;
            o.ime = ime.Text;
            o.datum_postavljanja = datum_postavljanja.Value;
            o.datum_zaposlenja = datum_zaposlenja.Value;
            o.Poslovnica = poslovnica;
            
    
            DTOManager.DodajSefa(o);
            MessageBox.Show("Uspesno ste dodali sefa!");
            this.Close();




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maticni_broj_TextChanged(object sender, EventArgs e)
        {

        }

        private void ime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void datum_zaposlenja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void datum_postavljanja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
