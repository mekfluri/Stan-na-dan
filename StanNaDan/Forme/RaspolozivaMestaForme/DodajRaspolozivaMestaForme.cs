using NHibernate;
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
    public partial class DodajRaspolozivaMestaForme : Form
    {
        NekretninaBasic nekretnina;
        public DodajRaspolozivaMestaForme()
        {
            InitializeComponent();
        }

        public DodajRaspolozivaMestaForme(NekretninaBasic nek)
        {
            InitializeComponent();
            nekretnina = nek;
        }

        private void DodajRaspolozivaMestaForme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RaspolozivaMestaBasic a = new RaspolozivaMestaBasic();
                

                StanNaDanv2.Entiteti.RaspolozivaMestaNekretnine idje = new StanNaDanv2.Entiteti.RaspolozivaMestaNekretnine();
                idje.raspoloziva_mesta = textBox1.Text;

                a.id = idje;






                if (textBox1.Text != "")
                {

                    DTOManager.dodajRaspolozivoMesto(nekretnina, a);


                    MessageBox.Show("Uspesno ste dodali raspolozivo mesto!");

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
