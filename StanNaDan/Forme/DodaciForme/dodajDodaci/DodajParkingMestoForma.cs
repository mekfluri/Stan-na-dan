using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanNaDanv2.Forme.DodaciForme.formeDodavanje
{
    public partial class DodajParkingMestoForma : Form
    {
        ParkingMestoBasic parking;
        public DodajParkingMestoForma(ParkingMestoBasic parking)
        {
            InitializeComponent();
            this.parking = parking;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parking.Lokacija = textBox1.Text;
            parking.CenaParkingMesta = double.Parse(textBox2.Text);
            parking.TipDodatka = "ParkingMesto";
            DTOManager.sacuvajParkingMesto(parking);
            Close();
        }
    }
}
