/* Qihang Li Jiang
 * M03_UF5 Programacio
 * 19/03/2024
 * Exercici 32. Implementa mitjançant LINQ un programa per a mostrar els nombres la freqüència d'un nombre en una llista i  la multiplicació dels nombres amb les seves freqüències.
 */

namespace MyPrograma
{
    public class MyProgram
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var queryNum = from num in numbers
                           group num by num into numGroup
                           select new { Number = numGroup.Key, Freq = numGroup.Count(), Multi = numGroup.Count() * numGroup.Key };

            foreach (var element in queryNum)
            {
                Console.WriteLine(element);
            }
        }
    }
}
