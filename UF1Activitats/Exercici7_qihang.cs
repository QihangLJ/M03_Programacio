/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 17/10/2023
* Exercici 7: Implementa un programa on l’usuari escrigui un valor que representarà 
* el dia de la setmana (segons la seva posició)  de l'1 al 7. El programa mostrarà 
* el nom del dia corresponent: Dilluns, Dimarts, Dimecres, Dijous,...
* 
*/

using System;

namespace M03Programacio
{
    class EX4
    {
        static void Main()
        {
            const string EnterNumber = "Introdueix un nombre de l'1 al 7: ";
            int num;

            Console.WriteLine(EnterNumber);
            num = Convert.ToInt32(Console.ReadLine());

            string day = num switch
            {
                1 => "Dilluns", 
                2 => "Dimarts",
                3 => "Dimecres",
                4 => "Dijous",
                5 => "Divendres",
                6 => "Dissatbe",
                7 => "Diumenge",
                _ => "Nombre incorrecte",
            };
            Console.WriteLine(day);

        }
    }
}