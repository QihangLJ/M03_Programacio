/* Qihang Li Jiang
 * M03_UF4 Programacio
 * 06/02/2024
 * Exercici 8. Modifica les classes dels exercicis anteriors (6 i 7) de manera que les classes puguin “heretar” de diverses superclasses.
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