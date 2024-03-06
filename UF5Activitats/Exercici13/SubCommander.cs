using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class SubCommander : Crew, IFlyable
    {
        public SubCommander (string name, int age, string role) : base(name, age, role)
        { }

    }
}
