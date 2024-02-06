using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
    public abstract class AWheeledV : AVehicle
    {
        protected int wheelsNum;
        protected bool motorized;

        public int WheelsNum { get => wheelsNum; set => wheelsNum = value; }
        public bool Motorized { get => motorized; set => motorized = value; }

        public AWheeledV(string name, string color, bool wheeled, int wheelsNum, bool motorized) : base(name, color, wheeled)
        {
            Name = name;
            Color = color;
            Wheeled = wheeled;
            WheelsNum = wheelsNum;
            Motorized = motorized;
        }
        
    }
}
