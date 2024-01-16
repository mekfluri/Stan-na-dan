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
    public partial class FormaZaAzuriranjeAgencije : Form
    {
        public AgencijaBasic agencija;
        public FormaZaAzuriranjeAgencije()
        {
            InitializeComponent();
        }

        public FormaZaAzuriranjeAgencije(AgencijaBasic a)
        {
            InitializeComponent();
            this.agencija = a;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene agencije?";
            string title = "Pitanje";

            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if(result == DialogResult.OK)
            {
                this.agencija.naziv = textNaziv.Text;

                DTOManager.azurirajAgenciju(this.agencija);
                MessageBox.Show("Azuriranje agencije je uspesno izvrseno!");
                this.Close();
            }


        }

        private void FormaZaAzuriranjeAgencije_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            this.Text = $"AZURIRANJE AGENCIJE {agencija.naziv.ToUpper()}";
        }

        public void popuniPodacima()
        {
            textNaziv.Text = this.agencija.naziv;
        }

    }
}
