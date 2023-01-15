using JuraganMobil.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Repository
{
    internal interface IPrivateJetRepository
    {
        List<PrivateJet> FindAll();
        PrivateJet FindById(string id);
        List<PrivateJet> Create(PrivateJet pjet);
        PrivateJet Update(string id, PrivateJet pjet);
        int Delete(string id);
    }
}
