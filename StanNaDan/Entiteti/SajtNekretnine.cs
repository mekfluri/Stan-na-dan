using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
   public class SajtNekretnine
    {

        public virtual Nekretnina nekretnina { get; set; }
        public virtual string sajt { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(SajtNekretnine))
                return false;

            SajtNekretnine recievedObject = (SajtNekretnine)obj;

            if ((nekretnina.nekretninaID == recievedObject.nekretnina.nekretninaID) &&
                (sajt == recievedObject.sajt))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
    

