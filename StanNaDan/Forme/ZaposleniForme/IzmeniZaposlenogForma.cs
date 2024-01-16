using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace StanNaDanv2.Forme
{
    public partial class IzmeniZaposlenogForma : Form
    {
        SamoZaposleniBasic radnik;
        public IzmeniZaposlenogForma()
        {
            InitializeComponent();
        }
        public IzmeniZaposlenogForma(SamoZaposleniBasic radnikk)
        {
            InitializeComponent();
            radnik = radnikk;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            radnik.ime = textBox3.Text;
            radnik.datum_zaposlenja = dateTimePicker1.Value;
           
            //radnik.Sef = false;

            DTOManager.azurirajZaposlenog(radnik);
            MessageBox.Show("Uspesno ste izmenili podatke o zaposlenom!");
            this.Close();
        }

        private void IzmeniZaposlenogForma_Load(object sender, EventArgs e)
        {

        }
    }
}
