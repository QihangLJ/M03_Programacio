namespace MyProgram
{
    public class Employee
    {
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public Employee(string? id, string? firstName, string? lastName, DateTime birthDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public int GetAge(DateTime actualDate)
        {
            int age = actualDate.Year - BirthDate.Year;
            if (actualDate.Month < BirthDate.Month || (actualDate.Month == BirthDate.Month && actualDate.Day < BirthDate.Day))
            {
                age--;
            }
            return age;
        }
    }
}