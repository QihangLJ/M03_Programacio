/* Qihang Li Jiang
 * M03_UF4 Programacio
 * 29/01/2024
 * Exercici 6. A partir de la següent imatge, implementa les classes necessàries per a representar-la, seguint la OOP:
 */

using MyObject;

namespace MyNamespace
{
    public class Program
    {
        public static void Main()
        {
            car seat = new car("Seat", "Red", true, 4, true, 100, 4);
            ship titanic = new ship("Titanic", "Black", false, 100, 100);

            Console.WriteLine("Car: " + seat.Name + " " + seat.Color + " " + seat.Wheeled + " " + seat.WheelsNum + " " + seat.Motorized + " " + seat.Power + " " + seat.Doors);
            Console.WriteLine("Ship: " + titanic.Name + " " + titanic.Color + " " + titanic.Wheeled + " " + titanic.SailLength + " " + titanic.MastilHeight);
        }
    }
}