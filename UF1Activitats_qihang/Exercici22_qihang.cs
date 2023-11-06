/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 05/11/2023
* Exercici 22: Modifica el programa anterior de manera que mostri les notes introduïdes ordenades de manera ascendent i descendent (per separat).
* 
*/

using System;
using System.Runtime.Intrinsics.X86;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgEnterArray = "Introdueix els valors: ";
            const string msgError = "Valor invalid. Torna a introduïr.";

            const int MAX = 20, minValue = 0, maxValue = 10, OFFSET = 1;

            int[] arrayNote = new int[MAX];
            int AUX;

            Console.WriteLine(msgEnterArray);
            for (int i = 0; i < arrayNote.Length; i++)
            {
                arrayNote[i] = Convert.ToInt32(Console.ReadLine());
                if (!(minValue <= arrayNote[i] && arrayNote[i] <= maxValue))
                {
                    Console.WriteLine(msgError);
                    i--;
                }
            }

            for (int i = 0; i < arrayNote.Length - OFFSET; i++)
            {
                for (int j = 0; j < arrayNote.Length - OFFSET; j++)
                {
                    if (arrayNote[j] > arrayNote[j + OFFSET])
                    {
                        AUX = arrayNote[j];
                        arrayNote[j] = arrayNote[j + OFFSET];
                        arrayNote[j + OFFSET] = AUX;
                    }
                }
            }
            foreach (int i in arrayNote)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < arrayNote.Length - OFFSET; i++)
            {
                for (int j = 0; j < arrayNote.Length - OFFSET; j++)
                {
                    if (arrayNote[j] < arrayNote[j + OFFSET])
                    {
                        AUX = arrayNote[j];
                        arrayNote[j] = arrayNote[j + OFFSET];
                        arrayNote[j + OFFSET] = AUX;
                    }
                }
            }
            foreach (int i in arrayNote)
            {
                Console.Write(i + " ");
            }
        }
    }
}