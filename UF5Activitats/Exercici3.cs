/* Qihang Li Jiang
* M03_UF5 Programacio
* 05/03/2024
* Exercici 3. Implementa un mètode que demani una data i aquest retorni quants dies han passat des de la data indicada fins a la data actual. Nota: l’usuari ha d’introduir la data en format enter (dd, mm, yyyy).
*/

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            const string Msg = "Introdueix la data en format enter (dd, mm, yyyy): ";
            const string MsgPast = "Han passat {0} dies.";
            const string MsgFuture = "Falten {0} dies.";

            DateTime actualDate = DateTime.Now;

            Console.WriteLine(Msg);
            DateTime inputDate = DateTime.Parse(Console.ReadLine());

            int pastDays = (actualDate - inputDate).Days;
        
            if (pastDays > 0)
            {
                Console.WriteLine(MsgPast, pastDays);
            }
            else
            {
                Console.WriteLine(MsgFuture, -pastDays);
            }
        }
    }
}
