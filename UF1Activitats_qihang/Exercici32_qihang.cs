/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 08/11/2023
* Exercici 32:  Implementa un programa que, generi una llista a partir de valors introduïts per teclat i retorni la suma de tots els elements d’aquesta.
*
*/

using System;
namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgEnterLength = "Introdueix la quantitat de valors que vols que hi hagi en la llista: ";
            const string msgEnterValue = "Introdueix un valor: ";
            const string msgSumValue = "La suma dels valors de la llista es:";

            Console.WriteLine(msgEnterLength);
            int userIntput = Convert.ToInt32(Console.ReadLine());

            int[] arrayList = new int[userIntput];
            int sumVar = 0;

            for (int i = 0; i < arrayList.Length; i++)
            {
                Console.WriteLine(msgEnterValue);
                arrayList[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arrayList.Length; i++)
            {
                Console.Write($"{arrayList[i]} ");
                sumVar += arrayList[i];
            }
            Console.WriteLine();
            Console.WriteLine($"{msgSumValue} {sumVar}");
        }
    }
}
