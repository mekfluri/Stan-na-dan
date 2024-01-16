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
    public partial class FormaZaPrikazivanjeFizickogLica : Form
    {
        VlasnikBasic vlasnik;
        public FormaZaPrikazivanjeFizickogLica()
        {
            InitializeComponent();
        }

        public FormaZaPrikazivanjeFizickogLica(VlasnikBasic v)
        {
            InitializeComponent();
            vlasnik = v;
        }

        private void FormaZaPrikazivanjeFizickogLica_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            String pom;
            this.listView1.Items.Clear();
            List<FizickoLicePregled> fizickaLica = DTOManager.VratiFizickoLice(vlasnik.VlasnikID);

            foreach (FizickoLicePregled r in fizickaLica)
            {

                ListViewItem item = new ListViewItem(new string[] { r.maticni_broj.ToString(), r.ime, r.ime_roditelja, r.prezime, r.drzava, r.mesto, r.adresa, r.datum_rodjenja.ToString(), r.email  });
                this.listView1.Items.Add(item);

            }

            this.listView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite fizicko lice cije podatke zelite da izmenite!");
                return;
            }

            int idfizickoglica = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            FizickoLiceBasic a = DTOManager.vratiFizickoLice(idfizickoglica);

            FormaZaAzuriranjeFizickogLica formaazuriraj = new FormaZaAzuriranjeFizickogLica(a);
            formaazuriraj.ShowDialog();

            this.popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite fizicko lice koje zelite da obrisete!");
                return;
            }

            int idFizickogLica = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabrano fizicko lice";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiFizickoLice(idFizickogLica);
                MessageBox.Show("Brisanje fizickog lica je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaZaDodavanjeFizickogLica form = new FormaZaDodavanjeFizickogLica(vlasnik);
            form.ShowDialog();
            this.popuniPodacima();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite lice cije brojeve mobilnoih telefona zelite da vidite!");
                return;
            }

            int idFizickogLica = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            FizickoLiceBasic p = DTOManager.vratiFizickoLice(idFizickogLica);
            FormaZaUcitavanjeTelefonaFL forma = new FormaZaUcitavanjeTelefonaFL(p);
            forma.ShowDialog();
        }
    }
}
