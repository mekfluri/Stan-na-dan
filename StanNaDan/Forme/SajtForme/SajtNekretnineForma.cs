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
    public partial class SajtNekretnineForma : Form
    {
        NekretninaBasic nekretinina;
        public SajtNekretnineForma()
        {
            InitializeComponent();
        }
        public SajtNekretnineForma(NekretninaBasic nek)
        {
            InitializeComponent();
            nekretinina = nek;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sajtovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite sajt koga zelite da obrisete!");
                return;
            }

            int idZaposleni = Int32.Parse(sajtovi.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog sajt?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiKvart(idZaposleni);
                MessageBox.Show("Brisanje sajt je uspesno obavljeno!");
                //this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sajtovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite sajt koga zelite da obrisete!");
                return;
            }

            string naziv = sajtovi.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabrani sajt?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiSajt(naziv);
                MessageBox.Show("Brisanje sajta je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajSajtForm forma = new DodajSajtForm(nekretinina);
            forma.ShowDialog();
            popuniPodacima();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SajtNekretnineForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {

            sajtovi.Items.Clear();
            List<string> podaci = DTOManager.vratiSajtove(nekretinina.nekretninaID);

            foreach (var p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p });
                sajtovi.Items.Add(item);
            }


            sajtovi.Refresh();

        }
    }
}
