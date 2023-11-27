/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 27/11/2023
 * Exercici 6. Implementa un programa que retorni el valor absolut d'un nombre introduït per teclat, utilitzant un dels mètodes implementats en la API de .Net. 
 * 
 */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const string msgEnterNum = "Introdueix un valor: ";

            int num = 0;

            EnterValue(msgEnterNum, ref num);

            Console.WriteLine(Math.Abs(num));
          
        }
        public static void EnterValue(string msg, ref int value) 
        {
            Console.WriteLine(msg);
            value = Convert.ToInt32(Console.ReadLine());
        }
    }
}
