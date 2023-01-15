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

        private ISuvRepository _suv;
        private ISummary _summary;

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

        public ISummary Summary
        {
            get
            {
                if (_summary is null)
                    _summary = new Summary(_vehicles);
                return _summary;
            }
        }
    }
}
