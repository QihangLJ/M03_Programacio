/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 20/11/2023
* Exercici 11: Implementa un programa que retorni si un nombre introduït per teclat és palíndrom o no.
* 
*/

using System;
using System.Numerics;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgEnterNum = "Introduce un numero entero: ";
            const string msgIsPalindrome = "És palínddrom.";
            const string msgIsNotPalindrome = "No és palínddrom.";

            string stringNum;
            bool itsPalindrome = true;

            Console.WriteLine(msgEnterNum);
            stringNum = Console.ReadLine();

            for (int i = 0; i < stringNum.Length / 2; i++)
            {
                if (stringNum[i] != stringNum[stringNum.Length - 1 - i])
                    itsPalindrome = false;
            }

            Console.WriteLine(itsPalindrome ? msgIsPalindrome : msgIsNotPalindrome);
        }
    }
}
}
