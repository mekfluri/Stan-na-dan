using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    internal class ParkingMesto : Dodaci
    {
        public virtual string LokacijaParkingMesta { get; set; }
        public virtual double CenaParkingMesta { get; set; }
    }
}
