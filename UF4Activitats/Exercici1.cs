/* Qihang Li Jiang
 * M03_UF4 Programacio
 * 29/01/2024
 * Exercici 1. Crea un projecte nou i implementa la definició de la classe Persona, així com la seva instanciació.
 */


namespace MyNamespace
{
    public class Persona
    {
        private string name;
        private string surname;
        private int age;
        private int birthYear;
        private string country;

        public void SetName(string _name) { this.name = _name; }
        public string GetName() { return name; }

        public void SetSurname(string _surname) { this.name = _surname; }
        public string GetSurname() { return surname; }

        public void SetAge(int _age) {  this.age = _age; }
        public int GetAge() { return age; }

        public void SetBirthYear(string _country) {  this.country = _country; }
        public int GetBirthYear() { return birthYear; }

        public void SetCountry(string _country) {  this.country = _country; }
        public string GetCountry() { return country; }

        public Persona(string name, string surname, int age, int birthYear, string country) 
        {
            SetName(name);
            Console.WriteLine(GetName());

            SetSurname(surname);
            Console.WriteLine(GetSurname());

            SetAge(age);
            Console.WriteLine(GetAge());

            SetBirthYear(surname);
            Console.WriteLine(GetBirthYear());

            SetCountry(surname);
            Console.WriteLine(GetCountry());
        }

    }
}
