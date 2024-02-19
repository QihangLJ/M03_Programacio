using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public interface IVehicle
    {
        public void Drive();
        public bool Refuel(int gasolineAmount);
    }
}
