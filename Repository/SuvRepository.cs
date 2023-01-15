using JuraganMobil.Collection;
using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace JuraganMobil.Repository
{
    internal class SuvRepository : ISuvRepository
    {

        private List<BaseVehicle> _vehicles;    

        public SuvRepository(IVehicleCollection collection)
        {
            _vehicles = collection.FetchAll(); 
        }

        public List<Suv> FindAll()
        {
            List<Suv> suvs = new List<Suv>();

            foreach (var vhc in _vehicles)
            {
                if (vhc is Suv)
                {
                    suvs.Add((Suv)vhc);
                }
            }

            return suvs;
        }

        public List<Suv> Create(Suv suv)
        {
            _vehicles.Add(suv);

            return FindAll();
        }

        public int Delete(string id)
        {
            var suvId = _vehicles.Find(s => s.NoPolice.Equals(id));

            if (suvId is not null)
            {
               _vehicles.Remove(suvId);
               return 1;
            }

            return 0;
        }

        public Suv FindById(string id)
        {
            var suvId = _vehicles.Find(s => s.NoPolice.Equals(id));

            if (suvId is not null)
            {
                return (Suv)suvId;
            }

            return null;
        }

        public Suv Update(string id, Suv suv)
        {
            var existSuv = FindById(id);

            if (existSuv is not null)
            {
                existSuv.NoPolice = suv.NoPolice is null ? existSuv.NoPolice : suv.NoPolice;
                existSuv.Price = suv.Price.Equals(0) ? existSuv.Price : suv.Price;
                existSuv.Tax = suv.Tax.Equals(0) ? existSuv.Tax : suv.Tax;
                existSuv.Seat = suv.Seat.Equals(0) ? existSuv.Seat : suv.Seat;
                existSuv.Year = suv.Year is null ? existSuv.Year : suv.Year;
                existSuv.TransactionDate = suv.TransactionDate.Equals(1/1/0001) ? existSuv.TransactionDate : suv.TransactionDate;
                existSuv.Rent = suv.Rent.Equals(0) ? existSuv.Rent : suv.Rent;
                existSuv.Driver = suv.Driver.Equals(0) ? existSuv.Driver : suv.Driver;

                return existSuv;
            }
            return existSuv;
        }
    }
}
