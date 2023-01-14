using JuraganMobil.Repository;
using JuraganMobil.Summary;
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
        private ISuvRepository _suv;
        private IVehicleRepository _vehicle;
        private ISummary _summary;

        public IVehicleRepository Vehicle {
            get
            {
                if (_vehicle is null)
                    _vehicle = new VehicleRepository();

                return _vehicle;
            }
        }

        public ISuvRepository Suv
        {
            get
            {
                if (_suv is null)
                    _suv = new SuvRepository();

                return _suv;
            }
        }

        public ISummary Summary
        {
            get
            {
                if (_summary is null)
                    _summary = new InfoSummary();
                return _summary;
            }
        }
    }
}
