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
    public partial class ZaposleniForma : Form
    {
        PoslovnicaBasic poslovnica;
        public ZaposleniForma(PoslovnicaBasic poslovnicaa)
        {
            InitializeComponent();
            poslovnica = poslovnicaa;
        }

        private void ZaposleniForma_Load(object sender, EventArgs e)
        {
            this.Text = "Zaposleni ";
            popuniPodacima();

        }
        public void popuniPodacima()
        {
            this.zaposlenii.Items.Clear();
            List<SamoZaposleniPregled> poslovnice = DTOManager.VratiSveZaposlenePoslovice(poslovnica.PoslovnicaID);

            foreach (SamoZaposleniPregled r in poslovnice)
            {

                ListViewItem item = new ListViewItem(new string[] { r.maticni_broj, r.ime, r.datum_zaposlenja.ToString() });
                this.zaposlenii.Items.Add(item);

            }
           
            this.zaposlenii.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajZaposlenogForma forma = new DodajZaposlenogForma(poslovnica);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void gg_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (zaposlenii.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog koga zelite da obrisete!");
                return;
            }

            string idZaposleni = zaposlenii.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranog zaposlenog?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiZaposlenog(idZaposleni);
                MessageBox.Show("Brisanje zaposlenog je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (zaposlenii.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite zaposlenog cije podatke zelite da izmenite!");
                    return;
                }
                string idOdeljenja = zaposlenii.SelectedItems[0].SubItems[0].Text;
                SamoZaposleniBasic odeljenje = DTOManager.vratiZaposlenog(idOdeljenja);
                IzmeniZaposlenogForma kvart = new IzmeniZaposlenogForma(odeljenje);
                kvart.ShowDialog();
                popuniPodacima();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void zaposlenii_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
