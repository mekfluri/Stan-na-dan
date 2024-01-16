using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class RaspolozivoMestoView
    {
        public RaspolozivaMestaNekretnineView id { get; set; }
        public RaspolozivoMestoView(RaspolozivaMestaNekretnineView id)
        {
            this.id = id;
        }

        public RaspolozivoMestoView()
        {

        }
    }
}
