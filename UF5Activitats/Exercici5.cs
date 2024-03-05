/* Qihang Li Jiang
* M03_UF5 Programacio
* 05/03/2024
* Exercici 5. Implementa un mètode que retorni el dia de la setmana de la data de sistema (data actual).
*/

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            DateTime date = DateTime.Now;

            Console.WriteLine(GetDayOfWeek(date));
        }

        public static string GetDayOfWeek(DateTime actualDate)
        {
            return actualDate.DayOfWeek.ToString();
        }
    }
}
