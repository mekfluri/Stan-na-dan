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
    public partial class KvartDodajForma : Form
    {
        PoslovnicaBasic poslovnica;
        public KvartDodajForma()
        {
            InitializeComponent();
        }
        public KvartDodajForma(PoslovnicaBasic po)
        {
            InitializeComponent();
            poslovnica = po;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KvartBasic o = new KvartBasic();
            o.broj_nekretnina = (int)numericUpDown1.Value;
            o.gradska_zona = textBox1.Text;
            o.poslovnica = poslovnica; 
            DTOManager.dodajKvart(o);
            MessageBox.Show("Uspesno ste dodali novi kvart!");
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
