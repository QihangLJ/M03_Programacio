/* Qihang Li Jiang
 * M03_UF5 Programacio
 * 19/03/2024
 * Exercici 27. Implementa mitjançant LINQ un programa que retorni els valors positius d’una llista de 10 elements.
 */

namespace MyPrograma
{
    public class MyProgram
    {
        public static void Main(string[] args)
        {
            int[] numbers = { -2, 32, -42, 0, 12, 5, 6, -4, -8 , 0};

            var queryLinq = from number in numbers
                            where number > 0
                            select number;

            foreach (var number in queryLinq)
            {
                Console.Write(number + " ");
            }
        }
    }
}
