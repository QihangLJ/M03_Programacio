/* Qihang Li Jiang
* M03_UF5 Programacio
* 13/03/2024
* Exercici 22.  Mostra per consola mitjançant un delegate personalitzat:
*   - Si el valor és parell: el producte del número per 2
*   - En cas contrari el següent missatge: “El número {x} és senar”
*/

using System.Text.RegularExpressions;

namespace MyProgram
{
    public class MyCode
    {
        public delegate string MathDelegate(int num);

        public static void Main()
        {
            int numOne = 1;
            int numTwo = 2;

            MathDelegate IsEven = num => {
                const string MsgEven = "El producte del número per 2";
                const string MsgOdd = "El número {0} és senar";

                string result;

                if (num % 2 == 0)
                {
                    result = MsgEven;
                } else
                {
                    result = string.Format(MsgOdd, num);
                }

                return result;
            };

            Console.WriteLine(IsEven(numOne));
            Console.WriteLine(IsEven(numTwo));

        }
    }
}
