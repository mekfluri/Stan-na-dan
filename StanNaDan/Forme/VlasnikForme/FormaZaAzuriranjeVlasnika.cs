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
    public partial class FormaZaAzuriranjeVlasnika : Form
    {
        VlasnikBasic vlasnik;
        public FormaZaAzuriranjeVlasnika()
        {
            InitializeComponent();
        }

        public FormaZaAzuriranjeVlasnika(VlasnikBasic v)
        {
            InitializeComponent();
            vlasnik = v;
        }

        private void FormaZaAzuriranjeVlasnika_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE VLASNIKA {vlasnik.banka.ToUpper()}";
        }

        public void popuniPodacima()
        {
            textracun.Text = this.vlasnik.broj_bankovnog_racuna;
            textbanka.Text = this.vlasnik.banka;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene vlasnika?";
            string title = "Pitanje";

            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.vlasnik.banka = textbanka.Text;
                this.vlasnik.broj_bankovnog_racuna = textracun.Text;

                DTOManager.azurirajVlasnika(this.vlasnik);
                MessageBox.Show("Azuriranje vlasnika je uspesno izvrseno!");
                this.Close();
            }

        }
    }
}
