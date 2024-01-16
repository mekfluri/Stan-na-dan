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
    public partial class FormaZaAzuriranjeFizickogLica : Form
    {
        FizickoLiceBasic fizlice;
        public FormaZaAzuriranjeFizickogLica()
        {
            InitializeComponent();
        }

        public FormaZaAzuriranjeFizickogLica(FizickoLiceBasic fl)
        {
            InitializeComponent();
            fizlice = fl;
        }

        private void FormaZaAzuriranjeFizickogLica_Load(object sender, EventArgs e)
        {
            popuniPodacima();
   
        }

        public void popuniPodacima()
        {
            textBox1.Text = this.fizlice.ime;
            textBox2.Text = this.fizlice.ime_roditelja;
            textBox3.Text = this.fizlice.prezime;
            textBox4.Text = this.fizlice.drzava;
            textBox5.Text = this.fizlice.mesto;
            textBox6.Text = this.fizlice.adresa;
            textBox7.Text = this.fizlice.datum_rodjenja.ToString();
            textBox8.Text = this.fizlice.email;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene fizickog lica?";
            string title = "Pitanje";

            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                this.fizlice.ime = textBox1.Text;
                this.fizlice.ime_roditelja = textBox2.Text;
                this.fizlice.prezime = textBox3.Text;
                this.fizlice.drzava = textBox4.Text;
                this.fizlice.mesto = textBox5.Text;
                this.fizlice.adresa = textBox6.Text;
                this.fizlice.datum_rodjenja = DateTime.Parse(textBox7.Text);
                this.fizlice.email = textBox8.Text;

                DTOManager.azurirajFizickoLice(this.fizlice);
                MessageBox.Show("Azuriranje fizickog lica je uspesno izvrseno!");
                this.Close();
            }
        }
    }
}
