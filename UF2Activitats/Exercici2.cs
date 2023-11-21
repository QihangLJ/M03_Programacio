/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 21/11/2023
 * Exercici 2. Crea un programa que demani per teclat un la base i l’exponent i retorni la potència.
 */

using System.Timers;

namespace QihangProgram
{
    class QihangCode
    {
        public static void Main()
        {
            Console.WriteLine(Power(Base(), Exponent()));
        }

        public static int Base()
        {
            string msgEnterBase = "Introdueix una base:";
            Console.WriteLine(msgEnterBase);
            int numBase = Convert.ToInt32(Console.ReadLine());

            return numBase;
        }
        public static int Exponent()
        {
            string msgEnterExp = "Introdueix un exponent:";
            Console.WriteLine(msgEnterExp);
            int numExp = Convert.ToInt32(Console.ReadLine());

            return numExp;
        }
        public static int Power (int b, int e)
        {
            for (int i = 1; i < e; i++)
            {
                b *= b;
            }
            return b;
        }
    }
}
