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
    public partial class IzmeniKvartForma : Form
    {
        KvartBasic o;
        public IzmeniKvartForma()
        {
            InitializeComponent();
        }
        public IzmeniKvartForma(KvartBasic kvar)
        {
            InitializeComponent();
           o= kvar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            o.broj_nekretnina = (int)numericUpDown1.Value;
            o.gradska_zona = textBox1.Text;
         
            DTOManager.izmeniKvart(o);
            MessageBox.Show("Uspesno ste izmenili kvart!");
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
