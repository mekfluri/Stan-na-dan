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
  
    public partial class StanForma : Form
    {
        VlasnikBasic agencija;
        public StanForma()
        {
            InitializeComponent();
        }
        public StanForma(VlasnikBasic a)
        {
            InitializeComponent();
           agencija= a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
               if (kuce.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite stan koje zelite da obrisete!");
                return;
            }

            int idstan = Int32.Parse(kuce.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani stan?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiStan(idstan);
                MessageBox.Show("Brisanje stana je uspesno obavljeno!");
               this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DodajStanForma kvart = new DodajStanForma(agencija);
                kvart.ShowDialog();
                popuniPodacima();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kuce.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite stan cije podatke zelite da izmenite!");
                    return;
                }
                int idOdeljenja = Int32.Parse(kuce.SelectedItems[0].SubItems[0].Text);
                StanBasic odeljenje = DTOManager.vratiStan(idOdeljenja);
                IzmeniStanForma kvart = new IzmeniStanForma(odeljenje);
                kvart.ShowDialog();
                popuniPodacima();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StanForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        int brojkuca = 0;
      public void  popuniPodacima()
        {
            this.kuce.Items.Clear();
            List<StanPregled> poslovnice = DTOManager.vratiSveStanoveVlasnika(agencija.VlasnikID);

            foreach (StanPregled r in poslovnice)
            {

                ListViewItem item = new ListViewItem(new string[] { r.nekretninaID.ToString(), r.SPRAT.ToString(), r.LIFT.ToString(), r.kucnibroj.ToString(), r.ime_ulice, r.povrsina.ToString(), r.broj_kupatila.ToString(), r.broj_terasa.ToString(), r.broj_spavacih_soba.ToString(), r.internet.ToString(), r.TV_PRIKLJUCAK.ToString() });
                this.kuce.Items.Add(item);
                brojkuca++;

            }
            textBox1.Text = brojkuca.ToString();
            this.kuce.Refresh();
        }

        private void buttonDodaci_Click(object sender, EventArgs e)
        {
            int idNekretnine = Int32.Parse(kuce.SelectedItems[0].SubItems[0].Text);

            DodaciForma forma = new DodaciForma(idNekretnine);

            forma.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (kuce.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite stan cije sajtove zelite da vidite!");
                    return;
                }
                int idOdeljenja = Int32.Parse(kuce.SelectedItems[0].SubItems[0].Text);
                StanBasic odeljenje = DTOManager.vratiStan(idOdeljenja);
                SajtNekretnineForma kvart = new SajtNekretnineForma(odeljenje);
                kvart.ShowDialog();
                popuniPodacima();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                if (kuce.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite stan cija raspoloziva mesta zelite da vidite!");
                    return;
                }
                int idOdeljenja = Int32.Parse(kuce.SelectedItems[0].SubItems[0].Text);
                StanBasic odeljenje = DTOManager.vratiStan(idOdeljenja);
                RaspolozivaMesta kvart = new RaspolozivaMesta(odeljenje);
                kvart.ShowDialog();
                popuniPodacima();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
