using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class NavigationSystem
    {
        public string Name { get; set; }
        public string Version { get; set; }

        public int Inclination { get; set; }

        public NavigationSystem(string name, string version, int inclination)
        {
            Name = name;
            Version = version;
            Inclination = inclination;
        }
        
        public int CalculateInclination()
        {
            Random random = new Random();
            Inclination = random.Next(1, 46);
            return Inclination;
        }
    }
}
