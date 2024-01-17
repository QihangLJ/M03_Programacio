/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 17/01/2024
 * Exercici 28. Implementa un mètode que, donat un nombre natural, compti de manera recursiva el nombre de dígits que té aquest.
 */

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const string AskNum = "Enter a natural number:";
            const string MsgResult = "The number {0} have {1} digits.";

            Console.WriteLine(AskNum);
            int natural = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgResult, natural,DigitCounter(Math.Abs(natural)));
        }
        public static int DigitCounter(int num)
        {
            if (num <= 10)
            {
                return 1;
            }

            return DigitCounter(num / 10) + 1;
        }
    }
}
