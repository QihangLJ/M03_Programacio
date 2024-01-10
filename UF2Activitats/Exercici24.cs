/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 09/01/2024
 * Exercici 24.Implementa un programa que demani dos valors per teclat i calculi el seu producte, seguint el mètode rus (multiplicació per duplicació). S’ha d’implementar:
 *     - mètode iteratiu
 *     - mètode recursiu
 */


namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const string AskNum = "Enter a natural number:";
            const string MsgResultIterative = "The result of {0} * {1} = {2}, with the Iterative Russian Multiplication.";
            const string MsgResultRecursive = "The result of {0} * {1} = {2}, with the Recursive Russian Multiplication.";


            Console.WriteLine(AskNum);
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(AskNum);
            int numTwo = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(MsgResultIterative, numOne, numTwo, RussianMultiplicationIterative(numOne, numTwo));
            Console.WriteLine(MsgResultRecursive, numOne, numTwo, RussianMultiplicationRecursive(numOne, numTwo));
        }
        public static int RussianMultiplicationIterative(int firstValue, int secondValue)
        {
            int result = 0;

            while (firstValue > 0)
            {
                if (firstValue % 2 != 0)
                {
                    result += secondValue;
                }
                firstValue /= 2;
                secondValue *= 2;
            }
            return result;
        }

        public static int RussianMultiplicationRecursive(int firstValue, int secondValue)
        {
            if (firstValue == 0)
            {
                return 0;
            }

            if (firstValue % 2 != 0)
            {
                return secondValue + RussianMultiplicationRecursive(firstValue / 2, secondValue * 2);
            }
            else
            {
                return RussianMultiplicationRecursive(firstValue / 2, secondValue * 2);
            }
        }
    }
}
