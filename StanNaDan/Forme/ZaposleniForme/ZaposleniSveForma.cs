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

namespace StanNaDanv2.Forme.ZaposleniForme
{
    public partial class ZaposleniSveForma : Form
    {
        public ZaposleniSveForma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ZaposleniSveForms_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        int brojZaposlenih;
        public void popuniPodacima()
        {
            this.brojZaposlenih = 0;

            List<SamoZaposleniPregled> listaRadnika = DTOManager.VratiSveZaposlene();

            this.zaposlenii.Items.Clear();
            foreach (ZaposleniPregled r in listaRadnika)
            {

                ListViewItem item = new ListViewItem(new string[] { r.maticni_broj, r.ime, r.FSef.ToString(), r.FAgent.ToString(), r.datum_zaposlenja.ToString() });
                this.zaposlenii.Items.Add(item);
                this.brojZaposlenih++;
            }

            txbBrojZaposlenih.Text = this.brojZaposlenih.ToString();
            this.zaposlenii.Refresh();
        }
    }
}
