/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 05/11/2023
* Exercici 26: Implementa un programa que demani a l’usuari que introdueixi un text i retorni la seva longitud.
* 
*/

using System;
namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgEnterText = "Introdueix un text: ";
            const string msgTextLength = "La seva longitud és de ";

            string text;

            Console.WriteLine(msgEnterText);
            text = Console.ReadLine();

            Console.WriteLine(msgTextLength + text.Length);

        }
    }
}