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
    public partial class FormaZaDodavanjeVlasnika : Form
    {
        AgencijaBasic agencija;
        public FormaZaDodavanjeVlasnika()
        {
            InitializeComponent();
        }

        public FormaZaDodavanjeVlasnika(AgencijaBasic e)
        {
            InitializeComponent();
            agencija = e;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VlasnikBasic a = new VlasnikBasic();

                a.broj_bankovnog_racuna = textBox2.Text;
                a.banka = textBox1.Text;

                if (textBox1.Text != "" && textBox2.Text !="")
                {
                    //prosledjujemo vlasnika i agenciju koju dodajemo 
                    //treba da dodam vlasnika agenciji????????
                    DTOManager.dodajVlasnika(a,agencija);


                    MessageBox.Show("Uspesno ste dodali Vlasnika!");

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

        private void FormaZaDodavanjeVlasnika_Load(object sender, EventArgs e)
        {

        }
    }
}
