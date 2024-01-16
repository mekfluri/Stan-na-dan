using System;
using System.Collections.Generic;
using System.Text;


namespace StanNaDanLibrary.DTOs
{
    public class BrojeviTelefonaFizickogLicaView
    {
        public IDBrTelFLView IDbroja { get; set; }
        public BrojeviTelefonaFizickogLicaView(IDBrTelFLView id)
        {
            this.IDbroja = id;
        }
        public BrojeviTelefonaFizickogLicaView()
        {

        }
    }
}
