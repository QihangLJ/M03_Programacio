/*
 * Author: Qihang Li Jiang
 * M03. Programació UF1
 * v1. 10/10/2023
 * Exercici 4. Implementa un programa que demani l’any i aquest retorni
 * si és un any de traspàs. NO es poden fer servir funcions pròpies de C#. 
 * 
 */

using System;

namespace M03Programacio
{
    class EX4
    {
        static void Main()
        {
            const string MsgEnterYear = "Introdueix un any: ";
            const string Leap = "És un any de traspàs ";
            const string NoLeap = "NO és un any de traspàs ";

            int year;

            Console.WriteLine(MsgEnterYear);
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((year % 4 == 0) ? Leap : NoLeap);
        }
    }
}