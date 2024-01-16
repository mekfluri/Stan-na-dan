using NHibernate;
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
    public partial class SpoljniSaradnikForma : Form
    {
        string matbr_agenta;
        public SpoljniSaradnikForma(string m)
        {
            matbr_agenta = m;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//dodaj
        {
            DodajSpoljnogSaradnika forma = new DodajSpoljnogSaradnika(matbr_agenta);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void SpoljniSaradnikForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        private void popuniPodacima()
        {
            listaSpoljnihSaradnika.Items.Clear();

            List<SpoljniSaradnikPregled> podaci = DTOManager.vratiSveSpoljneSaradnikeAgenta(matbr_agenta);

            foreach(SpoljniSaradnikPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    p.Ime,
                    p.ImeAgenta,
                    p.MaticniBrojAgenta,
                    p.BrojTelefona,
                    p.DatumAngazovanja.ToString(),
                    p.Procenat.ToString(),
                    p.TipNekretnine
                });
                listaSpoljnihSaradnika.Items.Add(item);
            }

            listaSpoljnihSaradnika.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)//izmeni
        {
            if(listaSpoljnihSaradnika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite spoljnog saradnika cije podatke zelite da izmenite!");
                return;
            }

            SpoljniSaradnikID saradnikID = new SpoljniSaradnikID();
            saradnikID.BrojTelefona = listaSpoljnihSaradnika.SelectedItems[0].SubItems[3].Text;
            string matbragenta = listaSpoljnihSaradnika.SelectedItems[0].SubItems[2].Text;

            saradnikID.UnajmioAgent = DTOManager.vratiAgentaNeBasic(matbragenta);

            SpoljniSaradnikBasic ss = DTOManager.vratiSpoljnogSaradnika(saradnikID);

            IzmeniSpoljnogSaradnika forma = new IzmeniSpoljnogSaradnika(ss);

        }

        private void button3_Click(object sender, EventArgs e)//brisanje radnika
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (listaSpoljnihSaradnika.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite spoljnjeg saradnika koga zelite da obrisete");
                    return;
                }

                SpoljniSaradnikID saradnikID = new SpoljniSaradnikID();
                saradnikID.BrojTelefona = listaSpoljnihSaradnika.SelectedItems[0].SubItems[3].Text;
                saradnikID.UnajmioAgent = s.Load<Agent>(listaSpoljnihSaradnika.SelectedItems[0].SubItems[2].Text);

                string poruka = "Da li zelite da obrisete izabranog spoljnjeg saradnika?";
                string title = "Pitanje";

                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(poruka, title, buttons);

                if (result == DialogResult.OK)
                {
                    DTOManager.obrisiSpoljnogSaradnika(saradnikID);
                    MessageBox.Show("Brisanje spoljnjeg saradnika je uspesno obavljeno");
                    this.popuniPodacima();
                }
            }
            catch(Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
    }
}
