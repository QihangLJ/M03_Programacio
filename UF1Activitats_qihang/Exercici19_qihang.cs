/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 30/10/2023
* Exercici 19: Implementa un programa que reculli les següents dades per 10 persones:
*   - edat (enter)
*   - sexe (H/D, caràcter)
*   - salari (decimal)
*   - becari (cert/fals, booleà)
* Un cop recollits tots els valors, cal mostrar-los per pantalla en forma de taula.
* 
*/

using System;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgAge = "Introdueix l'edat: ";
            const string msgSex = "Introdueix el sexe: ";
            const string msgSalary = "Introdueix el salari: ";
            const string msgScholarship = "És becari? ";
            const int PERSON = 3, OFFSET = 1;

            int[] age = new int [PERSON], numPerson = new int[PERSON];
            char[] sex = new char[PERSON];
            decimal[] salary = new decimal[PERSON];
            bool[] scholarship = new bool[PERSON]; 
            string scholarshipAnswer;

            for (int i = 0; i < PERSON; i++)
            {
                numPerson[i] = i + OFFSET;

                Console.WriteLine(msgAge);
                age[i] = Convert.ToInt32(Console.ReadLine());
                     
                Console.WriteLine(msgSex);
                sex[i] = Convert.ToChar(Console.ReadLine());
                                        
                Console.WriteLine(msgSalary);
                salary[i] = Convert.ToDecimal(Console.ReadLine());
                    
                   
                Console.WriteLine(msgScholarship);
                scholarshipAnswer = Console.ReadLine();
                scholarship[i] = (scholarshipAnswer == "Si" || scholarshipAnswer == "SI" || scholarshipAnswer == "si") ? true : false;
            }
            for (int i = 0; i < PERSON; i++)
            {
                Console.Write("Persona: " + numPerson[i] + " " + age[i] + " " + sex[i] + " " + salary[i] + " " + (scholarship[i] ? "Si" : "No"));
                Console.WriteLine();
            }
        }
    }
}