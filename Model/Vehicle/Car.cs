using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model.Vehicle
{
    internal class Car : BaseVehicle
    {
        private string _noPolice;
        private string _year;
        private decimal _price;
        private decimal _tax;
        private int _seat;

        public Car(string noPolice, string year, decimal price, decimal tax, int seat)
        {
            _noPolice = noPolice;
            _year = year;
            _price = price;
            _tax = tax;
            _seat = seat;
        }
        public override string NoPolice { get => _noPolice; set => _noPolice = value; }
        public override string Year { get => _year; set => _year = value; }
        public override decimal Price { get => _price; set => _price = value; }
        public override decimal Tax { get => _tax; set => _tax = value; }
        public override int Seat { get => _seat; set => _seat = value; }

        public override string ToString()
        {
            return $"{NoPolice} \t {Year} \t {Price} \t {Tax} \t {Seat}";
        }
    }
}
