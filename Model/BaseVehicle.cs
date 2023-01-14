using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Model
{
    internal abstract class BaseVehicle
    {
        public abstract string NoPolice { get; set; }
        public abstract string Year { get; set; }
        public abstract decimal Price { get; set; }
        public abstract decimal Tax { get; set; }
        public abstract int Seat { get; set; }
    }
}
