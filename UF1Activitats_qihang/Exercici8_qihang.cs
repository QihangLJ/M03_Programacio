/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 20/11/2023
* Exercici 8: Implementa un programa que demani per teclat un nombre natural i retorni si aquest és un nombre primer o no.
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
            const string msgShowDiagonal = "Introduce un numero entero: ";
            const string msgItsPrime = "es un numero Primo.";
            const string msgItsNotPrime = "NO es un numero primo.";

            int num;
            bool itsPrime = true;

            Console.WriteLine(msgShowDiagonal);
            num = Convert.ToInt32(Console.ReadLine());

            if (num <= 1)
                itsPrime = false;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    itsPrime = false;
            }

            if (itsPrime)
            {
                Console.WriteLine(num + " " + msgItsPrime);
            }
            else
            {
                Console.WriteLine(num + " " + msgItsNotPrime);
            }
        }
    }
}
