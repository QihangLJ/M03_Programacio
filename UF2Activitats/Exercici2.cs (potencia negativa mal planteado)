/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 21/11/2023
 * Exercici 2. Crea un programa que demani per teclat un la base i l’exponent i retorni la potència.
 */

using System.Timers;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            Console.WriteLine(Power(Base(), Exponent()));
        }

        public static float Base()
        {
            string msgEnterBase = "Introdueix una base:";
            Console.WriteLine(msgEnterBase);
            float numBase = Convert.ToInt32(Console.ReadLine());

            return numBase;
        }
        public static float Exponent()
        {
            string msgEnterExp = "Introdueix un exponent:";
            Console.WriteLine(msgEnterExp);
            float numExp = Convert.ToInt32(Console.ReadLine());

            return numExp;
        }
        public static float Power(float b, float e)
        {
            float temp = b;

            if (e == 0)
            {
                b = 1;
            }
            else if (e > 0)
            {
                for (int i = 0; i < e - 1; i++)
                {
                    b *= temp;
                }
            }
            else
            {
                for (int i = 0; i > e - 1; i--)
                {
                    b /= temp;
                }
            }

            return b;
        }
    }
}
