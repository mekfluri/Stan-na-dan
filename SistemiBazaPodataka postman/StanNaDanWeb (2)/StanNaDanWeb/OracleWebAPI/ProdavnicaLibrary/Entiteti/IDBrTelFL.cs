using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2.Entiteti
{
    public class IDBrTelFL
    {
        public virtual FizickoLice fizickolicebroj { get; set; }
        public virtual int broj_telefona { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(IDBrTelFL))
                return false;

            IDBrTelFL recievedObject = (IDBrTelFL)obj;

            if ((fizickolicebroj.maticni_broj == recievedObject.fizickolicebroj.maticni_broj) &&
                (broj_telefona == recievedObject.broj_telefona))
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
