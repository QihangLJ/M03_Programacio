/* Qihang Li Jiang
* M03_UF5 Programacio
* 18/03/2024
* Exercici 21. Calcula de mitjana d’un array de nombres enters mitjançant un delegate personalitzat i mostrar el resultat per consola.
*/

using System.Text.RegularExpressions;

namespace MyProgram
{
    public class MyCode
    {
        public delegate int MathDelegate(int[] num);

        public static void Main()
        {
            int[] numArray = [1,2,3,4,5,6,7,8,9];

            MathDelegate CalculateAverage = array => {
                int result = 0;

                foreach (int value in array)
                {
                    result += value;
                }
        
                return result/array.Length;
            };

            Console.WriteLine(CalculateAverage(numArray));
        }
    }
}
