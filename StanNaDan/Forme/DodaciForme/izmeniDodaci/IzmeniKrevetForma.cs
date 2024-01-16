using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanNaDanv2.Forme.DodaciForme.formeIzmena
{
    public partial class IzmeniKrevetForma : Form
    {
        KrevetBasic krevet;
        public IzmeniKrevetForma(KrevetBasic k)
        {
            InitializeComponent();
            krevet = k;
        }

        private void IzmeniKrevetForma_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            krevet.DimenzijeKreveta = textBoxDimenzije.Text;
            krevet.TipKreveta = textBoxTip.Text;

            DTOManager.azurirajKrevet(krevet);
            Close();
        }
    }
}
