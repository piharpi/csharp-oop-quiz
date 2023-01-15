﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model
{
    internal class PrivateJet : Plane
    {
        private DateOnly _transactionDate;
        private decimal _rent;
        private decimal _driver;
        private decimal _total;
        private static int _count;
        public PrivateJet(string noPolice, string year, decimal price, decimal tax, int seat, DateOnly transactionDate, decimal rent, decimal driver) : base(noPolice, year, price, tax, seat)
        {
            _rent = rent;
            _driver = driver;
            _transactionDate = transactionDate;
            _total = _rent + _driver;
            _count += 1;
        }

        public decimal Total => _total;
        public DateOnly TransactionDate1 { get => _transactionDate; set => _transactionDate = value; }
        public decimal Rent { get => _rent; set => _rent = value; }
        public decimal Driver { get => _driver; set => _driver = value; }
        public static int Count()
        {
            return _count;
        }

    }
}
