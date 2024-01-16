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
    public partial class FormaZaAzuriranjePravnogLica : Form
    {
        PravnoLiceBasic pravnoLice;
        public FormaZaAzuriranjePravnogLica()
        {
            InitializeComponent();
        }

        public FormaZaAzuriranjePravnogLica(PravnoLiceBasic v)
        {
            InitializeComponent();
            pravnoLice = v;
        }

        private void FormaZaAzuriranjePravnogLica_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            textBox1.Text = this.pravnoLice.ime;
            textBox2.Text = this.pravnoLice.adresa_firme;
            textBox3.Text = this.pravnoLice.ime_kontakt_osobe;
            textBox4.Text = this.pravnoLice.email;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene pravnog lica?";
            string title = "Pitanje";

            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.pravnoLice.ime = textBox1.Text;
                this.pravnoLice.adresa_firme = textBox2.Text;
                this.pravnoLice.ime_kontakt_osobe = textBox3.Text;
                this.pravnoLice.email = textBox4.Text;
               

                DTOManager.azurirajPravnoLice(this.pravnoLice);
                MessageBox.Show("Azuriranje pravnog lica je uspesno izvrseno!");
                this.Close();
            }
        }
    }
}
