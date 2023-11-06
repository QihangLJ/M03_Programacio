/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 05/11/2023
* Exercici 29: Fent servir la interpolació, implementa un programa que mostri el contingut del jagged array seguint el format mostrat a continuació:
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
            int[][] jaggedArr = new int[4][];
            jaggedArr[0] = new int[] { 1, 2, 3, 4 };
            jaggedArr[1] = new int[] { 11, 34, 67 };
            jaggedArr[2] = new int[] { 89, 23 };
            jaggedArr[3] = new int[] { 0, 45, 78, 53, 99 };

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write("Fila: 0 ");
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write($"{jaggedArr[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}