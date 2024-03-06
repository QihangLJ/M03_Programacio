/* Qihang Li Jiang
* M03_UF5 Programacio
* 05/03/2024
* Exercici 7. Defineix la classe SalesEmployee, que extén la classe Employee, i que té com a  atribut “comission (float). 
*/

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee("0001", "Pedro", "Apellido1", new DateTime(1983, 2, 27), new DateTime(2000, 12, 8), 1800, 14));
            employeeList.Add(new Employee("0002", "Maria", "Apellido2", new DateTime(1985, 12, 4), new DateTime(2003, 11, 29), 2000, 14));
            employeeList.Add(new Employee("0003", "Juan", "Apellido3", new DateTime(1992, 11, 17), new DateTime(2000, 5, 4), 1840, 14));
            employeeList.Add(new Employee("0004", "Carlos", "Apellido4", new DateTime(2001, 4, 30), new DateTime(2021, 3, 21), 1940, 12));
            employeeList.Add(new Employee("0005", "Miguel", "Apellido5", new DateTime(1995, 6, 13), new DateTime(2009, 8, 12), 2100, 12));

            List<SalesEmployee> salesEmployeeList = new List<SalesEmployee>();
            salesEmployeeList.Add(new SalesEmployee("0006", "Jan", "Apellido6", new DateTime(1983, 2, 27), new DateTime(2000, 12, 8), 1800, 14, 0.5f));
            salesEmployeeList.Add(new SalesEmployee("0007", "Mario", "Apellido7", new DateTime(1985, 12, 4), new DateTime(2003, 11, 29), 2000, 14, 0.1f));
            salesEmployeeList.Add(new SalesEmployee("0008", "Juanjo", "Apellido8", new DateTime(1992, 11, 17), new DateTime(2000, 5, 4), 1840, 14, 0.2f));
            salesEmployeeList.Add(new SalesEmployee("0009", "Marta", "Apellido9", new DateTime(2001, 4, 30), new DateTime(2021, 3, 21), 1940, 12, 0.3f));
            salesEmployeeList.Add(new SalesEmployee("0010", "Jordi", "Apellido10", new DateTime(1995, 6, 13), new DateTime(2009, 8, 12), 2100, 12, 0.4f));

            employeeList.Sort();

            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("\n\n\n");
            salesEmployeeList.Sort();

            foreach (SalesEmployee salesEmployee in salesEmployeeList)
            {
                Console.WriteLine(salesEmployee);
            }

        }
    }
}