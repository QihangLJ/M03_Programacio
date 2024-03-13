/* Qihang Li Jiang
* M03_UF5 Programacio
* 13/03/2024
* Exercici 19. Calcula la potència de dos nombres mitjançant un delegate personalitzat i mostrar el resultat per consola.
*/

using System.Text.RegularExpressions;

namespace MyProgram
{
    public class MyCode
    {
        public delegate float MathDelegate(int numOne, int numTwo);

        public static void Main()
        {
            int bas = 2;
            int expo = -3;

            MathDelegate Pow = (bas, expo) => {
                float result = 1;
                bool negativeExp = expo < 0 ? true : false;

                for (int i = 0; i < Math.Abs(expo); i++)
                {
                    result = negativeExp ? (result / bas) : (result * bas);
                }

                return result;
            };

            Console.WriteLine(Pow(bas, expo));
        }
    }
}
