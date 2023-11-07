/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 06/11/2023
* Exercici 31: El següent tipus de dades emmagatzema les quantitats mitjanes de pluja per cada mes de l’any:
* 
*/

using System;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgSearchValue = "Introdueïx el valor que vol cercar:";
            const string msgNoSearched = "El valor NO es troba dins de l'array.";
            const string msgSearched = "El valor es troba en la posició";

            const int month = 12;
            const float minLiter = 5, maxLiter = 18;

            float[] arrayPluges = { 15.5f, 10f, 3.2f, 1.25f, 1.75f, 12f, 5.15f, 6.75f, 15f, 9.25f, 10.75f, 20.75f };
            float AUX, VAR = 0, rainCount = 0, search;
            int position = 0;
            bool found = false;

            for (int i = 0; i < arrayPluges.Length; i++)
            {
                for (int j = 0; j < arrayPluges.Length - 1; j++)
                {
                    if (arrayPluges[j] < arrayPluges[j+1])
                    {
                        AUX = arrayPluges[j];
                        arrayPluges[j] = arrayPluges[j + 1];
                        arrayPluges[j + 1] = AUX;
                    }
                }
            }

            for (int i = 0; i < arrayPluges.Length; i++)
            {
                Console.WriteLine($"Mes {i + 1}: {arrayPluges[i]}");
            }
            Console.WriteLine();

            for (int i = 0;i < arrayPluges.Length; i++)
            {
                VAR += arrayPluges[i];
            }
            Console.WriteLine($"La mitjana és {VAR/month}");
            Console.WriteLine();

            for (int i = 0; i < arrayPluges.Length; i++)
            {
                if (arrayPluges[i] >= minLiter && arrayPluges[i] <= maxLiter)
                {
                    rainCount++;
                }
            }
            Console.WriteLine($"Hi ha {rainCount} mesos amb mitjanes de pluges entre 5 i 18 litres");
            Console.WriteLine();

            Console.WriteLine(msgSearchValue);
            search = (float)Convert.ToDouble(Console.ReadLine());
            while (position < arrayPluges.Length && !found) 
            {
                if (arrayPluges[position] == search)
                {
                    found = true;
                }
                position++;
            }
            if(found)
            {
                Console.WriteLine($"{msgSearched} {position}");
            }
            else
            {
                Console.WriteLine(msgNoSearched);
            }
        }
    }
}