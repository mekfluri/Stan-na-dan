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
    public partial class DodajAgentaForma : Form
    {
        PoslovnicaBasic poslovnica;
        public DodajAgentaForma()
        {
            InitializeComponent();
        }
        public DodajAgentaForma(PoslovnicaBasic p)
        {
            InitializeComponent();
            poslovnica = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgentBasic o = new AgentBasic();
            o.maticni_broj_zaposlenog = maticni_broj.Text;
            o.ime = ime.Text;
            o.strucna_sprema = strucna_sprema.Text;
            o.datum_zaposlenja = datum_zaposlenja.Value;
            o.Poslovnica = poslovnica;
           
            DTOManager.DodajAgenta(o);
            MessageBox.Show("Uspesno ste dodali agenta!");
            this.Close();
        }
    }
}
