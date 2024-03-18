/* Qihang Li Jiang
 * M03_UF5 Programacio
 * 13/03/2024
 * Exercici 23. Implementa el càlcul de Fibonnaci per la posició d’un número en  concret mitjançant un delegate personalitzat i mostra el valor contingut en aquesta posició per consola.
 */

using System.Text.RegularExpressions;
using System.Timers;

namespace MyProgram
{
    public class MyCode
    {
        public delegate int DelegateFibonnaci(int num);
        public delegate string DelagateMessage(int num);

        public static void Main()
        {
            int num = 10;

            DelegateFibonnaci? CalculateFibonnaci = null;
            
            CalculateFibonnaci = num => {
                if (num == 0) return 0;
                if (num == 1) return 1;
                return CalculateFibonnaci(num - 1) + CalculateFibonnaci(num - 2);
            };

            DelagateMessage FibonnaciMessage = num =>
            {
                return $"El numero fibonnaci de la posicio {num} es: {CalculateFibonnaci(num)}";
            };

            Console.WriteLine(FibonnaciMessage(num));

        }
    }
}
