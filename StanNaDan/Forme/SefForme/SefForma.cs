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
    public partial class SefForma : Form
    {
        PoslovnicaBasic poslovnica;
        public SefForma()
        {
            InitializeComponent();
        }
        public SefForma(PoslovnicaBasic poslovnicaa)
        {
            InitializeComponent();
            poslovnica = poslovnicaa;
        }

        private void SefForma_Load(object sender, EventArgs e)
        {
            this.Text = "Sefovi ";
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.zaposlenii.Items.Clear();
            List<SefPregled> poslovnice = DTOManager.VratiSveSefovePoslovice(poslovnica.PoslovnicaID);

            foreach (SefPregled r in poslovnice)
            {

                ListViewItem item = new ListViewItem(new string[] { r.maticni_broj, r.ime, r.datum_zaposlenja.ToString() ,r.datum_postavljanja.ToString()});
                this.zaposlenii.Items.Add(item);

            }

            this.zaposlenii.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajSefaForma forma = new DodajSefaForma(poslovnica);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
