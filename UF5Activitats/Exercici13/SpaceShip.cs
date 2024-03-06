using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class SpaceShip : IFlyable
    {
        public string Name { get; set; }
        public LandingSystem LandingSystem { get; set; }
        public BoardComputer BoardComputer { get; set; }
        public NavigationSystem NavigationSystem { get; set; }
        public Rocket Rocket { get; set; }
        public Astronaut Astronaut { get; set; }
        public SubCommander SubCommanders { get; set; }

        public void StartShip(int code)
        {
            Rocket.StartMotor(code);
            if (Rocket.Active)
            {
                Console.WriteLine("Ship started");
            }
        }

        public void StopShip()
        {
            Rocket.StopMotor();
            if (!Rocket.Active)
            {
                Console.WriteLine("Ship stopped");
            }
        }

        public int OrbitalInclinitation()
        {
            return NavigationSystem.Inclination * 2; //Accio
        }


       

    }
}
