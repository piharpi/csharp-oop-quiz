using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Summary
{
    internal interface ISummary
    {
        int GetTotalVehicle();
        decimal GetTotalIncomeVehicle();
        int GetTotalVehicle(Object vehicle);
        decimal GetTotalIncomeVehicle(Object vehicle);
    }
}
