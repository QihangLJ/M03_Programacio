using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class Crew
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }

        public Crew(string name, int age, string role)
        {
            Name = name;
            Age = age;
            Role = role;
        }
    }
}
