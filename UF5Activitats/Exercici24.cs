/* Qihang Li Jiang
 * M03_UF5 Programacio
 * 13/03/2024
 * Exercici 24. Donat valor enter introduït per teclat, retorna per consola mitjançant un delegate personalitzat si el valor introduït és natural o no.
 */

namespace MyProgram
{
    public class MyCode
    {
        public delegate bool MathDelegate(int num);

        public static void Main()
        {
            const string AskNum = "Introdueix un número enter: ";
            const string MsgNatural = "El número introduït és natural.";
            const string MsgNotNatural = "El número introduït no és natural.";

            MathDelegate isNatural = num =>
            {
                return num > 0;
            };

            Console.WriteLine(AskNum);
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(isNatural(num) ? MsgNatural : MsgNotNatural);

        }
    }
}
