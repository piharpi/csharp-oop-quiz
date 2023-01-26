using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuraganMobil.Model.Vehicle;

namespace JuraganMobil.Model
{
    internal class Taxi : Car
    {
        private DateOnly _transactionDate;
        private int _order;
        private decimal _orderPerKm;
        private decimal _total;
        private static int _count;
        public Taxi(string noPolice, string year, decimal price, decimal tax, int seat, DateOnly transactionDate, int order, decimal orderPerKm) : base(noPolice, year, price, tax, seat)
        {
            _transactionDate = transactionDate;
            _order = order;
            _orderPerKm = orderPerKm;
            _total = _order * _orderPerKm;
            _count += 1;
        }
        public DateOnly TransactionDate { get => _transactionDate; set => _transactionDate = value; }
        public decimal Total { get => _total; }
        public int Order 
        { 
            get => _order;
            set 
            {
                _order = value;
                _total = _order * _orderPerKm;
            } 
        }
        public decimal OrderPerKm 
        { 
            get => _orderPerKm;
            set 
            {
                _orderPerKm = value;
                _total = _orderPerKm * _order;
            }  
        }
        public static int Count => _count;
    }
}
