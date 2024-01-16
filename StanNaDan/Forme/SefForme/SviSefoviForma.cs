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

namespace StanNaDanv2.Forme.SefForme
{
    public partial class SviSefoviForma : Form
    {
        AgencijaBasic agencija;
        public SviSefoviForma()
        {
            InitializeComponent();
        }
        public SviSefoviForma(AgencijaBasic a)
        {
            InitializeComponent();
            agencija = a;
        }

        private void SviSefoviForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.zaposlenii.Items.Clear();
            List<SefPregled> poslovnice = DTOManager.VratiSveSefoveAgencije(agencija.AgencijaID);

            foreach (SefPregled r in poslovnice)
            {

                ListViewItem item = new ListViewItem(new string[] { r.maticni_broj, r.ime, r.datum_zaposlenja.ToString(), r.datum_postavljanja.ToString() });
                this.zaposlenii.Items.Add(item);

            }

            this.zaposlenii.Refresh();
        }

        private void zaposlenii_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (zaposlenii.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite sefa cije podatke zelite da izmenite!");
                    return;
                }
                string idOdeljenja = zaposlenii.SelectedItems[0].SubItems[0].Text;
                SefBasic odeljenje = DTOManager.vratiSefa(idOdeljenja);
                IzmeniSefaForma kvart = new IzmeniSefaForma(odeljenje);
                kvart.ShowDialog();
                this.popuniPodacima();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (zaposlenii.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite sefa koga zelite da obrisete!");
                return;
            }

            string idZaposleni = zaposlenii.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranog sefa?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiSefa(idZaposleni);
                MessageBox.Show("Brisanje sefa je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}
