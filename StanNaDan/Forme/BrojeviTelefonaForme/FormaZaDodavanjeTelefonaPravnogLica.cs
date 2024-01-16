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
    public partial class FormaZaDodavanjeTelefonaPravnogLica : Form
    {
        PravnoLiceBasic prlice;
        public FormaZaDodavanjeTelefonaPravnogLica()
        {
            InitializeComponent();
        }

        public FormaZaDodavanjeTelefonaPravnogLica(PravnoLiceBasic pr)
        {
            InitializeComponent();
            prlice = pr;
        }

        private void FormaZaDodavanjeTelefonaPravnogLica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BrojeviTelefonaPravnogLicaBasic a = new BrojeviTelefonaPravnogLicaBasic();


                StanNaDanv2.Entiteti.IDBrTelPL idje = new StanNaDanv2.Entiteti.IDBrTelPL();
                idje.broj_telefona = Int32.Parse(textBox1.Text);

                a.IDbroja = idje;






                if (textBox1.Text != "")
                {

                    DTOManager.dodajbrojpl(prlice, a);


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
