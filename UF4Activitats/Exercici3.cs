/* Qihang Li Jiang
 * M03_UF4 Programacio
 * 29/01/2024
 * Exercici 2. Implementa una classe que defineixi l’objecte Bike, així com la controladora que permeti instanciar diversos tipus de bicicletes.
 */

namespace MyNamespace
{
    public class Bike
    {
        private string brand;
        private string color;

        public void SetBrand(string brand) {  this.brand = brand; }
        public string GetBrand() { return brand; }

        public void SetColor(string color) { this.color = color; }
        public string GetColor() { return color; }

        public Bike(string brand, string color) 
        {
            SetBrand(brand);
            SetColor(color);
        }

    }

    public class Program
    {
        public static void Main() 
        { 
            Bike firstBike = new Bike("merida", "rojo");
            Console.WriteLine(firstBike.GetBrand() + " " + firstBike.GetColor());

            Bike secondBike = new Bike("specialized", "negro");
            Console.WriteLine(secondBike.GetBrand() + " " + secondBike.GetColor());
        }
    }
}
