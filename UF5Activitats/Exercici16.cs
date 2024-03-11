/* Qihang Li Jiang
* M03_UF5 Programacio
* 11/03/2024
* Exercici 16. Modifica els overrides ToString de marena que facin servir objectes de la classe StringBuilder.
*/

using System.Text.RegularExpressions;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            Persona persona = new Persona("Qihang", "Li", 19);

            Console.WriteLine(persona.ToString());
        }

        public class Persona
        {
            public string Nom { get; set; }
            public string Cognom { get; set; }
            public int Edat { get; set; }

            public Persona(string nom, string cognom, int edat)
            {
                Nom = nom;
                Cognom = cognom;
                Edat = edat;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Nom: ");
                sb.Append(Nom);
                sb.Append(" Cognom: ");
                sb.Append(Cognom);
                sb.Append(" Edat: ");
                sb.Append(Edat);
                return sb.ToString();
            }   
        }
    }
}
