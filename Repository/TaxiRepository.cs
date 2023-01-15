using JuraganMobil.Collection;
using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repository
{
    internal class TaxiRepository : ITaxiRepository
    {
        private List<BaseVehicle> _vehicles;

        public TaxiRepository(IVehicleCollection collection)
        {
            _vehicles = collection.FetchAll();
        }

        public List<Taxi> FindAll()
        {
            List<Taxi> txs = new List<Taxi>();

            foreach (var vhc in _vehicles)
            {
                if (vhc is Taxi)
                {
                    txs.Add((Taxi)vhc);
                }
            }

            return txs;
        }

        public List<Taxi> Create(Taxi taxi)
        {
            _vehicles.Add(taxi);

            return FindAll();
        }

        public int Delete(string id)
        {
            var txs = _vehicles.Find(s => s.NoPolice.Equals(id));

            if (txs is not null)
            {
                _vehicles.Remove(txs);
                return 1;
            }

            return 0;
        }

        public Taxi FindById(string id)
        {
            var txs = _vehicles.Find(s => s.NoPolice.Equals(id));

            if (txs is not null)
            {
                return (Taxi)txs;
            }

            return null;
        }

        public Taxi Update(string id, Taxi taxi)
        {
            var existTaxi = FindById(id);

            if (existTaxi is not null)
            {
                existTaxi.NoPolice = taxi.NoPolice is null ? existTaxi.NoPolice : taxi.NoPolice;
                existTaxi.Price = taxi.Price.Equals(0) ? existTaxi.Price : taxi.Price;
                existTaxi.Tax = taxi.Tax.Equals(0) ? existTaxi.Tax : taxi.Tax;
                existTaxi.Seat = taxi.Seat.Equals(0) ? existTaxi.Seat : taxi.Seat;
                existTaxi.Year = taxi.Year is null ? existTaxi.Year : taxi.Year;
                existTaxi.TransactionDate = taxi.TransactionDate.Equals(1 / 1 / 0001) ? existTaxi.TransactionDate : taxi.TransactionDate;
                existTaxi.Order = taxi.Order.Equals(0) ? existTaxi.Order : taxi.Order;
                existTaxi.OrderPerKm = taxi.OrderPerKm.Equals(0) ? existTaxi.OrderPerKm : taxi.OrderPerKm;

                return existTaxi;
            }
            return existTaxi;
        }
    }
}
