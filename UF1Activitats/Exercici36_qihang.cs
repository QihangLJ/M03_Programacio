/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 12/11/2023
* Exercici 36: Implementa un programa que generi una matriu de 4x4 i mostri la diagonal principal (pots inicialitzar-la amb els valors enters que consideris).
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
            const string msgShowDiagonal = "La diagonal d'aquesta matriu té els següents valors: ";
            int[,] matInt = { {1, 2, 3, 4}, {2, 4, 6, 8}, {1, 3, 5, 7}, {4, 3, 2, 1} };

            Console.Write(msgShowDiagonal);
            for (int i = 0; i < matInt.GetLength(0); i++)
            {
                for (int j = 0; j < matInt.GetLength(1); j++)
                {
                    if ( j == i )
                    {
                        Console.Write(matInt[i, j] + " ");
                    }
                }
            }
        }
    }
}
