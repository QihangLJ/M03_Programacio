/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 09/01/2024
 * Exercici 25. Implementa un mètode que calculi de manera recursiva el nombre binari equivalent al valor natural que rep com a paràmetre.
 */

namespace QihangProgram
{
    public class QihangCode
    {
        static void Main()
        {
            const string AskNum = "Enter a natural number:";
            const string MsgResult = "The binary number of {0} is: {1}";

            Console.WriteLine(AskNum);
            int natural = Convert.ToInt32(Console.ReadLine());
            string binary = NaturalToBinary(natural);

            Console.WriteLine(MsgResult, natural, binary);
        }

        static string NaturalToBinary(int num)
        {
            if (num == 0)
            {
                return "";
            }
            return NaturalToBinary(num / 2) + (num % 2).ToString();
        }
    }
}
