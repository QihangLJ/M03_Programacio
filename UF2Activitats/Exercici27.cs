/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 09/01/2024
 * Exercici 27. Implementa un mètode que determini de manera recursiva si un nombre natural és primer.
 */

namespace QihangProgram
{
    public class QihangCode
    {
        static void Main()
        {
            const string AskNum = "Enter a natural number:";
            const string MsgResultTrue = "Is a prime number";
            const string MsgResultFalse = "Is not a prime number";


            Console.WriteLine(AskNum);
            int natural = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsPrimeNumber(natural) ? MsgResultTrue : MsgResultFalse);
        }
        static bool IsPrimeNumber(int num, int divider = 2)
        {
            if (divider > num - 1)
            {
                return true;
            }

            if (num < 2)
            {
                return false;
            }

            if (num % divider == 0)
            {
                return false;
            }

            return IsPrimeNumber(num, divider + 1);
        }
    }
}
