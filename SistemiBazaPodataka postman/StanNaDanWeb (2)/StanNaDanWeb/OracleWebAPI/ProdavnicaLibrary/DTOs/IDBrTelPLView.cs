using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class IDBrTelPLView
    {
        public virtual PravnoLiceView pravnolicebroj { get; set; }
        public virtual int broj_telefona { get; set; }

        public IDBrTelPLView(int broj_telefona)
        {
            this.broj_telefona = broj_telefona;
        }

        public IDBrTelPLView()
        {

        }
    }
}
