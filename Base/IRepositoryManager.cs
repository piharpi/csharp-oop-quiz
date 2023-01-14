using JuraganMobil.Model;
using JuraganMobil.Repository;
using JuraganMobil.Summary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Base
{
    internal interface IRepositoryManager
    {
        public IVehicleRepository Vehicle { get; }
        public ISuvRepository Suv { get; }

        public ISummary Summary { get; }
    }
}
