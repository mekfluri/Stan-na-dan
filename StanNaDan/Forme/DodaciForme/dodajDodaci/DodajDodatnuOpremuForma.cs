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
    public partial class DodajDodatnuOpremuForma : Form
    {
        DodatnaOpremaBasic dodatna;
        public DodajDodatnuOpremuForma(DodatnaOpremaBasic d)
        {
            dodatna = d;
            InitializeComponent();
        }

        private void DodajDodatnuOpremuForma_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dodatna.TipDodatneOpreme = textBox1.Text;
            dodatna.Doplata = double.Parse(textBox2.Text);
            dodatna.TipDodatka = "DodatnaOprema";
            DTOManager.sacuvajDodatnuOpremu(dodatna);
            Close();
        }
    }
}
