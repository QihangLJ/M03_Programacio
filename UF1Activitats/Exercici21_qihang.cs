/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 06/11/2023
* Exercici 21:  Implementa un programa en el que s’introdueixin 20 notes per terminal (valors entre el 0 i el 10 inclosos). Un cop emmagatzemats, cal demanar a l’usuari quin valor vol cercar i el programa retornarà si aquest valor es troba entre els introduïts o no.
* 
*/

using System;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgEnterArray = "Introdueix els valors: ";
            const string msgError = "Valor invalid. Torna a introduïr.";
            const string msgSearchValue = "Quin valor vols cercar? ";
            const string msgNotExist = "El valor NO es troba entre els nombres introduïts. ";
            const string msgExist = "El valor SI esta entre els nombres introduïts. Especificament en la posició: ";
            const int MAX = 20, minValue = 0, maxValue = 10;

            int[] arrayNote = new int[MAX];
            int searchIntput, count = 0;
            bool found = false;

            Console.WriteLine(msgEnterArray);
            for (int i = 0; i < arrayNote.Length; i++)
            {
                arrayNote[i] = Convert.ToInt32(Console.ReadLine());
                if (!(minValue <= arrayNote[i] && arrayNote[i] <= maxValue))
                {
                    Console.WriteLine(msgError);
                    i--;
                }
            }

            Console.WriteLine(msgSearchValue);
            searchIntput = Convert.ToInt32(Console.ReadLine());

            while (count < arrayNote.Length && !found)
            {
                if (arrayNote[count] == searchIntput)
                {
                    found = true;
                    count--;
                }
                count++;
            }

            if (found)
            {
                Console.WriteLine(msgExist + (count + 1));
            } else
            {
                Console.WriteLine(msgNotExist);
            }
        }
    }
}