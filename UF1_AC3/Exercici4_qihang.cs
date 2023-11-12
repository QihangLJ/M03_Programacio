/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 12/11/2023
* Exercici 4: Implementa un programa que generi un array, indicant la seva mida per teclat. L’usuari haurà d’indicar un número per teclat, de manera que els valors de cada posició seran nombres múltiples consecutius del valor introduït per teclat. Per exemple, si es defineix un array de grandària 5 i s’indica un 3 com a valor, l’array contindrà els valors 3, 6, 9, 12, 15.
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
            const string msgArrayLength = "Introdueix la mida de l'array:";
            const string msgUserValue = "Introdueix un valor:";
            const int OFFSET = 1;
            int arrayLength, UserValue;

            Console.WriteLine(msgArrayLength);
            arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] arrayMultiple = new int[arrayLength];

            Console.WriteLine(msgUserValue);
            UserValue = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arrayLength; i++)
            {
                if (i == 0)
                {
                    arrayMultiple[i] = UserValue;
                }
                else
                {
                    arrayMultiple[i] = arrayMultiple[i - OFFSET] + UserValue;
                }
            }

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(arrayMultiple[i] + " ");
            }
        }
    }
}
