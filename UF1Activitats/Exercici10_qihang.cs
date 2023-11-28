/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 05/11/2023
* Exercici 10: Implementa un programa que retorni els n primers números de la serie de Fibonacci:
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
            const string msgEnterNum = "Introdueïx el número dels primers números de la serie Fibonacci: ";
            int num, temp, varOne = 0, varTwo = 1;

            Console.WriteLine(msgEnterNum);
            num = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < num; i++)
            {
                Console.Write(varOne + " ");
                temp = varOne;
                varOne = varTwo;
                varTwo = temp + varOne;
            }
        }
    }
}