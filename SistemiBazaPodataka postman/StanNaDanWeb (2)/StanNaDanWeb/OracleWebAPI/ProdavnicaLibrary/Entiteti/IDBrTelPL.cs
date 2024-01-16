using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanNaDanv2 .Entiteti
{
    public class IDBrTelPL
    {
        public virtual PravnoLice pravnolicebroj { get; set; }
        public virtual int broj_telefona { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(IDBrTelPL))
                return false;

            IDBrTelPL recievedObject = (IDBrTelPL)obj;

            if ((pravnolicebroj.PIB == recievedObject.pravnolicebroj.PIB) &&
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

