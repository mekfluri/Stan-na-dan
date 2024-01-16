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
 
    public partial class IzmeniSefaForma : Form
    {
        SefBasic sef;
        public IzmeniSefaForma()
        {
            InitializeComponent();
        }
        public IzmeniSefaForma(SefBasic s)
        {
            InitializeComponent();
            sef = s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sef.datum_postavljanja = datum_postavljanja.Value;
            sef.datum_zaposlenja = datum_zaposlenja.Value;
            
            sef.ime = ime.Text;
            DTOManager.izmeniSefa(sef);
            this.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void datum_postavljanja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void datum_zaposlenja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void IzmeniSefaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
