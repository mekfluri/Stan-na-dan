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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace StanNaDanv2.Forme
{
    public partial class SviZaposleniForma : Form
    {
        AgencijaBasic agencija;
        public SviZaposleniForma()
        {
            InitializeComponent();
        }
        public SviZaposleniForma(AgencijaBasic a)
        {
            InitializeComponent();
            agencija = a;
        }
        public int brojZaposlenih = 0;

   

        public void popuniPodacima()
        {
            this.brojZaposlenih = 0;

            List<SamoZaposleniPregled> listaRadnika = DTOManager.VratiSveZaposleneAgencije(agencija.AgencijaID);

            this.zaposlenii.Items.Clear();
            foreach (ZaposleniPregled r in listaRadnika)
            {
               
                ListViewItem item = new ListViewItem(new string[] {r.maticni_broj,r.ime,r.FSef.ToString(),r.FAgent.ToString(),r.datum_zaposlenja.ToString() });
                this.zaposlenii.Items.Add(item);
                this.brojZaposlenih++;
            }

            txbBrojZaposlenih.Text = this.brojZaposlenih.ToString();
            this.zaposlenii.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SviZaposleniForma_Load_1(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void zaposlenii_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbBrojZaposlenih_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
