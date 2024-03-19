/* Qihang Li Jiang
 * M03_UF5 Programacio
 * 19/03/2024
 * Exercici 26. Implementa mitjançant LINQ un programa que retorni els valors parells d’una llista de 10 elements.
 */ 

namespace MyPrograma
{
    public class MyProgram
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var queryLinq = from number in numbers
                            where number % 2 == 0
                            select number;

            foreach (var number in queryLinq)
            {
                Console.Write(number + " ");
            }
        }
    }
}
