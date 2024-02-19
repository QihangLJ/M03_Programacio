using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Car : IVehicle
    {
        private int gasolineAmount;
        public Car(int startAmount) 
        { 
            this.gasolineAmount = startAmount;
        }

        public void Drive()
        {
            const string MsgDriving = "Car is driving";
            const string MsgNotDriving = "Car has not gasoline";

            Console.WriteLine(this.gasolineAmount > 0 ? MsgDriving : MsgNotDriving);
        }

        public bool Refuel(int gasolineAmount)
        {
            this.gasolineAmount += gasolineAmount;
            return true;
        }
    }
}
