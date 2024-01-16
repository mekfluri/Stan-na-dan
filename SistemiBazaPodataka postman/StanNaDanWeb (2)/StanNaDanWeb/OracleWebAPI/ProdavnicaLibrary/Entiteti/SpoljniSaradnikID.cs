using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public class SpoljniSaradnikID
    {
        public virtual Agent UnajmioAgent { get; set; }
        public virtual string BrojTelefona { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj)) return true;

            if (obj.GetType() != typeof(SpoljniSaradnikID)) return false;

            SpoljniSaradnikID receivedObject = (SpoljniSaradnikID)obj;

            if (UnajmioAgent.maticni_broj_zaposlenog == receivedObject.UnajmioAgent.maticni_broj_zaposlenog)
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
