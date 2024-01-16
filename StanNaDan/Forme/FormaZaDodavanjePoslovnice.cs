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
    public partial class FormaZaDodavanjePoslovnice : Form
    {
        AgencijaBasic agencija;
        public FormaZaDodavanjePoslovnice()
        {
            InitializeComponent();
        }

        public FormaZaDodavanjePoslovnice(AgencijaBasic a)
        {
            InitializeComponent();
            agencija = a;
        }

        private void DodajPoslovicu_Click(object sender, EventArgs e)
        {
            PoslovnicaBasic poslovnica = new PoslovnicaBasic();
            poslovnica.adresa = textAdresa.Text;
            poslovnica.radno_vreme = textRadnoVreme.Text;



        }
    }
}
