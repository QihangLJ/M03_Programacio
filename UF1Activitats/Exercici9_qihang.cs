/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 20/10/2023
* Exercici 9: Implementa un programa que demani un nombre i aquest retorni
* el seu factorial.
*/

using System;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string MsgEnterNumber = "Introdueix un nombre: ";
            int NUM, RESULT = 1;
            
            Console.WriteLine(MsgEnterNumber);
            NUM = Convert.ToInt32(Console.ReadLine());

            for (int i = NUM; i > 0;  i--)
            {
                RESULT = RESULT * i;
            }
            Console.WriteLine(RESULT);
        }
    }
}