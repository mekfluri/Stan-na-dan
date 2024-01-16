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
    public partial class IzmeniSpoljnogSaradnika : Form
    {
        SpoljniSaradnikBasic spoljniSaradnik;
        public IzmeniSpoljnogSaradnika(SpoljniSaradnikBasic ss)
        {
            InitializeComponent();
            spoljniSaradnik = ss;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spoljniSaradnik.Id.BrojTelefona = textBox1.Text;
            spoljniSaradnik.Ime = textBox2.Text;
            spoljniSaradnik.Procenat = (double)(numericUpDown1.Value);

            DTOManager.izmeniSpoljnogSaradnika(spoljniSaradnik);
            Close();
        }
    }
}
