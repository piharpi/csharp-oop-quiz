﻿using JuraganMobil.Collection;
using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.InfoSummary
{
    internal class Summary : ISummary
    {
        IVehicleCollection _vehicles;

        public Summary(IVehicleCollection collection)
        {
            _vehicles = collection;
        }

        public decimal GetTotalIncomeVehicle()
        {
            decimal totalIncome = 0;

            foreach (BaseVehicle vehicle in _vehicles.FetchAll())
            {
                if (vehicle is Suv)
                {
                    Suv suv = (Suv)vehicle;
                    totalIncome += suv.Total;
                }

                if (vehicle is Taxi)
                {
                    Taxi taxi = (Taxi)vehicle;
                    totalIncome += taxi.Total;
                }

                if (vehicle is PrivateJet)
                {
                    PrivateJet jet = (PrivateJet)vehicle;
                    totalIncome += jet.Total;
                }
            }

            return totalIncome;
        }

        public decimal GetTotalIncomeVehicle(string vehicle)
        {
            decimal totalIncome = 0;

            foreach (BaseVehicle vhc in _vehicles.FetchAll())
            {
                if (vehicle == "Suv" && vhc.GetType().Name == vehicle)
                {
                    Suv suv = (Suv)vhc;
                    totalIncome += suv.Total;
                }

                if (vehicle == "Taxi" && vhc.GetType().Name == vehicle)
                {
                    Taxi taxi = (Taxi)vhc;
                    totalIncome += taxi.Total;
                }

                if (vehicle == "PrivateJet" && vhc.GetType().Name == vehicle)
                {
                    PrivateJet jet = (PrivateJet)vhc;
                    totalIncome += jet.Total;
                }
            }

            return totalIncome;
        }

        public int GetTotalVehicle(String vehicle)
        {
            if (vehicle.Equals("Suv"))
                return Suv.Count();

            if (vehicle.Equals("Taxi"))
                return Taxi.Count();

            if (vehicle.Equals("PrivateJet"))
                return PrivateJet.Count();

            return 0;
        }

        public int GetTotalVehicle()
        {
            return _vehicles.FetchAll().Count();
        }
    }
}
