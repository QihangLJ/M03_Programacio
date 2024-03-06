using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class Rocket
    {
        public string Manufacture { get; set; }
        public bool Active { get; set; }
        public int ActivationCode { get; set; }
        public int Fuel { get; set; }

        public Rocket(string manufacture, bool active, int activationCode, int fuel)
        {
            Manufacture = manufacture;
            Active = active;
            ActivationCode = activationCode;
            Fuel = fuel;
        }

        public void StartMotor(int activationCode)
        {
            if (activationCode == ActivationCode)
            {
                if (Fuel > 0)
                {
                    Active = true;
                    Console.WriteLine("Motor started");
                }
                else
                {
                    Console.WriteLine("No fuel");
                }
            }
            else
            {
                throw new Exception("Security code is incorrect");
            }
        }

        public void StopMotor()
        {
            Active = false;
            Console.WriteLine("Motor stopped");
        }
    }
}
