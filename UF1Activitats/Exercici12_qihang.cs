/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 25/10/2023
* Exercici 12: Implementa un programa que demani 20 nombres enters per teclat
* i retorni els valors separats en dues files: parell i senars.
* 
*/

using System;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string EnterNumber = "Introdueix un nombre enter: ";
            const int MAX = 20;

            int[] arrayNUM = new int[MAX];
            int[] arrayEVEN = new int[MAX];
            int[] arrayODD = new int[MAX];

            for (int i = 0; i < MAX; i++) 
            {
                Console.WriteLine(EnterNumber);
                arrayNUM[i] = Convert.ToInt32(Console.ReadLine());

                if (arrayNUM[i] % 2 == 0)
                    arrayEVEN[i] = arrayNUM[i];
                else
                    arrayODD[i] = arrayNUM[i];
            }

            for (int i = 0; i < MAX; i++)
            {
                if (arrayNUM[i] % 2 == 0)
                    arrayEVEN[i] = arrayNUM[i];
                else
                    arrayODD[i] = arrayNUM[i];
            }

            Console.WriteLine("Parells: ");
            for (int i = 0;i < MAX; i++)
            {
                if (arrayEVEN[i] != 0)
                    Console.Write(arrayEVEN[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Senars: ");
            for (int i = 0; i < MAX; i++)
            {
                if (arrayODD[i] != 0)
                    Console.Write(arrayODD[i] + " ");
            }
        }
    }
}