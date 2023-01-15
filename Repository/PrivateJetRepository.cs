using JuraganMobil.Collection;
using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repository
{
    internal class PrivateJetRepository : IPrivateJetRepository
    {
        private List<BaseVehicle> _vehicles;

        public PrivateJetRepository(IVehicleCollection collection)
        {
            _vehicles = collection.FetchAll();
        }

        public List<PrivateJet> FindAll()
        {
            List<PrivateJet> pjets = new List<PrivateJet>();

            foreach (var vhc in _vehicles)
            {
                if (vhc is PrivateJet)
                {
                    pjets.Add((PrivateJet)vhc);
                }
            }

            return pjets;
        }

        public List<PrivateJet> Create(PrivateJet pjet)
        {
            _vehicles.Add(pjet);

            return FindAll();
        }

        public int Delete(string id)
        {
            var pjet = _vehicles.Find(s => s.NoPolice.Equals(id));

            if (pjet is not null)
            {
                _vehicles.Remove(pjet);
                return 1;
            }

            return 0;
        }

        public PrivateJet FindById(string id)
        {
            var pjet = _vehicles.Find(s => s.NoPolice.Equals(id));

            if (pjet is not null)
            {
                return (PrivateJet)pjet;
            }

            return null;
        }

        public PrivateJet Update(string id, PrivateJet pjet)
        {
            var existPrivateJet = FindById(id);

            if (existPrivateJet is not null)
            {
                existPrivateJet.NoPolice = pjet.NoPolice is null ? existPrivateJet.NoPolice : pjet.NoPolice;
                existPrivateJet.Price = pjet.Price.Equals(0) ? existPrivateJet.Price : pjet.Price;
                existPrivateJet.Tax = pjet.Tax.Equals(0) ? existPrivateJet.Tax : pjet.Tax;
                existPrivateJet.Seat = pjet.Seat.Equals(0) ? existPrivateJet.Seat : pjet.Seat;
                existPrivateJet.Year = pjet.Year is null ? existPrivateJet.Year : pjet.Year;
                existPrivateJet.TransactionDate = pjet.TransactionDate.Equals(1 / 1 / 0001) ? existPrivateJet.TransactionDate : pjet.TransactionDate;
                existPrivateJet.Rent = pjet.Rent.Equals(0) ? existPrivateJet.Rent : pjet.Rent;
                existPrivateJet.Driver = pjet.Driver.Equals(0) ? existPrivateJet.Driver : pjet.Driver;

                return existPrivateJet;
            }
            return existPrivateJet;
        }
    }
}
