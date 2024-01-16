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
    public partial class RaspolozivaMesta : Form
    {
        NekretninaBasic nekretnina;
        public RaspolozivaMesta()
        {
            InitializeComponent();
        }

        public RaspolozivaMesta(NekretninaBasic nek)
        {
            InitializeComponent();
            nekretnina = nek;
        }

        private void RaspolozivaMesta_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            mesta.Items.Clear();
            List<string> podaci = DTOManager.vratiMesta(nekretnina.nekretninaID);

            foreach (var p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p });
                mesta.Items.Add(item);
            }


            mesta.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mesta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite mesto koje zelite da obrisete!");
                return;
            }

            string naziv = mesta.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabrano mesto?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiMesto(naziv);
                MessageBox.Show("Brisanje mesta je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajRaspolozivaMestaForme forma = new DodajRaspolozivaMestaForme(nekretnina);
            forma.ShowDialog();
            popuniPodacima();
        }
    }
}
