using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class AI : IFlyable
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public AI()
        { }
        public void ActivateAI()
        {
            Console.WriteLine("AI is controlling the ship");
        }

        public void DesactivateAI()
        {
            Console.WriteLine("AI is not controlling the ship");
        }
    }
}
