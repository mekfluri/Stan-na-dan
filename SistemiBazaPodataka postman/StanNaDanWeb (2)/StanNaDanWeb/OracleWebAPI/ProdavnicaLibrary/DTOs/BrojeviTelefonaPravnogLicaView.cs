using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class BrojeviTelefonaPravnogLicaView
    {
        public IDBrTelPLView IDbroja { get; set; }

        public BrojeviTelefonaPravnogLicaView(IDBrTelPLView id)
        {
            this.IDbroja = id;
        }

        public BrojeviTelefonaPravnogLicaView()
        {
        }
    }
}
