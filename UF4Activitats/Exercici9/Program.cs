/* Qihang Li Jiang
 * M03_UF4 Programacio
 * 06/02/2024
 * Exercici 9. Implementa un programa que permeti introduir i mostrar les següents dades dels objectes llibre, revista, diari:
 */

using MyObject;

namespace MyProgram
{
    public class Program
    {
        public static void Main()
        {
            Diary myDiary = new Diary("My Diary", "Myself", "2024", 1, 365, "Me", "Life");
            Console.WriteLine(myDiary.GetFullInfo());
            Console.WriteLine(myDiary.TheAuthor());
        }
    }
}
