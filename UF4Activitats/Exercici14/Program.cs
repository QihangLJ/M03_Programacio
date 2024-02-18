/* Qihang Li Jiang
 * M03_UF4 Programacio
 * 17/02/2024
 * Exercici 13.Implementa l’encadenament de constructors de la classe següent:
    public class Furniture {
    private float weight;
    private double price;
    private boolean set;
    private String name, material, colour;
    }
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