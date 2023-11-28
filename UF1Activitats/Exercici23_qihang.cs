/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 05/11/2023
* Exercici 23: Implementa un programa en el que s’introdueixin 20 notes per terminal 
* (valors entre el 0 i el 10 inclosos). Un cop emmagatzemats, cal demanar a l’usuari si
* vol mostrar els valors ordenats de manera ascendent o descendent i mostrar-ho per pantalla.
* 
*/

using System;
namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgEnterNum = "Introdueix 20 nombres entre 0 i 10 (inclosos): ";
            const string msgError = "El valor no és valid. ";
            const string msgRepeat = "Torna a introduir un nombre: ";
            const string msgRepetition = "Introdueix el valor numero: ";
            const string msgQuestion = "Vols ordenar-ho de manera ascendent (1) o descendent (2): ";
            const string msgUp = "Has seleccionat ordenar de manera ASCENDENT.";
            const string msgDown = "Has seleccionat ordenar de manera DESCENDENT.";

            const int MAXarray = 20, OFFSET = 1, minValue = 0, maxValue = 10;

            int[] arrayNum = new int[MAXarray];
            int userIntput, AUX;

            Console.WriteLine(msgEnterNum);
            for (int i = 0; i < arrayNum.Length; i++) 
            {
                Console.WriteLine(msgRepetition + (i+OFFSET));
                arrayNum[i] = Convert.ToInt32(Console.ReadLine());
                if (!(arrayNum[i] >= minValue && arrayNum[i] <= maxValue))
                {
                    Console.WriteLine(msgError + msgRepeat);
                    i--;
                }
            }
            Console.WriteLine(msgQuestion);
            userIntput = Convert.ToInt32(Console.ReadLine());
            switch (userIntput)
            {
                case 1:
                    for (int i = 0; i < arrayNum.Length - OFFSET; i++)
                    {
                        for (int j = 0; j < arrayNum.Length - OFFSET; j++)
                        {
                            if (arrayNum[j] > arrayNum[j + OFFSET])
                            {
                                AUX = arrayNum[j];
                                arrayNum[j] = arrayNum[j + OFFSET];
                                arrayNum[j + OFFSET] = AUX;
                            }
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < arrayNum.Length - OFFSET; i++)
                    {
                        for (int j = 0; j < arrayNum.Length - OFFSET; j++)
                        {
                            if (arrayNum[j] < arrayNum[j + OFFSET])
                            {
                                AUX = arrayNum[j];
                                arrayNum[j] = arrayNum[j + OFFSET];
                                arrayNum[j + OFFSET] = AUX;
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine(msgError);
                    break;
            }
            for (int i = 0; i < arrayNum.Length; i++)
            {
                Console.Write(arrayNum[i] + " ");
            }
        }
    }
}