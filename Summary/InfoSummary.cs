using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Summary
{
    internal class InfoSummary : ISummary
    {
        public InfoSummary() { 
        
        
        } 
        public decimal GetTotalIncomeVehicle()
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalIncomeVehicle(Object vehicle)
        {
            throw new NotImplementedException();
        }

        public int GetTotalVehicle(Object vehicle)
        {
            if (vehicle is Suv)
                return Suv.Count();

            if (vehicle is Taxi)
                return Taxi.Count();

            if (vehicle is PrivateJet)
                return PrivateJet.Count();

            return 0;
        }

        public int GetTotalVehicle()
        {
            return Suv.Count() + Taxi.Count() + PrivateJet.Count();
        }
    }
}
