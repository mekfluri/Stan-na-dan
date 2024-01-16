using System;

namespace StanNaDanv2.Entiteti
{
    public class RaspolozivaMestaNekretnine
    {

        public virtual Nekretnina nekretnina { get; set; }
        public virtual string raspoloziva_mesta { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(RaspolozivaMestaNekretnine))
                return false;

            RaspolozivaMestaNekretnine recievedObject = (RaspolozivaMestaNekretnine)obj;

            if ((nekretnina.nekretninaID == recievedObject.nekretnina.nekretninaID) &&
                (raspoloziva_mesta == recievedObject.raspoloziva_mesta))
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
    
