using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model
{
    internal class Plane : BaseVehicle
    {
        private string _noRegister;
        private string _year;
        private decimal _price;
        private decimal _tax;
        private int _seat;

        public Plane(string noPolice, string year, decimal price, decimal tax, int seat)
        {
            _noRegister = noPolice;
            _year = year;
            _price = price;
            _tax = tax;
            _seat = seat;
        }

        public override string NoPolice { get => _noRegister; set => _noRegister = value; }
        public string NoRegister { get => NoPolice; set => NoPolice = value; }
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
