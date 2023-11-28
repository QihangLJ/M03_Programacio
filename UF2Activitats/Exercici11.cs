/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 28/11/2023
 * Exercici 11. Implementa un programa que demani un valor per teclat i retorni el seu factorial.
 *
 */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const string msgEnterNum = "Introdueix el valor que vol factorialitzar:";
            const string msgError = "El nombre ha de ser positiu!";
            int num = 0, factorial = 0;

            EnterValue(msgEnterNum, ref num);
            factorial = FactorialNumber(num);
            Console.WriteLine(num > 0 ? factorial : msgError);
        }

        public static int FactorialNumber(int value)
        {
            for (int i = value - 1; i > 0;i--)
            {
                value *= i;
            }
            return value;
        }
        public static void EnterValue (string msg, ref int value)
        {
            Console.WriteLine (msg);
            value = Convert.ToInt32(Console.ReadLine());
        }
    }
}
