using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyObject;

namespace MyObject
{
    public class car : AWheeledV
    {
        private int power;
        private int doors;

        public int Power { get => power; set => power = value; }
        public int Doors { get => doors; set => doors = value; }

        public car(string name, string color, bool wheeled, int wheelsNum, bool motorized, int power, int doors) :
            base(name, color, wheeled, wheelsNum, motorized)
        {
            Name = name;
            Color = color;
            Wheeled = wheeled;
            WheelsNum = wheelsNum;
            Motorized = motorized;
            Power = power;
            Doors = doors;
        }
    }
}
