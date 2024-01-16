using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class VlasnikView
    {
        public int VlasnikID { get; set; }
        public string broj_bankovnog_racuna { get; set; }
        public string banka { get; set; }
        public virtual PravnoLiceView PravnoL { get; set; }
        public virtual FizickoLiceView FizickoL { get; set; }
        public virtual AgencijaView AgencijaB { get; set; }

        public VlasnikView(int vlID, string brrac, string banka)
        {
            this.VlasnikID = vlID;
            this.broj_bankovnog_racuna = brrac;
            this.banka = banka;
        }

        public VlasnikView()
        {

        }
    }
}
