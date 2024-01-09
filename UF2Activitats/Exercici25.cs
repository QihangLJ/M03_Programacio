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
            const string MsgResult = "El nombre binari de {0} és: {1}";

            Console.WriteLine(AskNum);
            int natural = Convert.ToInt32(Console.ReadLine());
            string binary = NaturalToBinari(natural);

            Console.WriteLine(MsgResult, natural, binary);
        }

        static string NaturalToBinari(int num)
        {
            if (num == 0)
            {
                return "";
            }
            // Afegir el residu de la divisió (0 o 1) a la part binària calculada
            return NaturalToBinari(num / 2) + (num % 2).ToString();
        }
    }
}
