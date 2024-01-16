using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StanNaDanv2.Forme
{

    public partial class KucaForma : Form
    {
        VlasnikBasic agencija;
        int brojkuca = 0;
        public KucaForma()
        {
            InitializeComponent();
        }
        public KucaForma(VlasnikBasic p)
        {
            InitializeComponent();
            agencija = p;
        }
        private void KucaForma_Load(object sender, EventArgs e)
        {

            popuniPodacima();
        }

        public void popuniPodacima()
        {

            this.listView1.Items.Clear();
            List<KucaPregled> poslovnice = DTOManager.vratiSveKuceVlasnika(agencija.VlasnikID);

            foreach (KucaPregled r in poslovnice)
            {

                ListViewItem item = new ListViewItem(new string[] { r.nekretninaID.ToString(), r.SPRATNOST.ToString(), r.DVORISTE.ToString(), r.kucnibroj.ToString(), r.ime_ulice, r.povrsina.ToString(), r.broj_kupatila.ToString(), r.broj_terasa.ToString(), r.broj_spavacih_soba.ToString(), r.internet.ToString(), r.TV_PRIKLJUCAK.ToString() });
                this.listView1.Items.Add(item);
                brojkuca++;

            }
            textBox1.Text = brojkuca.ToString();
            this.listView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kuću koje zelite da obrisete!");
                return;
            }

            int idkuca = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu kuću?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiKucu(idkuca);
                MessageBox.Show("Brisanje listView1 je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DodajKucuForma kvart = new DodajKucuForma(agencija);
                kvart.ShowDialog();
                this.popuniPodacima();
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
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite kucu cije podatke zelite da izmenite!");
                    return;
                }
                int idOdeljenja = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                KucaBasic odeljenje = DTOManager.vratiKucu(idOdeljenja);
                IzmeniKucuForma kvart = new IzmeniKucuForma(odeljenje);
                kvart.ShowDialog();
                this.popuniPodacima();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kucu cijeg vlasnik zelite da vidite!");
                return;
            }

            int idAgencije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            AgencijaBasic p = DTOManager.vratiAgenciju(idAgencije);

            FormaZaVlasnika forma = new FormaZaVlasnika(p);
            forma.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            int idNekretnine = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            DodaciForma forma = new DodaciForma(idNekretnine);

            forma.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite kucu cije sajtove zelite da vidite!");
                    return;
                }
                int idOdeljenja = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                KucaBasic odeljenje = DTOManager.vratiKucu(idOdeljenja);
                SajtNekretnineForma kvart = new SajtNekretnineForma(odeljenje);
                kvart.ShowDialog();
                this.popuniPodacima();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite kucu cija raspoloziva mesta zelite da vidite!");
                    return;
                }
                int idOdeljenja = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                KucaBasic odeljenje = DTOManager.vratiKucu(idOdeljenja);
                RaspolozivaMesta  kvart = new RaspolozivaMesta(odeljenje);
                kvart.ShowDialog();
                this.popuniPodacima();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
