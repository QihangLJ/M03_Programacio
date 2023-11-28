/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 05/11/2023
* Exercici 27: Implementa un programa que demani a l’usuari que introdueixi un text i el retorni tot en majúscules, tot en minúscules i la primera lletra de cada paraula en majúscules (per separat).
* 
*/

using System;
using System.Globalization;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgEnterText = "Introdueix un text: ";

            string text;

            Console.WriteLine(msgEnterText);
            text = Console.ReadLine();

            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text));
        }
    }
}