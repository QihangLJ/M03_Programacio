/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 27/11/2023
 * Exercici 8. Implementa un mètode que retorni 10 nombres al·leatoris entre 0 i 256.
 * 
 */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const int MAX = 10, randMin = 0, randMax = 256;

            for (int i = 0; i < MAX; i++)
            {
                Console.Write(RandomValue(randMin, randMax) + " ");
            }
        }
        public static int RandomValue(int min, int max) 
        {
            Random rand = new Random();
            return rand.Next(min,max);
        }
    }
}
