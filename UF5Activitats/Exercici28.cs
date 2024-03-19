/* Qihang Li Jiang
 * M03_UF5 Programacio
 * 19/03/2024
 * Exercici 28. Implementa mitjançant LINQ un programa que trobi en una llista els nombres majors de 20 i els retorni junt amb els seus quadrats.
 */

namespace MyPrograma
{
    public class MyProgram
    {
        public static void Main(string[] args)
        {
            int[] numbers = [14, 22, 33, 24, 5, 16, 7, 21, 19, 13];

            var queryLinq = from number in numbers
                            where number > 20
                            select new { number, square = number * number };

            foreach (var number in queryLinq)
            {
                Console.WriteLine(number);
            }
        }
    }
}
