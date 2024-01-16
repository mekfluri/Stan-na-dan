using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using System.Windows.Forms;
using StanNaDanv2.Entiteti;
using StanNaDanv2.Forme;
using StanNaDanv2.Forme.ZaposleniForme;

namespace StanNaDanv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               KvartDodajForma kvart=new KvartDodajForma();
                kvart.ShowDialog();
            }catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                IzmeniKvartForma kvart = new IzmeniKvartForma();
                kvart.ShowDialog();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

     

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                KvartForma kvart = new KvartForma();
                kvart.ShowDialog();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                KucaForma kvart = new KucaForma();
                kvart.ShowDialog();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormaZaListuAgencija a = new FormaZaListuAgencija();
            a.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           ZaposleniSveForma a = new ZaposleniSveForma();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            NajamForm forma = new NajamForm();
            forma.ShowDialog();
        }
    }

}
