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
using StanNaDanv2.Entiteti;

namespace StanNaDanv2.Forme
{
    public partial class FormaZaDodavanjeAgencije : Form
    {
        public FormaZaDodavanjeAgencije()
        {
            InitializeComponent();
        }

        private void cmdDodajAgenciju_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

               AgencijaBasic a = new AgencijaBasic();

                a.naziv = textAgencija.Text;

                if(textAgencija.Text != "")
                {


                    DTOManager.dodajAgenciju(a);


                    MessageBox.Show("Uspesno ste dodali Agenciju!");
                    
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
