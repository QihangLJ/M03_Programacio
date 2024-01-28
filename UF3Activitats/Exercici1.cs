/*
 * Author: Qihang Li Jiang
 * M03. Programació UF3
 * v1. 28/01/2024
 * Exercici 1. CProva els diferents exemples de manipulació de fitxers que trobaràs al repositori. Afegeix:
        - control d’excepcions 
        - que l’usuari pugui introduir el nom del fitxer (si no introdueix un .txt l’ha de tornar a introduir, sense límit d’intents)
        - en el cas d’escriptura, que insereixi i afegeixi un text indicat per l’usuari
*/

using System.Timers;

namespace Program
{
    public class A
    {
        public static void Main()
        {
            FileHandling("file.txt");
        }

        public static void FileHandling(string file)
        {
            try
            {
                string path = Path.GetFullPath(@"..\..\..\files\" + file);
                using (StreamReader sr = File.OpenText(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"El archivo {file} no se encontró.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error durante la lectura del archivo: {e.Message}");
            }
        }
    }

    public class B
    {
        public static void Main()
        {
            const string AskName = "Introdueix el nom de l´arxiu:";
            const string Txt = ".txt";
            string fileName;
            do
            {
                Console.Write(AskName);
                fileName = Console.ReadLine();
            } while (!fileName.EndsWith(Txt));

            FileHandling(fileName);
        }

        public static void FileHandling(string file)
        {
            string path = Path.GetFullPath(@"..\..\..\files\" + file);
            using StreamReader sr = File.OpenText(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }

    public class C
    {
        public static void Main()
        {
            const string AskContent = "Introdueix el contingut que vol escriure:";
            string content;

            Console.WriteLine(AskContent);
            content = Console.ReadLine();
            FileHandling("file.txt", content);
        }

        public static void FileHandling(string file,string content)
        {
            string path = Path.GetFullPath(@"..\..\..\files\" + file);
            if (!File.Exists(path))
            {
                using StreamWriter sw = File.CreateText(path);

                File.AppendAllText(path, content);
            }
        }
    }
}
