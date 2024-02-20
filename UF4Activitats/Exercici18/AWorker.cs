using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObject
{
    public abstract class AWorker
    {
        private string name;
        private double salaryRate;
        
        public string Name { get; set; }
        public double SalaryRate { get; set; }

        public AWorker(string name, double salaryRate)
        {
            Name = name;
            SalaryRate = salaryRate;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetSalaryRate()
        {
            return SalaryRate;
        }

        public abstract double ComputePay();

    }
}
