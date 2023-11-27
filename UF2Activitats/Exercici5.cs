/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 27/11/2023
 * Exercici 5. Demanar un nombre per teclat i indicar per pantalla si aquest nombre és positiu i menor que 100.
 * 
 */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const string msgEnterNum = "Introdueix un num: ";

            int num;

            Console.WriteLine(msgEnterNum);
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write(IsPositive(num) ? "Es positiu " : "Es negatiu ");
            Console.Write(SmallerThan100(num) ? "y es menor que 100 " : "y NO es menor que 100 ");

        }
        public static bool IsPositive(int value)
        {
            bool positive;
            return (positive = (value > 0) ? true : false);
        }
        public static bool SmallerThan100(int value)
        {
            bool smaller;
            return (smaller = (value < 100) ? true : false);
        }
    }
}
