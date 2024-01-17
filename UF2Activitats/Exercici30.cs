/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 17/01/2024
 * Exercici 30. Implementa un mètode que determini si un nombre natural és perfecte. Un nombre és perfecte si és igual a la suma dels seus divisors tret d’ell mateix (p.ex. n=6 és perfecte perquè n=1+2+3).
 */

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

            Console.WriteLine(MsgResult, PerfectNumbers(natural) == natural);
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
    }
}
