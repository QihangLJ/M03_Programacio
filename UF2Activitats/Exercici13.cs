/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 29/11/2023
 * Exercici 13. Implementa un algorisme que demani 20 nombres enters per teclat i retorni els valors de  les posicions senars.
 * 
 */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const int MAX = 20;
            int[] arrayInt = new int[MAX];

            InitializeArray(ref arrayInt);
            OddPositionArray(arrayInt);
        }

        public static int EnterNumber (string msg)
        {
            Console.WriteLine (msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void InitializeArray(ref int[] array)
        {
            const string MsgEnterNum = "Introdueix un valor:";
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = EnterNumber(MsgEnterNum);
            }
        }

        public static void OddPositionArray(int[] array)
        {
            for (int i = 0;i < array.Length;i++)
            {
                if ((i + 1) % 2 != 0)
                    Console.Write(array[i] + " ");
            }
        }
    }
}
