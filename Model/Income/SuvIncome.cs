﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model.Income
{
    internal class SuvIncome : BaseIncome
    {
        private DateOnly _transactionDate;
        private decimal _rent;
        private decimal _driver;
        private decimal _total;

        public decimal Rent
        {
            get => _rent;
            set
            {
                _rent = value;
                _total = _rent + _driver;
            }
        }

        public decimal Driver
        {
            get => _driver;
            set
            {
                _driver = value;
                _total = _driver + _rent;
            }
        }

        public override DateOnly TransactionDate { get => _transactionDate; set => _transactionDate = value; }

        public override decimal Total => _total;
    }
}
