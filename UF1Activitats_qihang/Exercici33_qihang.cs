/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 13/11/2023
* Exercici 33:  Donada la següent llista:
* a = [10,20,30,20,10,50,60,40,80,50,40]
* implementa un programa que retorni una llista sense els elements duplicats.
*
*/

using System;
namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            int[] arrayList = { 10, 20, 30, 20, 10, 50, 60, 40, 80, 50, 40 };
            int repeat;

            for (int i = 0; i < arrayList.Length; i++)
            {
                repeat = 0;

                for (int j = i + 1; j < arrayList.Length; j++)
                {
                    if (arrayList[i] == arrayList[j])
                    {
                        repeat++;
                    }
                }
                if (repeat == 0)
                {
                    Console.Write(arrayList[i] + " ");
                    /*Los elementos duplicados del principio no salen, salen los del final*/
                }
            }
        }
    }
}
