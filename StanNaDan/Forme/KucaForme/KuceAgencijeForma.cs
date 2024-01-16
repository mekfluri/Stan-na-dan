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

namespace StanNaDanv2.Forme.KucaForme
{
    public partial class KuceAgencijeForma : Form
    {
        AgencijaBasic agencija;
        public KuceAgencijeForma()
        {
            InitializeComponent();
        }
        public KuceAgencijeForma(AgencijaBasic a)
        {
            InitializeComponent();
            agencija = a;
        }

        private void KuceAgencijeForma_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.kuce.Items.Clear();
            List<KucaPregled> poslovnice = DTOManager.vratiSveKuceAgencije(agencija.AgencijaID);

            foreach (KucaPregled r in poslovnice)
            {

                ListViewItem item = new ListViewItem(new string[] { r.nekretninaID.ToString(), r.SPRATNOST.ToString(), r.DVORISTE.ToString(), r.kucnibroj.ToString(), r.ime_ulice, r.povrsina.ToString(), r.broj_kupatila.ToString(), r.broj_terasa.ToString(), r.broj_spavacih_soba.ToString(), r.internet.ToString(), r.TV_PRIKLJUCAK.ToString() });
                this.kuce.Items.Add(item);


            }

            this.kuce.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kuce.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kuću koje zelite da obrisete!");
                return;
            }

            int idkuca = Int32.Parse(kuce.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu kuću?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiKucu(idkuca);
                MessageBox.Show("Brisanje kuce je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idNekretnine = Int32.Parse(kuce.SelectedItems[0].SubItems[0].Text);

            DodaciForma forma = new DodaciForma(idNekretnine);

            forma.ShowDialog();
        }
    }
}
