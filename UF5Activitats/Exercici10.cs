/* Qihang Li Jiang
* M03_UF5 Programacio
* 06/03/2024
* Exercici 10. Donat un array de strings, converteix-ho en una llista i mostra els elements de la llista.
*/

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            string[] arrayString = ["Hola", "Que tal", "Buenos dias", "Adios", "Hasta luego", "Nos vemos"];
            
            List<string> list = new List<string>(arrayString);
            
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
