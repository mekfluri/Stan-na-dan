using StanNaDanv2;
using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class AgentView : ZaposleniView
    {
        public string strucna_sprema { get; set; }
        public AgentView() { }
        public AgentView(string strucna_sprema, DateTime datum_postavljanja, string maticni_broj, string ime, bool isSef, bool isAgent, DateTime datum_zaposlenja, PoslovniceView poslovnica, AgencijaView agencija)
            : base(maticni_broj, ime, isSef, isAgent, datum_zaposlenja, poslovnica, agencija)
        {
            this.strucna_sprema = strucna_sprema;
        }
    }
}
