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
    public partial class FormaZaAzuriranjeTelefonaFizickogLica : Form
    {
        BrojeviTelefonaFizickogLicaBasic fizickoLice;
        public FormaZaAzuriranjeTelefonaFizickogLica()
        {
            InitializeComponent();
        }

        public FormaZaAzuriranjeTelefonaFizickogLica(BrojeviTelefonaFizickogLicaBasic fizlice)
        {
            InitializeComponent();
            fizickoLice = fizlice;
        }

        private void FormaZaAzuriranjeTelefonaFizickogLica_Load(object sender, EventArgs e)
        {

        }
    }
}
