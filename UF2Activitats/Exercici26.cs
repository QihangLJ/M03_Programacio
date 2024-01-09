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
            const string MsgResult = "La suma dels dígits de {0} és: {1}";

            Console.WriteLine(AskNum);
            int natural = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgResult, natural, SumaDigits(natural));
        }
        static int SumaDigits(int num)
        {
            if (num < 10)
            {
                return num;
            }

            return num % 10 + SumaDigits(num / 10);
        }
    }
}
