/*
 * Nom: Qihang Li Jiang
 * Módul: M03: UF1 Programació estructurada
 * Data: 09/10/2003
 * Exercici 3: Implementa un algorisme que donat un nombre introduït per teclat:
 *      - calculi quants digits té i ho mostri per pantalla
 *      - sumi els dígits amb valor parell (si n’hi han) i mostri el resultat per pantalla
 *      - sumi els dígits senars (si n’hi han)  i mostri el resultat per pantalla
 * 
 */

using System;
class ExercisesAC2
{
    static void Main()
    {
        const string intro_num = "Introdueix un nombre: ";
        int num, units = 0, even_sum = 0, odd_sum = 0;

        Console.Write(intro_num);
        num = Convert.ToInt32(Console.ReadLine());

        do
        {
            units++;

            if (units % 2 == 0)
            {
                even_sum = even_sum + (num - ((num / 10) * 10));
            } else
            {
                odd_sum = odd_sum + (num - ((num / 10) * 10));
            }
            num = num / 10;

        } while (num>0);

        Console.WriteLine("Té " + units + " digits");
        if (units % 2 == 0)
        {
            Console.WriteLine("La suma dels digits PARELL és " + odd_sum);
            Console.WriteLine("La suma dels digits SENARS és " + even_sum);
        } else
        {
            Console.WriteLine("La suma dels digits PARELL és " + even_sum);
            Console.WriteLine("La suma dels digits SENARS és " + odd_sum);
        }

    }
}