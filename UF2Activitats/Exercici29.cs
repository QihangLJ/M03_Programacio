/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 17/01/2024
 * Exercici 29.Implementa un mètode que, donat un text introduït per teclat, compti de manera recursiva quantes vegades es troba en el text la lletra també introduïda per teclat. El text SEMPRE ha de finalitzar amb ‘.’
 */

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const string AskNum = "Enter a string and a character:";
            const string MsgResult = "Result: {0}";

            Console.WriteLine(AskNum);
            string text = Console.ReadLine()!;
            char character = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(MsgResult, ContarLetraEnTexto(text, character));
        }

        static int ContarLetraEnTexto(string text, char character, int iteration = 0)
        {
            if (text[iteration] == '.')
            {
                return 0;
            }

            if (text[iteration] == character)
            {
                return ContarLetraEnTexto(text, character, iteration + 1) + 1;
            }
            return ContarLetraEnTexto(text, character, iteration + 1);
        }
    }
}
