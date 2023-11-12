/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 12/11/2023
* Exercici 3: Implementa un programa que, donada la següent llista, retorni l’element més gran i el més petit.
* llista = [5,10,15,2,25,30,35,40]
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
            const string msgMaxResult = $"L'element més gran és:";
            const string msgMinResult = $"L'element més petit és:";

            int[] arrayList = { 5, 10, 15, 2, 25, 30, 35, 40 };
            int minValue = 0, maxValue = 0;

            for (int i = 0; i < arrayList.Length; i++)
            {
                if (i == 0)
                {
                    minValue = arrayList[i];
                    maxValue = arrayList[i];
                }
                if (minValue > arrayList[i])
                {
                    minValue = arrayList[i];
                }
                if (maxValue < arrayList[i])
                {
                    maxValue = arrayList[i];
                }
            }
            Console.WriteLine($"{msgMaxResult} {maxValue}");
            Console.WriteLine($"{msgMinResult} {minValue}");
        }
    }
}
