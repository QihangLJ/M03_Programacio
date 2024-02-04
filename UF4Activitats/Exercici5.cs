/* Qihang Li Jiang
 * M03_UF4 Programacio
 * 29/01/2024
 * Exercici 5. Implementa les superclasses (que creguis necessàries) per als objectes dels exercicis 2 i 3 i modifica les dues subclasses (si és necessari). 
 */

using System.Xml.Linq;

namespace MyNamespace
{
    public class Vehicle
    {
        private int wheels;
        private int weight;

        public int Wheels { get { return wheels; } set { wheels = value; } }
        public int Weight { get { return weight; } set { weight = value; } }

        public Vehicle(int wheels, int weigth)
        {
            Wheels = wheels;
            Weight = weigth;
        }
    }
    public class Bike : Vehicle 
    {
        private string color;
        private string brand;

        public string Color { get { return color; } set { color = value; } }
        public string Brand { get { return brand; } set { brand = value; } }


        public Bike(int wheels, int weigth, string color, string brand) : base (wheels, weigth)
        {
            Wheels = wheels;
            Weight = weigth;
            Color = color;
            Brand = brand;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Bike bici = new Bike(2, 14, "negro", "merida");
            Console.WriteLine($"Bici de la marca {bici.Brand} con {bici.Wheels} ruedas y de color {bici.Color}");
        }
    }
}
