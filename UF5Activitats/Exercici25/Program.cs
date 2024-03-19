/* Qihang Li Jiang
 * M03_UF5 Programacio
 * 13/03/2024
 * Exercici 25. En aquest exercici cal implementar un conjunt parcial de rutines d'utilitat per ajudar un desenvolupador a netejar els noms d'identificadors.
 */

namespace MyProgram
{
    public class MyProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Identifier.Clean("my   Id"));
            Console.WriteLine(Identifier.Clean("my\0Id"));
            Console.WriteLine(Identifier.Clean("à-bç"));
            Console.WriteLine(Identifier.Clean("1😀m2😀3😀y"));
            Console.WriteLine(Identifier.Clean("MyΟβιεγτFinder"));
        }
    }
}