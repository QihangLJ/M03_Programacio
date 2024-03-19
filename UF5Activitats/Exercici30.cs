/* Qihang Li Jiang
 * M03_UF5 Programacio
 * 19/03/2024
 * Exercici 30. Implementa mitjançant LINQ un programa per a mostrar els caràcters i la freqüència de cada caràcter en una cadena determinada.
 */

namespace MyPrograma
{
    public class MyProgram
    {
        public static void Main(string[] args)
        {
            string names = "HelloWorldHello";

            var queryLinq = from character in names
                            group character by character into charGroup
                            select new {Character = charGroup.Key , Freq = charGroup.Count()};

            foreach (var info in queryLinq)
            {
                Console.WriteLine(info);
            }
        }
    }
}
