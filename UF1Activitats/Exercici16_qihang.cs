/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 30/10/2023
* Exercici 16: Implementa un programa que demani  a l’usuari 10 enters per teclat i els mostri en sentit contrari al que s’ha introduït.
* 
*/

using System;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string MsgEnterNum = "Introdueix un nombre: ";
            const int MAX = 10;

            int[] ArrayNum = new int[MAX];

            for (int i = 0; i < ArrayNum.Length; i++)
            {
                Console.WriteLine(MsgEnterNum);
                ArrayNum[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = ArrayNum.Length - 1; i >= 0; i--)
            {
                Console.Write(ArrayNum[i] + " ");
            }
        }
    }
}