/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 27/11/2023
 * Exercici 4. Implementa un mètode que rebi un text i el retorni a majúscules o a minúscules (segons el cas).
 * */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const string msgEnterText = "Introdueix un text: ";

            string userText;

            Console.WriteLine(msgEnterText);
            userText = Console.ReadLine();
            
            Console.WriteLine(UpperAndLower(userText));
        }
        public static string UpperAndLower(string text)
        {
            if (text == text.ToUpper())
            {
                text = text.ToLower();
            }
            else
            {
                text = text.ToUpper();
            }
            return text;
        }
    }
}
