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
    public partial class NajamForm : Form
    {
        public NajamForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)//Dodaj najam
        {
            DodajNajam formaDodaj = new DodajNajam();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void Najam_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        private void popuniPodacima()
        {
            listaNajmova.Items.Clear();

            List<NajamPregled> podaci = DTOManager.vratiSveNajmovePregled();

            foreach(NajamPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    p.NajamId.ToString(),p.NazivNekretnine ,p.ImeAgenta, p.NazivAgencije, 
                    p.DatumPocetka.ToString(), p.DatumZavrsetka.ToString(), p.UkupnaCena.ToString()
                });
                listaNajmova.Items.Add(item);
            }

            listaNajmova.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)//Izbrisi najam
        {
            if(listaNajmova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Najam za brisanje");
                return;
            }

            int najamID = Int32.Parse(listaNajmova.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li ste sigurni da zelite da izbrisete izabrani najam?";
            string title = "Pitanje";

            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if(result == DialogResult.OK)
            {
                DTOManager.obrisiNajamIzSistema(najamID);
                MessageBox.Show("Brisanje najma je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }

        private void button2_Click(object sender, EventArgs e)//Izmeni najam
        {
            if(listaNajmova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite najam cije podatke zelite da izmenite!");
                return;
            }

            int najamID = Int32.Parse(listaNajmova.SelectedItems[0].SubItems[0].Text);
            NajamBasic ob = DTOManager.vratiNajam(najamID);

            IzmeniNajam formaUpdate = new IzmeniNajam(ob);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }
    }
}
