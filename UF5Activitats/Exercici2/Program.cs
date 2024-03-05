/* Qihang Li Jiang
* M03_UF5 Programacio
* 05/03/2024
* Exercici 2. Modifica la solució “Visit” per a afegir un atribut de tipus data-hora. Modifica la controladora de manera que es mostrin 5 visites (formateja la sortida simulant una aplicació veterinària). 
*/

using MyObject;

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            owner firstOwner = new owner(12345678, "Pepito", "Perez", 666666666);
            owner secondOwner = new owner(87654321, "Juan", "Miguel", 661231421);
            owner thirdOwner = new owner(67445376, "Pedro", "Garcia", 643123542);

            patient firstPet = new patient("Toby", "Golden Retriever", 5, true);
            patient secondPet = new patient("Luna", "Bulldog", 3, false);
            patient thirdPet = new patient("Max", "Poodle", 7, true);

            DateTime visitDateOne = new DateTime (2024, 12, 31);
            DateTime visitDateTwo = new DateTime(2024, 7, 14);


            List<visit> visitList = new List<visit>();
            visitList.Add(new visit(firstOwner, firstPet, visitDateOne, "Check"));
            visitList.Add(new visit(secondOwner, secondPet, visitDateOne, "Check"));
            visitList.Add(new visit(thirdOwner, thirdPet, visitDateTwo, "Check"));

            foreach (visit visit in visitList)
            {
                visit.GetVisitInfo();
                Console.WriteLine();
            }
        }
    }
}