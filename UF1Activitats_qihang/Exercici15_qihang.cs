/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 20/10/2023
* Exercici 10: Implementa un programa que retorni els n primers números
* de la serie de Fibonacci:

*/

using System;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string MsgEnterNumber = "Introdueix un nombre: ";
            const int OFFSET = 1;
            int NUM, FirstValueFibonacci = 0, SecondValueFibonacci = 1, Tempo;
            
            Console.WriteLine(MsgEnterNumber);
            NUM = Convert.ToInt32(Console.ReadLine());

            Console.Write(FirstValueFibonacci + " ");

            for (int i = 0; i < NUM - OFFSET; i++) 
            {
                Tempo = FirstValueFibonacci;
                FirstValueFibonacci = SecondValueFibonacci;
                SecondValueFibonacci = Tempo + FirstValueFibonacci;
                Console.Write(FirstValueFibonacci + " ");
            }
        }
    }
}