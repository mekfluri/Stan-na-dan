using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StanNaDanv2.Entiteti;
using StanNaDanv2.Forme.DodaciForme.formeIzmena;
namespace StanNaDanv2.Forme
{
    public partial class DodaciForma : Form
    {
        int nekretninaID;

        public DodaciForma(int n)
        {
            nekretninaID = n;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//dodavanje
        {
            DodajDodatak formaDodaj = new DodajDodatak(nekretninaID);
            formaDodaj.ShowDialog();
            formaDodaj.Close();
            this.popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listaDodataka.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite dodatak koji zelite da izbrisete");
                return;
            }
            int idDodatka = Int32.Parse(listaDodataka.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete odabrani dodatak";
            string title = "Pitanje";

            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            Entiteti.Dodaci dodaci = DTOManager.vratiDodatak(idDodatka);
            if (result == DialogResult.OK)
            {
                if (dodaci.TipDodatka == "Kuhinja")
                {
                    DTOManager.obrisiKuhinju(dodaci.Id);
                }
                else if (dodaci.TipDodatka == "Krevet")
                {
                    DTOManager.obrisiKrevet(dodaci.Id);
                }
                else if (dodaci.TipDodatka == "ParkingMesto")
                {
                    DTOManager.obrisiParkingMesto(dodaci.Id);
                }
                else
                {
                    DTOManager.obrisiDodatnuOpremu(dodaci.Id);
                }
            }
        }

        private void DodaciForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        private void popuniPodacima()
        {
            listaDodataka.Items.Clear();
            List<DodaciPregled> dodaci = new List<DodaciPregled>();
            dodaci = DTOManager.vratiDodatkeNekretnine(nekretninaID);

            foreach (DodaciPregled d in dodaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    d.DodaciId.ToString(),
                    d.TipDodatka,
                    d.nekretninaID.ToString(),
                    d.TipNekretnine
                });
                listaDodataka.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)//izmena
        {
            if (listaDodataka.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite koji dodatak da izmenite");
                return;
            }

            int idDodatka = Int32.Parse(listaDodataka.SelectedItems[0].SubItems[0].Text);
            string tipDodatka = listaDodataka.SelectedItems[0].SubItems[1].Text;

            if (tipDodatka == "DodatnaOprema")
            {
                DodatnaOpremaBasic oprema = DTOManager.vratiDodatnuOpremu(idDodatka);
                IzmeniDodatnuOpremuForma forma = new IzmeniDodatnuOpremuForma(oprema);

                forma.ShowDialog();
            }
            else if (tipDodatka == "Kuhinja")
            {
                KuhinjaBasic kuhinja = DTOManager.vratiKuhinju(idDodatka);

                IzmeniKuhinjuForma forma = new IzmeniKuhinjuForma(kuhinja);
            }
            else if (tipDodatka == "Krevet")
            {
                KrevetBasic krevet = DTOManager.vratiKrevet(idDodatka);

                IzmeniKrevetForma forma = new IzmeniKrevetForma(krevet);
            }
            else if (tipDodatka == "ParkingMesto")
            {
                ParkingMestoBasic parking = DTOManager.vratiParkingMesto(idDodatka);

                IzmeniParkingMesta forma = new IzmeniParkingMesta(parking);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(listaDodataka.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Dodatak za brisanje");
                return;
            }
            int dodatakID = Int32.Parse(listaDodataka.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li ste sigurni da zelite da izbrisete izabrani dodatak?";
            string title = "Pitanje";

            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiDodatak(dodatakID);
                MessageBox.Show("Brisanje prodavnice je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }
    }
}
