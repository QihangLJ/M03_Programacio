/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 28/11/2023
 * Exercici 10. Implementa un programa que generi una llista de 10 valors aleatoris entre el 0 i el 200, demani un valor per teclat i informi per pantalla si aquest valor indicat es troba a la llista.
 * 
 */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const int MAX = 10;

            string msgEnterNum = "Introdueix un nombre:";
            string msgInside = "El valor indicat es troba a la llista.";
            string msgNotInside = "El valor indicat NO es troba en la lista.";

            int num = 0;
            int[] arrayInt = new int[MAX];

            InitializeArray(ref arrayInt);

            EnterValue(msgEnterNum, ref num);

            Console.WriteLine(SearchValue(arrayInt, num)? msgInside : msgNotInside);

            ShowArray(arrayInt);
        }

        public static void InitializeArray(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RandomValue();
            }
        }
        public static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public static bool SearchValue(int[] array, int value)
        {
            int i = 0;
            while (i < array.Length)
            {
                if (array[i] == value)
                {
                    return true;
                }
                i++;
            }
            return false;
        }
        public static void EnterValue (string msg, ref int value)
        {
            Console.WriteLine (msg);
            value = Convert.ToInt32(Console.ReadLine());
        }
        public static int RandomValue()
        {
            Random random = new Random();
            return random.Next(0,200);
        }
    }
}
