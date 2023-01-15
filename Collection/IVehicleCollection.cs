using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Collection
{
    internal interface IVehicleCollection
    {
        List<BaseVehicle> FetchAll();
    }
}
