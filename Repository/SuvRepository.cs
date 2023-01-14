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

        private List<Suv> _suvs;

        public SuvRepository()
        {
            _suvs = new List<Suv>{
                new Suv("D 1001 UM", "2010", 350000000M, 3500000M, 4, new DateOnly(2023, 01, 10), 500000M, 150000M)
               ,new Suv("D 1002 UM", "2010", 350000000M, 3500000M, 4, new DateOnly(2023, 01, 10), 500000M, 150000M)
               ,new Suv("D 1003 UM", "2015", 350000000M, 3500000M, 5, new DateOnly(2023, 01, 12), 500000M, 150000M)
               ,new Suv("D 1004 UM", "2015", 350000000M, 3500000M, 5, new DateOnly(2023, 01, 13), 500000M, 150000M)
            };
        }

        public List<Suv> FindAll()
        {
            return _suvs;
        }

        public List<Suv> Create(Suv suv)
        {
            _suvs.Add(suv);

            return FindAll();
        }

        public int Delete(string id)
        {
            var suvId = _suvs.Find(s => s.NoPolice.Equals(id));

            if (suvId is not null)
            {
               _suvs.Remove(suvId);
               return 1;
            }

            return 0;
        }

        public Suv FindById(string id)
        {
            var suvId = _suvs.Find(s => s.NoPolice.Equals(id));

            if (suvId is not null)
            {
                return suvId;
            }

            return null;
        }

        public Suv Update(string id, Suv suv)
        {
            var existSuv = FindById(id);
            var suvIdx = _suvs.FindIndex(s => s.NoPolice.Equals(id));

            if (existSuv is not null)
            {
                existSuv.NoPolice = suv.NoPolice is null ? existSuv.NoPolice : suv.NoPolice;
                existSuv.Price = suv.Price.Equals(0) ? existSuv.Price : suv.Price;
                existSuv.Tax = suv.Tax.Equals(0) ? existSuv.Tax : suv.Tax;
                existSuv.Seat = suv.Seat.Equals(0) ? existSuv.Seat : suv.Seat;
                existSuv.Year = suv.Year is null ? existSuv.Year : suv.Year;
                existSuv.TransactionDate = suv.TransactionDate.Equals(1/1/0001) ? existSuv.TransactionDate : suv.TransactionDate;
                existSuv.Rent = suv.Rent.Equals(0) ? existSuv.Rent : suv.Rent;
                existSuv.Driver = suv.Rent.Equals(0) ? existSuv.Driver : suv.Driver;

                _suvs[suvIdx] = existSuv;

                return existSuv;
            }
            return existSuv;
        }
    }
}
