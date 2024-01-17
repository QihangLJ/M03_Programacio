/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 17/01/2024
 * Exercici 30. Implementa un mètode que, donat un text introduït per teclat, compti de manera recursiva quantes vegades es troba en el text la lletra també introduïda per teclat. El text SEMPRE ha de finalitzar amb ‘.’
 */

using System.Reflection.PortableExecutable;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const string AskNum = "Enter a natural number:";
            const string MsgResult = "Result: {0}";

            Console.WriteLine(AskNum);
            int natural = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgResult, CheckPerfectNumber(natural));
        }

        public static int PerfectNumbers(int num, int divisor = 1) 
        {
            if (num == divisor)
            {
                return 0;
            }

            if (num % divisor == 0)
            {
                return PerfectNumbers(num, divisor + 1) + divisor;
            }

            return PerfectNumbers(num, divisor + 1);
        }

        public static bool CheckPerfectNumber (int num)
        {
            return PerfectNumbers(num) == num;
        }
    }
}
