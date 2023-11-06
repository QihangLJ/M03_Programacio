/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 05/11/2023
* Exercici 28: Fent servir la interpolació i l’operador ternari, implementa un programa que indiqui pels 20 primers nombres (del 1 al 20 inclosos) si és parell o senar (només ha d’indicar per a cada valor “És parell”/”És senar)”.
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
            const int MAX = 20, OFFSET = 1;

            int[] arrayNum = new int[MAX];

            for (int i = 0; i < arrayNum.Length; i++) 
            {
                arrayNum[i] = i + OFFSET;
            }

            for (int i = 0;i < arrayNum.Length; i++)
            {
                Console.WriteLine(arrayNum[i] % 2 == 0 ? $"{i+OFFSET} és parell" : $"{i + OFFSET} és senar");
            }
        }
    }
}