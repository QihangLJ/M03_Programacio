/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 17/10/2023
* Exercici 6:  Implementa un programa on l’usuari escrigui un valor que representarà
* una nota (en format decimal). El programa haurà de retornar el valor qualitatiu 
* corresponent: "Excel·lent", "Notable", "Bé", "Suficient", "Suspès", "Nota invàlida".
* 
*/

using System;

namespace M03Programacio
{
    class EX4
    {
        static void Main()
        {
            const string EnterNote = "Introdueix una nota en format decimal: ";

            decimal note;
            string evaluation;

            Console.WriteLine(EnterNote);
            note = Convert.ToDecimal(Console.ReadLine());

            if (( 9 <= note)&&(note <= 10))
            {
                evaluation = "Excel·lent";
            } else if ( 7 <= note)
            {
                evaluation = "Notable";
            } else if ( 6 <= note)
            {
                evaluation = "Bé";
            } else if ( 5 <= note)
            {
                evaluation = "Suficient";
            } else if (( 5 > note) && (note > 0))
            {
                evaluation = "Suspès";
            } else
            {
                evaluation = "Nota invàlida";
            }
            Console.WriteLine(evaluation);
        }
    }
}