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
    public partial class FormaZaSveVlasnike : Form
    {
        public FormaZaSveVlasnike()
        {
            InitializeComponent();
        }

        private void FormaZaSveVlasnike_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();
            List<VlasnikPregled> podaci = DTOManager.vratiVlasnike();

            foreach (VlasnikPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.VlasnikID.ToString(), p.broj_bankovnog_racuna, p.banka });
                listView1.Items.Add(item);
            }


            listView1.Refresh();
        }
    }
}
