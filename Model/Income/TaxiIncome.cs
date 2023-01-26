using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model.Income
{
    internal class TaxiIncome : BaseIncome
    {
        private DateOnly _transactionDate;
        private int _order;
        private decimal _orderPerKm;
        private decimal _total;

        public int Order
        {
            get => _order;
            set
            {
                _order = value;
                _total = _order * _orderPerKm;
            }
        }

        public decimal Driver
        {
            get => _orderPerKm;
            set
            {
                _orderPerKm = value;
                _total = _orderPerKm * _order;
            }
        }

        public override DateOnly TransactionDate { get => _transactionDate; set => _transactionDate = value; }

        public override decimal Total => _total;
    }
}
