/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 25/10/2023
* Exercici 14: Especifica un algorisme que demani 20 nombres enters 
* (compresos entre 1 i 9 inclosos) per teclat. Cal que l’algorisme
* imprimeixi els valors de dreta a esquerra i després d’esquerra a 
* dreta.
*/

using System;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string MsgEnterNumber = "Introdueix un nombre: ";
            const int ArrayLong = 20;
            const int MAXValue = 9;
            const int MINValue = 1;
            const int OFFSET = 1;

            int[] arrayNUM = new int[ArrayLong];

            for (int i = 0; i < ArrayLong; i++) 
            {
                Console.WriteLine(MsgEnterNumber);
                do{
                    arrayNUM[i] = Convert.ToInt32(Console.ReadLine());
                } while (!(arrayNUM[i] >= MINValue && arrayNUM[i] <= MAXValue));
            }

            for (int i = 0; i < ArrayLong; i++)
            {
                Console.Write(arrayNUM[i] + " ");
            }
       
            Console.WriteLine(" ");

            for (int i = ArrayLong - OFFSET; i >= 0; i--)
            {
                Console.Write(arrayNUM[i] + " ");
            }
        }
    }
}