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
    public partial class FormaZaUcitavanjeTelefonaFL : Form
    {
        FizickoLiceBasic fizlice;
        public FormaZaUcitavanjeTelefonaFL()
        {
            InitializeComponent();
        }

        public FormaZaUcitavanjeTelefonaFL(FizickoLiceBasic f)
        {
            InitializeComponent();
            fizlice = f;
        }

        private void FormaZaUcitavanjeTelefonaFL_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            String pom;
            this.listView1.Items.Clear();
            List<string> brojevitelefona= DTOManager.VratiBrojeveTelefona(fizlice.maticni_broj);

            foreach (var  r in brojevitelefona)
            {

                ListViewItem item = new ListViewItem(new string[] { r});
                this.listView1.Items.Add(item);

            }

            this.listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaZaDodavanjeTelefonaFizickogLica forma = new FormaZaDodavanjeTelefonaFizickogLica(fizlice);
            forma.ShowDialog();
            popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite broj telefona koji zelite da obrisete!");
                return;
            }

            int broj = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabrani broj";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisibrojF(broj);
                MessageBox.Show("Brisanje broja je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /*if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite broj cije podatke zelite da izmenite!");
                return;
            }

            int broj = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            BrojeviTelefonaFizickogLicaBasic a = DTOManager.vratiBroj(broj);

            FormaZaAzuriranjeTelefonaFizickogLica formaazuriraj = new FormaZaAzuriranjeTelefonaFizickogLica(a);
            formaazuriraj.ShowDialog();

            this.popuniPodacima();*/

        }
    }
}
