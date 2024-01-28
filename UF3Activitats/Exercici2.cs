/*
 * Author: Qihang Li Jiang
 * M03. Programació UF3
 * v1. 28/01/2024
 * Exercici 2. Implementa un programa que mostri per consola només la primera línia del document de text introduït per teclat. Aquest contindrà el següent text (cal mantenir el format):
 */

using System.Timers;

namespace Program
{
    public class Code
    {
        public static void Main()
        {
            const string AskContent = "Introdueix el contingut que vol escriure:";
            string content;

            Console.WriteLine(AskContent);
            content = Console.ReadLine();
            FileHandlingWrite("file.txt", content);
            FileHandlingRead("file.txt");
        }

        public static void FileHandlingRead(string file)
        {
            string path = Path.GetFullPath(file);
            using StreamReader sr = File.OpenText(path);
            string line;
            if ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        public static void FileHandlingWrite(string file, string content)
        {
            string path = Path.GetFullPath(file);
            if (!File.Exists(path))
            {
                using StreamWriter sw = File.CreateText(path);

                File.WriteAllText(path, content);

            }
        }
    }
}
