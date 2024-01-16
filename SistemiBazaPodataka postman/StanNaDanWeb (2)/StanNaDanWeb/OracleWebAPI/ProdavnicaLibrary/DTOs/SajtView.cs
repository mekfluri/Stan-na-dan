using System;
using System.Collections.Generic;
using System.Text;

namespace StanNaDanLibrary.DTOs
{
    public class SajtView
    {
        public SajtNekretninaView sajtID { get; set; }
        public SajtView(SajtNekretninaView sajt)
        {
            this.sajtID = sajt;
        }

        public SajtView() { }
    }
}
