/* Qihang Li Jiang
* M03_UF5 Programacio
* 11/03/2024
* Exercici 17. You're an avid bird watcher that keeps track of how many birds have visited your garden in the last seven days.
*/

using System.Text.RegularExpressions;
using Object;

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            int[] birdsPerDay = [ 2, 5, 0, 7, 4, 1 ];
            BirdCount birdCount = new BirdCount(birdsPerDay);

            // 1. Check what the counts were last week
            int[] lastWeek = BirdCount.LastWeek();
            foreach (int day in lastWeek)
            {
                Console.Write(day + " ");
            }
            Console.WriteLine();

            // 2. Check how many birds visited today
            Console.WriteLine(birdCount.Today());

            // 3. Increment today's count
            birdCount.IncrementTodaysCount();
            Console.WriteLine(birdCount.Today());

            // 4. Check if there was a day with no visiting birds
            Console.WriteLine(birdCount.HasDayWithoutBirds());

            // 5. Calculate the number of visiting birds for the first number of days
            Console.WriteLine(birdCount.CountForFirstDays(4));

            // 6. Calculate the number of busy days
            Console.WriteLine(birdCount.BusyDays());

        }
    }
}
