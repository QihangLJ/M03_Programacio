/* Qihang Li Jiang
 * M03_UF4 Programacio
 * 06/02/2024
 * Exercici: Clinica Veterinaria
 */

using MyObject;

namespace MyProgram
{
    public class Program
    {
        public static void Main()
        {
            owner firstOwner = new owner();
            firstOwner.SetDni(12345678);
            firstOwner.SetName("Pepito");
            firstOwner.SetSurname("Perez");
            firstOwner.SetPhone(666666666);

            patient firstPet = new patient();
            firstPet.SetName("Toby");
            firstPet.SetBreed("Golden Retriever");
            firstPet.SetEdat(5);
            firstPet.SetVaccinated(true);

            visit firstVisit = new visit();
            firstVisit.SetPetOwner(firstOwner);
            firstVisit.SetPet(firstPet);
            firstVisit.SetDate("01/01/2024");
            firstVisit.SetVisitReason("Vomiting");

        }
    }
}