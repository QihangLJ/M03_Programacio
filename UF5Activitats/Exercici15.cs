/* Qihang Li Jiang
* M03_UF5 Programacio
* 11/03/2024
* Exercici 15. Implementa un programa que demani l’adreça de correu a l’usuari i es validi que aquest té el format correcte.
*/

using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            const string email = "qihang@itb.cat";
            bool isValid = CheckEmail(email);
            Console.WriteLine(isValid);

            const string email2 = "qihangitb.cat";
            bool isValid2 = CheckEmail(email2);
            Console.WriteLine(isValid2);
        }

        public static bool CheckEmail(string email)
        {
            string pattern = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

    }
}
