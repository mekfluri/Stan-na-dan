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
    public partial class IzmeniParkingMesta : Form
    {
        ParkingMestoBasic parking;
        public IzmeniParkingMesta(ParkingMestoBasic p)
        {
            InitializeComponent();
            parking = p;
        }

        private void IzmeniParkingMesta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parking.Lokacija = textBox1.Text;
            parking.CenaParkingMesta = double.Parse(textBox2.Text);

            DTOManager.azurirajParkingMesto(parking);
            Close();
        }
    }
}
