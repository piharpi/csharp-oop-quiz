using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repository
{
    internal class VehicleRepository : IVehicleRepository
    {
        List<BaseVehicle> vehicles = new List<BaseVehicle>();

        public VehicleRepository() { }
        public List<BaseVehicle> FindAll()
        {
            throw new NotImplementedException();
        }

        public BaseVehicle FindById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
