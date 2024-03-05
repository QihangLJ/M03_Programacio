/* Qihang Li Jiang
* M03_UF5 Programacio
* 05/03/2024
* Exercici 6. Implementa un mètode i afegeix-lo a la classe Employee que rebi la data de naixement i retorni la seva edat.
*/

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            const string MsgResult = "Empleat {0}, té {1} anys";

            Employee employee = new Employee("1", "Pedro", "Garcia", new DateTime(2004, 10, 4));
            DateTime actualDate = DateTime.Now;

            int employeeAge = employee.GetAge(actualDate);

            Console.WriteLine(MsgResult, employee.FirstName, employeeAge);
        }
    }
}