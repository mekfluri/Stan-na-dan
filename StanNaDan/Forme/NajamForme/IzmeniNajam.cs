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
    public partial class IzmeniNajam : Form
    {
        NajamBasic najam;
        public IzmeniNajam(NajamBasic n)
        {
            najam = n;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nekretninaID = Int32.Parse(textBoxNekretninaID.Text);
            DateTime datPoc = dateTimePicker4.Value;
            DateTime datKraj = dateTimePicker3.Value;
            double cenaPoDanu = Int32.Parse(textBox2.Text);
            double popust = (double)(numericUpDown2.Value);

            najam.IznajmljenaNekretnina = DTOManager.vratiNekretninu(nekretninaID);
            najam.DatumPocetka = datPoc;
            najam.DatumZavrsetka = datKraj;
            najam.CenaPoDanu = cenaPoDanu;
            najam.Popust = popust;

            int brDana = (int)((datKraj - datPoc).TotalDays);
            najam.UkupnaCena = brDana*cenaPoDanu;
            najam.CenaSaPopustom = najam.UkupnaCena * najam.Popust;
            najam.BrojDana = brDana;

            DTOManager.azurirajNajam(najam);

            Close();
        }

        private void IzmeniNajam_Load(object sender, EventArgs e)
        {

        }
    }
}
