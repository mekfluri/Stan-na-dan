using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class IDBrTelFLView
    {
        public virtual FizickoLiceView fizickolicebroj { get; set; }
        public virtual int broj_telefona { get; set; }

        public IDBrTelFLView(int broj_telefona)
        {
            this.broj_telefona = broj_telefona;
        }

        public IDBrTelFLView()
        {

        }
    }
}
