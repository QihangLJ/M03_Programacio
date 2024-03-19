/* Qihang Li Jiang
 * M03_UF5 Programacio
 * 19/03/2024
 * Exercici 31. Implementa mitjançant LINQ un programa que mostri els dies de la setmana (els seus noms).
 */

namespace MyPrograma
{
    public class MyProgram
    {
        public static void Main(string[] args)
        {
            int[] daysNumber = { 0, 1, 2, 3, 4, 5, 6 };
            DateTime date = new DateTime();

            var days = from day in daysNumber
                       select date.AddDays(day).DayOfWeek;

            foreach (var day in days)
            {
                Console.WriteLine(day);
            }
        }
    }
}
