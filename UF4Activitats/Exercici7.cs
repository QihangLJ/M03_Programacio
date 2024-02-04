/* Qihang Li Jiang
 * M03_UF4 Programacio
 * 29/01/2024
 * Exercici 7. Implementa les classes necessàries per a definir les característiques i comportaments dels següents animals: wolf, turtle, iguana.
 */


using System.Xml.Linq;

namespace MyNamespace
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age) {
            Name = name;
            Age = age;
        }
    }
    public class Wolf : Animal 
    {
        private string FurColor { get; set; }

        public Wolf (string name, int age, string furColor) : base (name, age)
        {
            Name = name;
            Age = age;
            FurColor = furColor;
        }
    }

    public class Turtle : Animal
    {
        public bool IsAquatic { get; set; }

        public Turtle(string name, int age, bool isAquatic) : base(name, age)
        {
            Name = name;
            Age = age;
            IsAquatic = isAquatic;
        }

    }

    public class Iguana : Animal
    {
        public string ScaleColor { get; set; }

        public Iguana(string name, int age, string scaleColor) : base(name, age)
        {
            Name = name;
            Age = age;
            ScaleColor = scaleColor;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Turtle tortuga = new Turtle("tortuga", 12, true);
            Console.WriteLine($"{tortuga.Name} tiene {tortuga.Age} años.");
            Console.WriteLine(tortuga.IsAquatic ? "es acuatico" : "no es acuatico");
        }
    }
}
