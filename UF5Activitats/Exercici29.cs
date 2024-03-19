/* Qihang Li Jiang
 * M03_UF5 Programacio
 * 19/03/2024
 * Exercici 29. Implementa mitjançant LINQ un programa per mostrar el nombre i la freqüència d'un nombre en una llista.
 */

namespace MyPrograma
{
    public class MyProgram
    {
        public static void Main(string[] args)
        {
            string[] names = ["joan", "luis", "pedro", "joan", "joan", "luis", "carlos", "joan"];

            var queryLinq = from name in names
                            group name by name into nameGroup
                            select new { Name = nameGroup.Key , Freq = nameGroup.Count() };

            foreach (var name in queryLinq)
            {
                Console.WriteLine(name);
            }
        }
    }
}
