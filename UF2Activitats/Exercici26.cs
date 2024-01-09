/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 09/01/2024
 * Exercici 26. Implementa un mètode que, donat un nombre natural, calculi de manera recursiva la suma dels seus dígits.
 */

namespace QihangProgram
{
    public class QihangCode
    {
        static void Main()
        {
            const string AskNum = "Enter a natural number:";
            const string MsgResult = "The sum of the digits of {0} is: {1}";

            Console.WriteLine(AskNum);
            int natural = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgResult, natural, SumDigits(natural));
        }
        static int SumDigits(int num)
        {
            if (num < 10)
            {
                return num;
            }

            return num % 10 + SumDigits(num / 10);
        }
    }
}
