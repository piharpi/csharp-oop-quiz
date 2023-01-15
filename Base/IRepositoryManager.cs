using JuraganMobil.Collection;
using JuraganMobil.Model;
using JuraganMobil.Repository;
using JuraganMobil.InfoSummary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Base
{
    internal interface IRepositoryManager
    {
        public ISuvRepository Suv { get; }

        public ISummary Summary { get; }
    }
}
