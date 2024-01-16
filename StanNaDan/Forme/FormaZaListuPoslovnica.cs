using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StanNaDanv2.Forme
{
    public partial class FormaZaListuPoslovnica : Form
    {
        AgencijaBasic agencija;
        public FormaZaListuPoslovnica()
        {
            InitializeComponent();
        }

        public FormaZaListuPoslovnica(AgencijaBasic p)
        {
            InitializeComponent();
            agencija = p;
        }

        private void FormaZaListuPoslovnica_Load(object sender, EventArgs e)
        {
            this.Text = "PRODAVNICA " + agencija.naziv.ToUpper();
            popuniPodacima();
        }

        public void popuniPodacima()
        {
         
            this.Poslovnice.Items.Clear();
            List<PoslovnicaPregled> poslovnice = DTOManager.VratiSvePoslovniceAgencije(agencija.AgencijaID);

            foreach (PoslovnicaPregled r in poslovnice)
            {

                ListViewItem item = new ListViewItem(new string[] { r.PoslovnicaID.ToString(), r.adresa, r.radno_vreme });
                this.Poslovnice.Items.Add(item);

            }

            this.Poslovnice.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaZaDodavanjePoslovnice formadodaj = new FormaZaDodavanjePoslovnice(agencija);

        }

        private void button2_Click(object sender, EventArgs e)
        {
              try
            {
                if (Poslovnice.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite poslovnicu cije kvartove zelite da vidite!");
                    return;
                }

                int idAgencije = Int32.Parse(Poslovnice.SelectedItems[0].SubItems[0].Text);
                PoslovnicaBasic p = DTOManager.vratiPoslovnicu(idAgencije);
                KvartForma kvart = new KvartForma(p);
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
                if (Poslovnice.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite poslovicu cije zaposlene zelite da vidite!");
                    return;
                }

                int idAgencije = Int32.Parse(Poslovnice.SelectedItems[0].SubItems[0].Text);
                PoslovnicaBasic p = DTOManager.vratiPoslovnicu(idAgencije);
                ZaposleniForma kvart = new ZaposleniForma(p);
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
                if (Poslovnice.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite poslovicu cije sefove zelite da vidite!");
                    return;
                }

                int idAgencije = Int32.Parse(Poslovnice.SelectedItems[0].SubItems[0].Text);
                PoslovnicaBasic p = DTOManager.vratiPoslovnicu(idAgencije);
                SefForma kvart = new SefForma(p);
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
                if (Poslovnice.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite poslovicu cije agente zelite da vidite!");
                    return;
                }

                int idAgencije = Int32.Parse(Poslovnice.SelectedItems[0].SubItems[0].Text);
                PoslovnicaBasic p = DTOManager.vratiPoslovnicu(idAgencije);
                AgentForma kvart = new AgentForma(p);
                kvart.ShowDialog();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
