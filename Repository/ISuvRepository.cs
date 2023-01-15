using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repository
{
    internal interface ISuvRepository
    {
        List<Suv> FindAllSuv();
        Suv FindById(string id);
        List<Suv> Create(Suv suv);
        Suv Update(string id, Suv suv);
        int Delete(string id);
    }
}
