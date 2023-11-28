/*
 * Nom: Qihang Li Jiang
 * Módul: M03: UF1 Programació estructurada
 * Data: 09/10/2003
 * Exercici 2: Implementa un algorisme que trobi tots els nombres enters entre 2000 i 3000
 * (ambdós inclosos), divisibles per 7 però que no siguin múltiples de 5 i els mostri per
 * pantalla, separats per comes (com en una sèrie, i no hi ha d’haver coma al final).
 * 
 */

using System;
class ExercisesAC2
{
    static void Main()
    {
        const int min_value = 2000;
        const int max_value = 3000;
        int repetition = 0;
        for (int i = min_value ; i <= max_value ; i++) 
        {
            if ((i % 7 == 0) && (i % 5 != 0))
            {
                if (repetition >=1)
                {
                    Console.Write(", " + i);
                } else
                {
                    Console.Write(i);
                }
                repetition++;
            }
        }
    }
}