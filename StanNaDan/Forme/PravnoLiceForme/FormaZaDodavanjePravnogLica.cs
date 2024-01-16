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
    public partial class FormaZaDodavanjePravnogLica : Form
    {
        VlasnikBasic vlasnik;

        public FormaZaDodavanjePravnogLica()
        { 
            InitializeComponent();
        }

        public FormaZaDodavanjePravnogLica(VlasnikBasic v)
        {
            InitializeComponent();
            vlasnik = v;
        }


        private void FormaZaDodavanjePravnogLica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PravnoLiceBasic a = new PravnoLiceBasic();

                a.PIB = Int32.Parse(textBox1.Text);

                a.ime = textBox2.Text;
                a.adresa_firme = textBox3.Text;
                a.ime_kontakt_osobe = textBox4.Text;
                a.email = textBox5.Text;
                

                if (textBox1.Text != ""
                    && textBox2.Text != ""
                    && textBox3.Text != ""
                    && textBox4.Text != ""
                    && textBox5.Text != ""
                    
                    )
                {

                    DTOManager.dodajPravnoLice(a, vlasnik);


                    MessageBox.Show("Uspesno ste dodali pravno lice!");

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
