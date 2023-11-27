/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 27/11/2023
 * Exercici 7. Implementa un programa que retorni el la potència d'un nombre introduït per teclat, utilitzant un dels mètodes implementats en la API de .Net. 
 * 
 */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const string msgEnterBase = "Introdueix una base: ";
            const string msgEnterExpo = "Introdueix un exponent: ";

            int numBase = 0, numExpo = 0;

            EnterValue(msgEnterBase, ref numBase);
            EnterValue(msgEnterExpo, ref numExpo);

            Console.WriteLine(Math.Pow(numBase,numExpo));
          
        }
        public static void EnterValue(string msg, ref int value) 
        {
            Console.WriteLine(msg);
            value = Convert.ToInt32(Console.ReadLine());
        }
    }
}
