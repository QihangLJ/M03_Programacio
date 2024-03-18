/* Qihang Li Jiang
* M03_UF5 Programacio
* 13/03/2024
* Exercici 20. Calcula l’arrel quadrada d’un nombre mitjançant un delegate personalitzat i mostrar el resultat per consola.
*/

using System.Text.RegularExpressions;

namespace MyProgram
{
    public class MyCode
    {
        public delegate double MathDelegate(double num);

        public static void Main()
        {
            int bas = 2;

            MathDelegate SquareRoot = Math.Sqrt;

            Console.WriteLine(SquareRoot(bas));
        }
    }
}
