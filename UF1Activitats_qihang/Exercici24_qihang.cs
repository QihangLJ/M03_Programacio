/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 05/11/2023
* Exercici 24:  Fent servir la interpolació, implementa un programa en el que es demani a l’usuari el seu nom, cognoms i edat i retorni un missatge informatiu,
* 
*/

using System;
namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgEnterName = "Introdueix el teu nom: ";
            const string msgEnterSurname = "Introdueix el teu cognom ";
            const string msgEnterAge = "Introdueix la teva edat: ";

            string name, surname;
            int age;

            Console.WriteLine(msgEnterName);
            name = Console.ReadLine();

            Console.WriteLine(msgEnterSurname);
            surname = Console.ReadLine();

            Console.WriteLine(msgEnterAge);
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{name} {surname} té {age} anys.");
        }
    }
}