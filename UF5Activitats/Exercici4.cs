/* Qihang Li Jiang
* M03_UF5 Programacio
* 05/03/2024
* Exercici 4. Implementa un mètode que demani dues dates i aquest retorni si la segona data és posterior a la primera data. Nota: l’usuari ha d’introduir la data en format enter (dd, mm, yyyy).
*/

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            const string Msg = "Introdueix la data en format enter (dd, mm, yyyy): ";
            const string MsgPost = "La segona es posterior a la primera.";
            const string MsgNotPost = "La segona NO es posterior a la primera.";
            const string MsgSame = "Les dues dates son iguals.";

            Console.WriteLine(Msg);
            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(Msg);
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(firstDate == secondDate ? MsgSame : firstDate < secondDate ? MsgPost : MsgNotPost);
        }
    }
}
