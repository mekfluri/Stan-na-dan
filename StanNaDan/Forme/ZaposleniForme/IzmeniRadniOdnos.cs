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
    public partial class IzmeniRadniOdnos : Form
    {
        public IzmeniRadniOdnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  radi.DatumOd = datumOd.Value;
            if (chbDatumDo.Checked == true)
                radi.DatumDo = null;
            else
                radi.DatumDo = (DateTime?)DatumDo.Value;
            DTOManager.izmeniRadniOdnos(radi);
            MessageBox.Show("Uspesno ste izmenili podatke o radnom odnosu!");
            this.Close();*/ //kad povezes sa agencijom
        }
    }
}
