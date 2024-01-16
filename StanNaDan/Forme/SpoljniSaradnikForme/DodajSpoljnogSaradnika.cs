using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StanNaDanv2.Entiteti;

namespace StanNaDanv2.Forme
{
    public partial class DodajSpoljnogSaradnika : Form
    {
        private string matbr_agenta;
        public DodajSpoljnogSaradnika(string matbr_agenta)
        {
            this.matbr_agenta = matbr_agenta;
            InitializeComponent();
        }

        private void DodajSpoljnogSaradnika_Load(object sender, EventArgs e)
        {
            popuniNajmove();
        }
        private void popuniNajmove()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string broj = textBoxBroj.Text;
            string ime = textBoxIme.Text;
            DateTime datumAng = datumAngazovanja.Value;
            double procenat = (double)(numericUpDown1.Value);
            SpoljniSaradnikID saradnikID = new SpoljniSaradnikID();



            saradnikID.BrojTelefona = broj;
            saradnikID.UnajmioAgent = DTOManager.vratiAgentaNeBasic(matbr_agenta);
            //da se ucita ucestvovao najam iz CB

            int najamid = Int32.Parse(textBoxNajamID.Text);
            Najam najam = DTOManager.vratiNajamNeBasic(najamid);
            SpoljniSaradnikBasic spoljni = new SpoljniSaradnikBasic(saradnikID, saradnikID.UnajmioAgent, saradnikID.BrojTelefona, ime, datumAng, procenat);

            DTOManager.dodajSpoljnogSaradnika(spoljni);

            Close();
        }
    }
}
