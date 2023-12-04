/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 21/11/2023
 * Exercici 15. Implementa un programa que demani l’any i aquest retorni si és un any de traspàs. NO es poden fer servir funcions pròpies de C#.
 */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main(string[] args)
        {
            const string MsgEnterYear = "Introdueix un any:";
            const string MsgLeap = "Es un any de traspas.";
            const string MsgNotLeap = "No es un any de traspas.";

            int year = EnterNumber(MsgEnterYear);

            Console.WriteLine(LeapYear(year) ? MsgLeap : MsgNotLeap);
        }

        public static int EnterNumber(string msg)
        {
            Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static bool LeapYear (int year)
        {
            return year % 4 == 0 ? true: false;
        }
    }
}
