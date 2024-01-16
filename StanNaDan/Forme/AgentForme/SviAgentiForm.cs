using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanNaDanv2.Forme.AgentForme
{
    public partial class SviAgentiForm : Form
    {
        AgencijaBasic agencija;
        public SviAgentiForm()
        {
            InitializeComponent();
        }
        public SviAgentiForm(AgencijaBasic agenciija)
        {
            InitializeComponent();
            agencija = agenciija;
        }

        private void SviAgentiForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.zaposlenii.Items.Clear();
            List<AgentPregled> poslovnice = DTOManager.VratiSveAgenteAgencije(agencija.AgencijaID);

            foreach (AgentPregled r in poslovnice)
            {

                ListViewItem item = new ListViewItem(new string[] { r.maticni_broj, r.ime, r.datum_zaposlenja.ToString(), r.strucna_sprema });
                this.zaposlenii.Items.Add(item);

            }

            this.zaposlenii.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mat = zaposlenii.SelectedItems[0].SubItems[0].Text;
            SpoljniSaradnikForma forma = new SpoljniSaradnikForma(mat);
            forma.ShowDialog();

            popuniPodacima();
        }
    }
}
