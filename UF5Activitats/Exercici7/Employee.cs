using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyProgram
{
    public class Employee : IComparable<Employee>
    {
        const int DefaultPayment = 14;
        const float DefaultSalary = 1800;
        const string DefaultCode = "0000", DefaultFirstName = "", DefaultLastName = "";
        public string? Code { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public float MonthSalary { get; set; }
        public int Payments { get; set; }

        private static int EmployeeCount = 0;

        public Employee(string code, string firstName, string lastName, DateTime birthDate, DateTime hireDate, float monthSalary, int payments)
        {
            Code = code;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            HireDate = hireDate;
            MonthSalary = monthSalary;
            Payments = payments;
            EmployeeCount++;
        }

        public Employee() : this (DefaultCode, DefaultFirstName, DefaultLastName, DateTime.Now, DateTime.Now, DefaultSalary, DefaultPayment)
        { }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetReverseFullName()
        {
            return $"{LastName}, {FirstName}";
        }

        public int GetAge()
        {
            DateTime actualDate = DateTime.Now;
            int age = actualDate.Year - BirthDate.Year;
            if (actualDate.Month < BirthDate.Month || (actualDate.Month == BirthDate.Month && actualDate.Day < BirthDate.Day))
            {
                age--;
            }
            return age;
        }

        public int GetSeniority()
        {
            DateTime actualDate = DateTime.Now;
            TimeSpan antiquity = actualDate - HireDate;
            return antiquity.Days;
        }

        public float GetAnnualSalary()
        {
            return MonthSalary * Payments;
        }

        public override string ToString() =>
            "-----------------------------------------------------------------------------------------------------\r\n" +
            "                       E M P L O Y E E\r\n" +
            "-----------------------------------------------------------------------------------------------------\r\n" +
            $">Code: {Code}\r\n" +
            $">Firstname: {FirstName}\r\n" +
            $">Last name: {LastName}\r\n" +
            $">Full name: {GetFullName()}\r\n" +
            $">Reverse name: {GetReverseFullName()}\r\n" +
            $">Age: {GetAge()}\r\n" +
            $">Seniority: {GetSeniority()}\r\n" +
            $">Annual salary: {GetAnnualSalary()}\r\n";

        public int CompareTo(Employee other)
        {
            return -this.GetSeniority().CompareTo(other.GetSeniority());
        }
    }
}