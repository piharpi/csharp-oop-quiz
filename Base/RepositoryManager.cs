using JuraganMobil.Collection;
using JuraganMobil.Model;
using JuraganMobil.Repository;
using JuraganMobil.InfoSummary;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Base
{
    internal class RepositoryManager : IRepositoryManager
    {
        private IVehicleCollection _vehicles;

        private ISuvRepository? _suv;
        private ITaxiRepository? _taxi;
        private IPrivateJetRepository? _privateJet;

        private ISummary? _summary;

        public RepositoryManager(IVehicleCollection collection)
        {
            _vehicles = collection;
        }

        public ISuvRepository Suv
        {
            get
            {
                if (_suv is null)
                    _suv = new SuvRepository(_vehicles);

                return _suv;
            }
        }

        public IPrivateJetRepository PrivateJet
        {
            get
            {
                if (_privateJet is null)
                    _privateJet = new PrivateJetRepository(_vehicles);

                return _privateJet;
            }
        }

        public ISummary Summary
        {
            get
            {
                if (_summary is null)
                    _summary = new Summary(_vehicles);
                return _summary;
            }
        }

        public ITaxiRepository Taxi 
        {
            get
            {
                if (_taxi is null)
                    _taxi = new TaxiRepository(_vehicles);

                return _taxi;
            }
        }
    }
}
