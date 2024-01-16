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
    public partial class IzmeniKucuForma : Form
    {
       KucaBasic o;
        public IzmeniKucuForma()
        {
            InitializeComponent();
        }
        public IzmeniKucuForma(KucaBasic a)
        {
            InitializeComponent();
           o = a;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
         
            o.ime_ulice = ime_ulice.Text;
            o.povrsina = (int)povrsina.Value;
            o.broj_kupatila = (int)brkupatila.Value;
            o.broj_spavacih_soba = (int)brspavacihsoba.Value;
            o.broj_terasa = (int)brterasa.Value;
            o.SPRATNOST = (int)brspratnost.Value;
            o.kucnibroj = (int)Kucni.Value;
          



            if (Dvoriste.Checked == true)
                o.DVORISTE = true;
            else
                o.DVORISTE = false;
            if (Tv.Checked == true)
                o.TV_PRIKLJUCAK = true;
            else
                o.TV_PRIKLJUCAK = false;
            if (Internet.Checked == true)
                o.internet = true;
            else
                o.internet = false;

            DTOManager.izmeniKucu(o);
            MessageBox.Show("Uspesno ste izmenili kucu!");
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ime_ulice_TextChanged(object sender, EventArgs e)
        {

        }

        private void brspratnost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void brspavacihsoba_ValueChanged(object sender, EventArgs e)
        {

        }

        private void brterasa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void brkupatila_ValueChanged(object sender, EventArgs e)
        {

        }

        private void povrsina_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Kucni_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Internet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dvoriste_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
