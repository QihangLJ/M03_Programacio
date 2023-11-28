/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 30/10/2023
* Exercici 18: Implementa un programa que reculli els valors dels següents atributs per a 4 personatges:
*   - vida [1-1000]
*   - poder[100-500]
*   - força [20-50]
* Caldrà fer les validacions corresponents als atributs i mostrar les dades introduïdes en format de taula.
*   
*/

using System;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string MsgLife = "Introdueix vida entre [1-1000]: ";
            const string MsgPower = "Introdueix poder entre [100-500]: ";
            const string MsgStrong = "Introdueix força entre [20-50]: ";
            const string MsgWrong = "Valor no valid, torna a introduïr.";

            const int MAXChar = 4, MAXAtr = 3, OFFSET = 1;

            int[,] character = new int[MAXChar,MAXAtr + OFFSET];

            for (int i = 0; i < character.GetLength(0); i++)
            {
                for (int j = 0; j < character.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        character[i, j] = i + OFFSET;
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine(MsgLife);
                        character[i, j] = Convert.ToInt32(Console.ReadLine());
                        if (!(character[i, j] > 1 && character[i,j] < 1000))
                        {
                            Console.WriteLine(MsgWrong);
                            j--;
                        }
                    } else if(j == 2)
                    {
                        Console.WriteLine(MsgPower);
                        character[i, j] = Convert.ToInt32(Console.ReadLine());
                        if (!(character[i, j] > 100 && character[i, j] < 500))
                        {
                            Console.WriteLine(MsgWrong);
                            j--;
                        }
                    } else if (j == 3)
                    {
                        Console.WriteLine(MsgStrong);
                        character[i, j] = Convert.ToInt32(Console.ReadLine());
                        if (!(character[i, j] > 20 && character[i, j] < 50))
                        {
                            Console.WriteLine(MsgWrong);
                            j--;
                        }
                    }
                }
            }
            for (int i = 0; i < character.GetLength(0); i++)
            {
                Console.Write("Personatge: ");
                for (int j = 0; j < character.GetLength(1); j++)
                {
                    Console.Write(character[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}