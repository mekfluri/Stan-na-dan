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

namespace StanNaDanv2.Forme
{
    public partial class AgentForma : Form
    {
        PoslovnicaBasic poslovnica;
        public AgentForma()
        {
            InitializeComponent();
        }
        public AgentForma(PoslovnicaBasic basic)
        {
            InitializeComponent();
            this.poslovnica = basic;
        }

        private void ObrisiAgenta_Click(object sender, EventArgs e)
        {
            if (zaposlenii.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite agenta koga zelite da obrisete!");
                return;
            }

            string idZaposleni = zaposlenii.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranog agenta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiAgenta(idZaposleni);
                MessageBox.Show("Brisanje agenta je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }

        }

        private void DodajAgenta_Click(object sender, EventArgs e)
        {
            DodajAgentaForma forma = new DodajAgentaForma(poslovnica);
            forma.ShowDialog();
            popuniPodacima();
        }


        private void AgentForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.zaposlenii.Items.Clear();
            List<AgentPregled> poslovnice = DTOManager.VratiSveAgentePoslovice(poslovnica.PoslovnicaID);

            foreach (AgentPregled r in poslovnice)
            {

                ListViewItem item = new ListViewItem(new string[] { r.maticni_broj, r.ime, r.datum_zaposlenja.ToString(), r.strucna_sprema });
                this.zaposlenii.Items.Add(item);

            }

            this.zaposlenii.Refresh();
        }

        private void IzmeniAgenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (zaposlenii.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite agenta cije podatke zelite da izmenite!");
                    return;
                }
                string idOdeljenja = zaposlenii.SelectedItems[0].SubItems[0].Text;
                AgentBasic odeljenje = DTOManager.vratiAgenta(idOdeljenja);
                IzmeniAgentaForma kvart = new IzmeniAgentaForma(odeljenje);
                kvart.ShowDialog();
                this.popuniPodacima();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matbr_agenta = zaposlenii.SelectedItems[0].SubItems[0].Text;
            SpoljniSaradnikForma forma = new SpoljniSaradnikForma(matbr_agenta);
            forma.ShowDialog();
            popuniPodacima();
        }
    }
    }

