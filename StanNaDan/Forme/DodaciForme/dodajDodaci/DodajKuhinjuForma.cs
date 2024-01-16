using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanNaDanv2.Forme.DodaciForme.formeDodavanje
{
    public partial class DodajKuhinjuForma : Form
    {
        KuhinjaBasic kuhinja;
        public DodajKuhinjuForma(KuhinjaBasic k)
        {
            kuhinja = k;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                kuhinja.Posudje = true;
            }
            else
            {
                kuhinja.Posudje = false;

            }
            kuhinja.TipDodatka = "Kuhinja";
            DTOManager.sacuvajKuhinju(kuhinja);
            Close();
        }
    }
}
