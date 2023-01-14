using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model
{
    internal class PrivateJet : Plane
    {

        private static int _count;
        public PrivateJet(string noPolice, string year, decimal price, decimal tax, int seat) : base(noPolice, year, price, tax, seat)
        {
            _count += 1;
        }

        public decimal Total => throw new NotImplementedException();

        public static int Count()
        {
            return _count;
        }

    }
}
