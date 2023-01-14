using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repository
{
    internal interface IVehicleRepository
    {
        List<BaseVehicle> FindAll();
        BaseVehicle FindById(string id);     
    }
}
