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
    public partial class IzmeniStanForma : Form
    {
        StanBasic o;
        public IzmeniStanForma()
        {
            InitializeComponent();
        }
        public IzmeniStanForma(StanBasic a)
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
            o.SPRAT = (int)spratnum.Value;
            o.kucnibroj = (int)Kucni.Value;




            if (lift.Checked == true)
                o.LIFT= true;
            else
                o.LIFT = false;
            if (Tv.Checked == true)
                o.TV_PRIKLJUCAK = true;
            else
                o.TV_PRIKLJUCAK = false;
            if (Internet.Checked == true)
                o.internet = true;
            else
                o.internet = false;

            DTOManager.izmeniStan(o);
            MessageBox.Show("Uspesno ste izmenili stan!");
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
