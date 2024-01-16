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
    public partial class DodajKrevetForma : Form
    {
        KrevetBasic krevet;
        public DodajKrevetForma(KrevetBasic k)
        {
            krevet = k;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            krevet.TipKreveta = textBox1.Text;
            krevet.TipDodatka = "Krevet";
            krevet.DimenzijeKreveta = textBox2.Text;

            DTOManager.sacuvajKrevet(krevet);
            Close();
        }
    }
}
