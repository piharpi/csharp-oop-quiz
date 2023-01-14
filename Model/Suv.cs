using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model
{
    internal class Suv : Car
    {
        private DateOnly _transactionDate;
        private decimal _rent;
        private decimal _driver;
        private decimal _total;
        private static int _count;
        public Suv(string noPolice, string year, decimal price, decimal tax, int seat, DateOnly transactionDate, decimal rent, decimal driver) : base(noPolice, year, price, tax, seat)
        {
            _transactionDate = transactionDate;
            _rent = rent;
            _driver = driver;
            _total = _rent + _driver;
            _count += 1;
        }
        public DateOnly TransactionDate { get => _transactionDate; set => _transactionDate = value; }
        public decimal Total { get => _total; } 
        public decimal Rent { get => _rent; set => _rent = value; }
        public decimal Driver { get => _driver; set => _driver = value; }

        public static int Count()
        {
            return _count;
        }
    }
}