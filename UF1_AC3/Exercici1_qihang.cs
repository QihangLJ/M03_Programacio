/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 08/11/2023
* Exercici 1: Implementa un programa que demani a l’usuari quants valors vol introduir i el programa generi una llista, a partir de valors introduïts per teclat, retornant la suma de tots els elements d’aquesta.
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

            Console.WriteLine(msgEnterLength);
            int userIntput = Convert.ToInt32(Console.ReadLine());

            int[] arrayList = new int[userIntput];

            for (int i = 0; i < arrayList.Length; i++)
            {
                Console.WriteLine(msgEnterValue);
                arrayList[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arrayList.Length; i++)
            {
                Console.Write
                    ($"{arrayList[i]} ");
            }
        }
    }
}
