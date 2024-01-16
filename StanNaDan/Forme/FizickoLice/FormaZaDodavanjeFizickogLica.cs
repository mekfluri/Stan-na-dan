using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;

namespace StanNaDanv2.Forme
{
    public partial class FormaZaDodavanjeFizickogLica : Form
    {
        VlasnikBasic vlasnik;
        public FormaZaDodavanjeFizickogLica()
        {
            InitializeComponent();
        }

        public FormaZaDodavanjeFizickogLica(VlasnikBasic v)
        {
            InitializeComponent();
            vlasnik = v;
        }


        private void FormaZaDodavanjeFizickogLica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoLiceBasic a = new FizickoLiceBasic();

                a.maticni_broj = Int32.Parse(textBox1.Text);

                a.ime = textBox2.Text;
                a.ime_roditelja = textBox8.Text;
                a.prezime = textBox3.Text;
                a.drzava = textBox4.Text;
                a.mesto = textBox5.Text;
                a.adresa = textBox6.Text;
                a.datum_rodjenja = DateTime.Parse(textBox7.Text);
                a.email = textBox9.Text;

                if (textBox1.Text != ""
                    && textBox2.Text != ""
                    && textBox3.Text != ""
                    && textBox4.Text != ""
                    && textBox5.Text != ""
                    && textBox6.Text != ""
                    && textBox7.Text != ""
                    && textBox8.Text != ""
                    && textBox9.Text != ""
                    )
                {
                   
                    DTOManager.dodajFizickoLice(a, vlasnik);


                    MessageBox.Show("Uspesno ste dodali fizicko lice!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Niste uneli podatke");

                }
            }
            catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }

     
    } 
}
