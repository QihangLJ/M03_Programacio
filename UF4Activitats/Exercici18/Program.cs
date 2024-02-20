/* Qihang Li Jiang
* M03_UF4 Programacio
* 20/02/2024
* Exercici 18. Definiu la classe abstracta Worker, que té un mètode abstracte public double computePay(). Cada treballador té un nom i una tarifa. Definiu també les classes concretes FullTimeWorker i HourlyWorker. 
*/


using System;
using MyObject;

namespace Program
{
    public class Code
    {
        public static void Main()
        {
            FullTimeWorker fullEmployee = new FullTimeWorker("John", 10, 40);
            HourlyWorker hourlyEmployee = new HourlyWorker("Jane", 5, 40);

            Console.WriteLine("FullTime employee: " + fullEmployee.GetName() + " " + fullEmployee.ComputePay());
            Console.WriteLine("Hourly employee: " + hourlyEmployee.GetName() + " " + hourlyEmployee.ComputePay());
        }
    }
}