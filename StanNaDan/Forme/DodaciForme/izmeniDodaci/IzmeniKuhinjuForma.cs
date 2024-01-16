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
    public partial class IzmeniKuhinjuForma : Form
    {
        KuhinjaBasic kuhinja;
        public IzmeniKuhinjuForma(KuhinjaBasic k)
        {
            InitializeComponent();
            kuhinja = k;
        }

        private void IzmeniKuhinjuForma_Load(object sender, EventArgs e)
        {
            if(kuhinja.Posudje == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

            DTOManager.azurirajKuhinju(kuhinja);
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
            Close();
        }
    }
}
