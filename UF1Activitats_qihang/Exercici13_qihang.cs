/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 25/10/2023
* Exercici 13: Implementa un programa que demani 20 nombres enters per teclat i retorni 
* els valors de les posicions senars.
*/

using System;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string MsgEnterNumber = "Introdueix un nombre enter: ";
            const int MAX = 20;
            const int EvenNum = 2;

            int[] arrayNUM = new int[MAX];

            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine(MsgEnterNumber);
                arrayNUM[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i < MAX;i++) 
            {
                if (i % EvenNum != 0)
                    Console.Write(arrayNUM[i] + " ");
            }
        }
    }
}