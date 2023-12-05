/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 05/12/2023
 * Exercici 16. Implementa un programa que demani a l’usuari quants valors vol introduir, de manera que el programa generi una llista a partir de valors introduïts per teclat i retorni el producte de tots els elements d’aquesta. Els valors que l’usuari pot introduir són entre (15, 100) i l’usuari disposa de 5 intents en total.
 */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main(string[] args)
        {
            const string MsgArrayLength = "Introdueix una longitud d'array:";
            const string MsgError = "Valor invalid.";
            const string MsgResult = "El resultat és ";
            const int MinRange = 15, MaxRange = 100;
            
            int arrayLength = EnterNumber(MsgArrayLength);
            int[] arrayNum = new int[arrayLength];
            int mult = 1, error = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                if (error < 5)
                {
                    arrayNum[i] = EnterNumber(null);
                    if (InRange(arrayNum[i], MinRange, MaxRange))
                    {
                        mult *= arrayNum[i];
                    }
                    else
                    {
                        i--;
                        error++;
                        Console.WriteLine(MsgError);
                    }
                }
            }
            Console.WriteLine(MsgResult + mult);
        }

        public static int EnterNumber(string? msg)
        {
            Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static bool InRange(int value, int min, int max) 
        {
            return (value > min && value < max);
        }
    }
}
