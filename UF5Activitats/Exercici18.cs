/* Qihang Li Jiang
* M03_UF5 Programacio
* 13/03/2024
* Exercici 18. Donada una llista, ordenar-la amb un delegate personalitzat i mostrar el resultat per consola.
*/

using System.Text.RegularExpressions;

namespace MyProgram
{
    public class MyCode
    {
        public delegate List<int> SortDelegate(List<int> intList);

        public static void Main()
        {
            int[] array = [ 3, 4, 2, 9, 6, 4, 6, 3, 0 ];

            List<int> list = new List<int>(array);

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            SortDelegate myAction = delegate (List<int> list)
            {
                list.Sort();
                return list;
            };

            List<int> sortedList = myAction(list);

            foreach (int i in sortedList)
            {
                Console.Write(i + " ");
            }
        }
    }
}
