/* Qihang Li Jiang
* M03_UF4 Programacio
* 19/02/2024
* Exercici 17. Car and Gasoline
*/


using System;

namespace Program
{
    public class Code
    {
        public static void Main()
        {
            const string MsgEnterGasoline = "Enter the gasoline amount: ";
            int gasolineAmount;
            Car myCar = new Car(0);

            //Comprobar que al iniciar el coche no tiene gasolina
            myCar.Drive();

            Console.Write(MsgEnterGasoline);
            gasolineAmount = Convert.ToInt32(Console.ReadLine());

            myCar.Refuel(gasolineAmount);
            myCar.Drive();
        }
    }
}