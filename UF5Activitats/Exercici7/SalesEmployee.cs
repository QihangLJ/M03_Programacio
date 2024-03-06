namespace MyProgram
{
    public class SalesEmployee : Employee
    {
        const float DefaultComission = 0;
        public float Comission { get; set; }

        public SalesEmployee(string code, string firstName, string lastName, DateTime birthDate, DateTime hireDate, float monthSalary, int payments, float comission) : base(code, firstName, lastName, birthDate, hireDate, monthSalary, payments)
        {
            Comission = comission;
        }

        public SalesEmployee() : base()
        {
            Comission = DefaultComission;
        }

        public override string ToString() =>
           "-----------------------------------------------------------------------------------------------------\r\n                           " +
           "                       E M P L O Y E E\r\n" +
           "-----------------------------------------------------------------------------------------------------\r\n" +
           $">Code: {Code}\r\n" +
           $">Firstname: {FirstName}\r\n" +
           $">Last name: {LastName}\r\n" +
           $">Full name: {GetFullName()}\r\n" +
           $">Reverse name: {GetReverseFullName()}\r\n" +
           $">Age: {GetAge()}\r\n" +
           $">Seniority: {GetSeniority()}\r\n" +
           $">Annual salary: {GetAnnualSalary()}\r\n" + 
           $">Commission: {Comission}";
    }
}