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
    public partial class DodajSajtForm : Form
    {
        NekretninaBasic nekretnina;
        public DodajSajtForm()
        {
            InitializeComponent();
        }
        public DodajSajtForm(NekretninaBasic nek)
        {
            InitializeComponent();
            nekretnina = nek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SajtBasic a = new SajtBasic();


                StanNaDanv2.Entiteti.SajtNekretnine idje = new StanNaDanv2.Entiteti.SajtNekretnine();
                idje.sajt = textBox1.Text;

                a.sajtID = idje;






                if (textBox1.Text != "")
                {

                    DTOManager.dodajSajt(nekretnina, a);


                    MessageBox.Show("Uspesno ste dodali broj telefona!");

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

        private void DodajSajtForm_Load(object sender, EventArgs e)
        {

        }
    }
}
