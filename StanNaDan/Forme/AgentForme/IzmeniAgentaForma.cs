using StanNaDanv2.Entiteti;
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
    public partial class IzmeniAgentaForma : Form
    {
        AgentBasic sef;
        public IzmeniAgentaForma()
        {
            InitializeComponent();
        }
        public IzmeniAgentaForma(AgentBasic a)
        {
            InitializeComponent();
            sef= a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sef.strucna_sprema = strucna_sprema.Text;
            sef.datum_zaposlenja = datum_zaposlenja.Value;

            sef.ime = ime.Text;
            DTOManager.izmeniAgenta(sef);
            this.Close();

        }

        private void IzmeniAgentaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
