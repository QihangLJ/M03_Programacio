/* Qihang Li Jiang
 * M03_UF4 Programacio
 * 17/02/2024
 * Exercici 14.Posa un exemple de polimorfisme en temps d’execució, utilitzant la classe Furniture (exercici 12).
 */

using MyObject;

namespace MyProgram
{
    public class Code
    {
        public static void Main()
        {
            Table table = new Table(10.0f, 100.0, true, "Table", "Wood", "Brown");
            table.GetInfo();

            Furniture furniture = new Furniture(20.0f, 150.0, true, "Bed", "Wood", "Red");
            furniture.GetInfo();
        }
    }
}
