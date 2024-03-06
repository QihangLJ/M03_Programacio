/* Qihang Li Jiang
* M03_UF5 Programacio
* 06/03/2024
* Exercici 11. Crea un diccionari que emmagatzemi informació sobre empleats (nom i salari) i mostri la informació.
*/

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            Dictionary<int, Empleat> empleats = new Dictionary<int, Empleat>();
            empleats.Add(1, new Empleat("Pepe", 1000));
            empleats.Add(2, new Empleat("Pablo", 2000));
            empleats.Add(3, new Empleat("Maria", 3000));
            empleats.Add(4, new Empleat("Ana", 4000));
            empleats.Add(5, new Empleat("Luis", 5000));

            foreach (var empleat in empleats)
            {
                Console.WriteLine(empleat.ToString());
            }
        }
    }

    public class Empleat
    {
        public string Nom { get; set; }
        public double Salari { get; set; }

        public Empleat(string nom, double salari)
        {
            Nom = nom;
            Salari = salari;
        }

        public override string ToString()
        {
            return "Nom: " + Nom + " Salari: " + Salari;
        }
    }
}
