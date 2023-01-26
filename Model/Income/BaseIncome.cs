using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model.Income
{
    internal abstract class BaseIncome
    {
        public abstract DateOnly TransactionDate { get; set; }
        public abstract decimal Total { get; }
    }
}
