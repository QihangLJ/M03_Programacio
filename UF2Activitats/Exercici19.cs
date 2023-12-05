/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 05/12/2023
 * Exercici 19. Implementa un programa que retorni el màxim i mínim de dos valors enters introduïts per teclat.
 */

using System;
using System.ComponentModel.DataAnnotations;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main(string[] args)
        {
            const string MsgFirstValue = "Introdueix el primer valor:";
            const string MsgSecondValue = "Introdueix el segon valor:";

            int firstNum = EnterNumber(MsgFirstValue);
            int secondNum = EnterNumber(MsgSecondValue);

            int max, min;

            max = MaxNumber(firstNum, secondNum);
            min = MinNumber(firstNum, secondNum);

            Console.WriteLine($"Maxim: {max} Minim: {min}");
        }

        public static int EnterNumber(string? msg)
        {
            Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int MaxNumber (int num1, int num2)
        {
            return (num1 > num2) ? num1 : num2;
        }
        public static int MinNumber(int num1, int num2)
        {
            return (num1 < num2) ? num1 : num2;
        }

    }
}
