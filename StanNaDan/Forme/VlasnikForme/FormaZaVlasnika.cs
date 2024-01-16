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
    public partial class FormaZaVlasnika : Form
    {

        AgencijaBasic agencija;
        public FormaZaVlasnika()
        {
            InitializeComponent();
        }

        public FormaZaVlasnika(AgencijaBasic a)
        {
            InitializeComponent();
            agencija = a;
        }

        private void FormaZaVlasnika_Load(object sender, EventArgs e)
        {
           
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            String pom;
            this.listView1.Items.Clear();
            List<VlasnikPregled> vlasnik = DTOManager.VratiVlasnikaAgencije(agencija.AgencijaID);

            foreach(VlasnikPregled p in vlasnik)
            {
                ListViewItem item = new ListViewItem(new string[] { p.VlasnikID.ToString(), p.broj_bankovnog_racuna, p.banka });
                this.listView1.Items.Add(item);
            }

            this.listView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vlasnika cije podatke zelite da izmenite!");
                return;
            }

            int idVlasnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            VlasnikBasic a = DTOManager.vratiVlasnika(idVlasnika);

            FormaZaAzuriranjeVlasnika formaazuriraj = new FormaZaAzuriranjeVlasnika(a);
            formaazuriraj.ShowDialog();

            this.popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaZaSveVlasnike form = new FormaZaSveVlasnike();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vlasnika za kog zelite da vidite podatke sa stanovista pravnog lica!");
                return;
            }

            int idVlasnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            VlasnikBasic p = DTOManager.vratiVlasnika(idVlasnika);
            FormaZaPrikazivanjePravnogLica forma = new FormaZaPrikazivanjePravnogLica(p);
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormaZaDodavanjeVlasnika forma = new FormaZaDodavanjeVlasnika(agencija);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ako izbriseem vlasnika moram i fiziko i pravno lice da izbrisem
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vlasnika kog zelite da obrisete!");
                return;
            }

            int idVlasnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);


            string poruka = "Da li zelite da obrisete izabranog vlasnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiVlasnika(idVlasnika);

                MessageBox.Show("Brisanje vlasnika je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vlasnika za kog zelite da vidite podatke sa stanovista fizickog lica!");
                return;
            }

            int idVlasnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            VlasnikBasic p = DTOManager.vratiVlasnika(idVlasnika);
            FormaZaPrikazivanjeFizickogLica forma = new FormaZaPrikazivanjeFizickogLica(p);
            forma.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vlasnika za kog zelite da vidite podatke o kucama!");
                return;
            }

            int idVlasnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            VlasnikBasic p = DTOManager.vratiVlasnika(idVlasnika);
            KucaForma forma = new KucaForma(p);
            forma.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int idVlasnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            VlasnikBasic p = DTOManager.vratiVlasnika(idVlasnika);
            StanForma forma = new StanForma(p);
            forma.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
