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

        public ISuvRepository Suv => _suv ??= new SuvRepository(_vehicles);

        public IPrivateJetRepository PrivateJet => _privateJet ??= new PrivateJetRepository(_vehicles);

        public ISummary Summary => _summary ??= new Summary(_vehicles);

        public ITaxiRepository Taxi => _taxi ??= new TaxiRepository(_vehicles);
    }
}
