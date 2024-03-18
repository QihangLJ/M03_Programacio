/* Qihang Li Jiang
 * M03_UF5 Programacio
 * 13/03/2024
 * Exercici 24. Donat valor enter introduït per teclat, retorna per consola mitjançant un delegate personalitzat si el valor introduït és natural o no.
 */

namespace MyProgram
{
    public class MyCode
    {
        public delegate string NaturalNumberDelegate(int num);

        public static void Main()
        {
            const string AskNum = "Introdueix un número enter: ";
            const string Error = "El valor introduït no és un número enter.";

            NaturalNumberDelegate CheckNatural = num =>
            {
                const string MsgNatural = "El número introduït és natural.";
                const string MsgNotNatural = "El número introduït no és natural.";

                return num > 0 ? MsgNatural : MsgNotNatural;
            };

            Console.WriteLine(AskNum);

            try {                 
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(CheckNatural(num));
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}
