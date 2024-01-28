/*
 * Author: Qihang Li Jiang
 * M03. Programació UF3
 * v1. 28/01/2024
 * Exercici 3. Implementa un programa que demani el nom d’un fitxer de text i que retorni per consola el nombre de línies que aquest conté.
 */

using System.Timers;

namespace Program
{
    public class Code
    {
        public static void Main()
        {
            const string AskName = "Introdueix el nom del document:";
            const string MsgLines = "Te {0} linies";
            string fileName;

            Console.WriteLine(AskName);
            fileName = Console.ReadLine();
            
            Console.WriteLine(MsgLines, LinesCounter(fileName));
        }
        public static int LinesCounter(string file)
        {
            int count = 0;

            string path = Path.GetFullPath(file);

            using StreamReader sr = File.OpenText(path);

            while (sr.ReadLine() != null)
            {
                count++;
            }
            return count;
        }

    }
}
