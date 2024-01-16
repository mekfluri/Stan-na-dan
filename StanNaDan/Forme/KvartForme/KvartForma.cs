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
    public partial class KvartForma : Form
    {
        PoslovnicaBasic poslovnica;
        public KvartForma()
        {
            InitializeComponent();
        }
        public KvartForma(PoslovnicaBasic p)
        {
            InitializeComponent();
            poslovnica = p;

        }

        private void KvartForma_Load(object sender, EventArgs e)
        {
            this.Text = "Kvartovi poslovnice ";
            popuniPodacima();
        }
        public void popuniPodacima()
        {

            this.kvartovi.Items.Clear();
            List<KvartPregled> kvart = (List<KvartPregled>)DTOManager.vratiSveKvartove();
            Console.WriteLine(kvart);
            foreach (KvartPregled r in kvart)
            {

                ListViewItem item = new ListViewItem(new string[] { r.kvartID.ToString(), r.gradska_zona, r.broj_nekretnina.ToString() });
                this.kvartovi.Items.Add(item);

            }

            this.kvartovi.Refresh();
        }
      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

    

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KvartForma_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                KvartDodajForma kvart = new KvartDodajForma(poslovnica);
                kvart.ShowDialog();
                this.popuniPodacima();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (kvartovi.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite kvart cije podatke zelite da izmenite!");
                    return;
                }
                int idOdeljenja = Int32.Parse(kvartovi.SelectedItems[0].SubItems[0].Text);
                KvartBasic odeljenje = DTOManager.vratiKvart(idOdeljenja);
                IzmeniKvartForma kvart = new IzmeniKvartForma(odeljenje);
                kvart.ShowDialog();
                this.popuniPodacima();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (kvartovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kvarta koga zelite da obrisete!");
                return;
            }

            int idZaposleni = Int32.Parse(kvartovi.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog kvarta?";
            string title = "Pitanje"; 
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
               

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiKvart(idZaposleni);
                MessageBox.Show("Brisanje kvarta je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }
    }
}