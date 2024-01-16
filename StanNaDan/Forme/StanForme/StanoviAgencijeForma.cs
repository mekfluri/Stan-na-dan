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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StanNaDanv2.Forme.StanForme
{
    public partial class StanoviAgencijeForma : Form
    { AgencijaBasic agencija;
        public StanoviAgencijeForma()
        {
            InitializeComponent();
        }
        public StanoviAgencijeForma(AgencijaBasic agencijaa)
        {
            InitializeComponent();
            agencija = agencijaa;
        }

        private void StanoviAgencijeForma_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.kuce.Items.Clear();
            List<StanPregled> poslovnice = DTOManager.vratiSveStanoveAgencije(agencija.AgencijaID);

            foreach (StanPregled r in poslovnice)
            {

                ListViewItem item = new ListViewItem(new string[] { r.nekretninaID.ToString(), r.SPRAT.ToString(), r.LIFT.ToString(), r.kucnibroj.ToString(), r.ime_ulice, r.povrsina.ToString(), r.broj_kupatila.ToString(), r.broj_terasa.ToString(), r.broj_spavacih_soba.ToString(), r.internet.ToString(), r.TV_PRIKLJUCAK.ToString() });
                this.kuce.Items.Add(item);
             

            }
        
            this.kuce.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            int idNekretnine = Int32.Parse(kuce.SelectedItems[0].SubItems[0].Text);

            DodaciForma forma = new DodaciForma(idNekretnine);

            forma.ShowDialog();
        }
    }
}
