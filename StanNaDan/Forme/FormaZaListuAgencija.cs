using StanNaDanv2.Forme.AgentForme;
using StanNaDanv2.Forme.KucaForme;
using StanNaDanv2.Forme.SefForme;
using StanNaDanv2.Forme.StanForme;
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
    public partial class FormaZaListuAgencija : Form
    {
        public FormaZaListuAgencija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaZaDodavanjeAgencije forma = new FormaZaDodavanjeAgencije();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void FormaZaListuAgencija_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();
            List<AgencijaPregled> podaci = DTOManager.vratiAgencije();

            foreach (AgencijaPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.AgencijaID.ToString(), p.naziv });
                listView1.Items.Add(item);
            }


            listView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0 )
            {
                MessageBox.Show("Izaberite agenciju cije podatke zelite da izmenite!");
                return;
            }

            int idAgencije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            AgencijaBasic a = DTOManager.vratiAgenciju(idAgencije);

            FormaZaAzuriranjeAgencije formaazuriraj = new FormaZaAzuriranjeAgencije(a);
            formaazuriraj.ShowDialog();

            this.popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite agenciju koju zelite da obrisete!");
                return;
            }

            int idAgencije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            string poruka = "Da li zelite da obrisete izabranu agenciju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiAgenciju(idAgencije);
                MessageBox.Show("Brisanje agencije je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite agenciju cije poslovnice zelite da vidite!");
                return;
            }

            int idAgencije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            AgencijaBasic p = DTOManager.vratiAgenciju(idAgencije);
            FormaZaListuPoslovnica forma = new FormaZaListuPoslovnica(p);
            forma.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite agenciju cijeg vlasnika zelite da vidite!");
                return;
            }

            int idAgencije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            AgencijaBasic p = DTOManager.vratiAgenciju(idAgencije);
            
             FormaZaVlasnika forma = new FormaZaVlasnika(p);
            forma.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite agenciju cije kuće zelite da vidite!");
                    return;
                }

                int idAgencije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                AgencijaBasic p = DTOManager.vratiAgenciju(idAgencije);
                KuceAgencijeForma kvart = new KuceAgencijeForma(p);
                kvart.ShowDialog();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite vlasnika cije stanove zelite da vidite!");
                    return;
                }

                int idAgencije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                AgencijaBasic p = DTOManager.vratiAgenciju(idAgencije);
                StanoviAgencijeForma kvart = new StanoviAgencijeForma(p);
                kvart.ShowDialog();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite agenciju cije kvartove zelite da vidite!");
                    return;
                }

                int idAgencije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                PoslovnicaBasic p = DTOManager.vratiPoslovnicu(idAgencije);
                KvartForma kvart = new KvartForma(p);
                kvart.ShowDialog();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite agenciju cije zaposlene zelite da vidite!");
                    return;
                }

                int idAgencije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                AgencijaBasic p = DTOManager.vratiAgenciju(idAgencije);
                SviZaposleniForma kvart = new SviZaposleniForma(p);
                kvart.ShowDialog();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite agenciju cije sefove zelite da vidite!");
                    return;
                }

                int idAgencije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                AgencijaBasic p = DTOManager.vratiAgenciju(idAgencije);
                SviSefoviForma kvart = new SviSefoviForma(p);
                kvart.ShowDialog();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite agenciju cije agente zelite da vidite!");
                    return;
                }

                int idAgencije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                AgencijaBasic p = DTOManager.vratiAgenciju(idAgencije);
                SviAgentiForm kvart = new SviAgentiForm(p);
                kvart.ShowDialog();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            NajamForm forma = new NajamForm();

            forma.ShowDialog();

            popuniPodacima();
        }
    }
    
}
