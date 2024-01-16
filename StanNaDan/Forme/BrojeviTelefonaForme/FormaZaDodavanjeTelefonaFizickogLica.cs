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
    public partial class FormaZaDodavanjeTelefonaFizickogLica : Form
    {
        FizickoLiceBasic fizlice;
        public FormaZaDodavanjeTelefonaFizickogLica()
        {
            InitializeComponent();
        }

        public FormaZaDodavanjeTelefonaFizickogLica(FizickoLiceBasic fl)
        {
            InitializeComponent();
            fizlice = fl;
        }



        private void FormaZaDodavanjeTelefonaFizickogLica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BrojeviTelefonaFizickogLicaBasic a = new BrojeviTelefonaFizickogLicaBasic();


                StanNaDanv2.Entiteti.IDBrTelFL idje = new StanNaDanv2.Entiteti.IDBrTelFL();
                idje.broj_telefona = Int32.Parse(textBox1.Text);

                a.IDbroja = idje;

                
               
               
               

                if (textBox1.Text != "")
                {
             
                    DTOManager.dodajbrojfl(fizlice, a);


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
    }
}
