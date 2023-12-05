/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 05/12/2023
 * Exercici 18. Implementa un mètode que rebiun nombre enter (minuts) i retorni la seva conversió a segons.
 */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main(string[] args)
        {
            const string MsgEnterValue = "Introdueix un valor en minuts:";
            const string MsgToSeconds = "El valor en segons son";

            int numMinuts = EnterNumber(MsgEnterValue);
            float numSeconds = MinutsToSeconds(numMinuts);

            Console.WriteLine($"{MsgToSeconds} {numSeconds}");
        }

        public static int EnterNumber(string? msg)
        {
            Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static float MinutsToSeconds(int min)
        {
            return min * 60;
        }
    }
}
