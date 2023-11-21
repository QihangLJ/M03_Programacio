/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 21/11/2023
 * Exercici 1. Crea un programa que demani dos nombres per teclat i validi si aquests són naturals. Un cop validats, haurà d’indicar quin dels dos nombres és més gran o si tots dos són iguals.
 */

using System.Timers;

namespace QihangProgram
{
    class QihangCode
    {
        public static void Main()
        {
            int num1, num2;

            num1 = EnterNaturalNumber();
            num2 = EnterNaturalNumber();

            BiggerNumber(num1, num2);

        }

        public static bool NaturalNumber(int num)
        {
            return (num >= 0);
        }

        public static int EnterNaturalNumber()
        {
            string msgEnterNum = "Introdueix un nombre natural:";
            string msgWrongValue = "Nombre no és natural.";
            int num;

            do
            {
                Console.WriteLine(msgEnterNum);
                num = Convert.ToInt32(Console.ReadLine());

                if (!NaturalNumber(num))
                    Console.WriteLine(msgWrongValue);

            } while (!NaturalNumber(num));

            return num;
        }

        public static void BiggerNumber(int num1, int num2) 
        {
            Console.WriteLine(num1 > num2 ? "El primer nombre és més gran." :
                              num1 < num2 ? "El segon nombre és més gran." :
                                            "Els dos nombres són iguals.");
        }
    }
}
