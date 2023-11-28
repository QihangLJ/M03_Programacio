/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 30/10/2023
* Exercici 17: Implementa un programa que demani a l’usuari quants valors vol emmagatzemar (en una llista).
* A continuació l’usuari els haurà d’introduir i el programa haurà de validar si és un nombre natural o no.
* En cas que no ho sigui, informarà a l’usuari i aquest disposarà de dos intents més per a introduir el nombre
* correctament. Aquesta restricció és per a tots els nombres que l’usuari introdueixi. En finalitzar, el 
* programa haurà de retornar:
*       - Total de nombres introduïts
*       - Total de nombres més petits de 15
*       - Total de nombres més grans de 30
*
*/

using System;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string MsgEnterLenght = "Introdueix una longitud per la llista: ";
            const string MsgEnterNumber = "Introdueix els valors enters: ";
            const string MsgMoreAttempts = "Tens més intents.";
            const string MsgNoAttempts = "T'has quedat sense intents.";
            const string MsgEnteredNum = "Total de nombres introduïts: ";
            const string MsgLower15 = "Total de nombres més petits de 15: ";
            const string MsgHigher30 = "Total de nombres més grans de 30: ";

            int ArrayLength, attempts = 3, Lower15 = 0, Higher30 = 0, i ;
            Console.WriteLine(MsgEnterLenght);
            ArrayLength = Convert.ToInt32(Console.ReadLine());

            int[] arrayNum = new int[ArrayLength];

            for (i = 0; i < arrayNum.Length; i++)
            {
                Console.WriteLine(MsgEnterNumber);
                Console.WriteLine("TURNO " + i);
                arrayNum[i]= Convert.ToInt32(Console.ReadLine());

                if (arrayNum[i] < 0)
                {
                    i--;
                    attempts--;
                    if (attempts == 0)
                    {
                        Console.WriteLine(MsgNoAttempts);
                        i = ArrayLength;
                    }
                    else
                        Console.WriteLine(MsgMoreAttempts);
                }
                else
                {
                    attempts = 3;
                    if (arrayNum[i] < 15)
                        Lower15++;

                    if (arrayNum[i] > 30)
                        Higher30++;
                }
            }
            Console.WriteLine(MsgEnteredNum + i);
            Console.WriteLine(MsgLower15 + Lower15);
            Console.WriteLine(MsgHigher30 + Higher30);
        }
    }
}