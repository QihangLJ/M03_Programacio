/* Qihang Li Jiang
 * M03_UF4 Programacio
 * 29/01/2024
 * Exercici 4.Implementa la classe “Cat” que defineixi el següent: 
 */

namespace MyNamespace
{
    public class Cat
    {
        private string name;
        private int age;
        private string breed;
        private string favFood;
        
        public string Name { get { return name; } set {  name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Breed { get { return breed; } set { breed = value; } }
        public string FavFood { get {  return favFood; } set {  favFood = value; } }

        public Cat (string name, int age, string breed, string favFood)
        {
            Name = name;
            Age = age;
            Breed = breed;
            FavFood = favFood;
        }
    }

    public class Program
    {
        public static void Main() 
        {
            Cat firstCat = new Cat("Pep", 12, "Siamese", "Pollo");

            Console.WriteLine($"{firstCat.Name}, {firstCat.Age}, {firstCat.Breed}, {firstCat.FavFood}");
        }
    }
}
