/* Qihang Li Jiang
* M03_UF4 Programacio
* 17/02/2024
* Exercici 15. Posa un exemple de polimorfisme en temps de compilació, utilitzant la classe Furniture (exercici 12).
*/


using MyObject;

namespace MyProgram
{
    public class Code
    {
        public static void Main()
        {
            Furniture furniture = new Furniture(10.0f, 100.0, true, "Taula", "Fusta", "Marro");
            furniture.GetInfo(furniture.Name);
            furniture.GetInfo(furniture.Name, furniture.Material);
            furniture.GetInfo(furniture.Name, furniture.Material, furniture.Colour);

        }
    }
}