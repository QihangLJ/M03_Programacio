/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 08/11/2023
* Exercici 2 (repte): L’Isabel Preysler t’ha demanat fer una torre de Ferrero Rocher per a la recepció de l’ambaixador. La torre ha de ser en forma de piràmide quadrada. Això significa que el primer pis tindrà un Ferrero, el segon 4, el tercer 9, el quart 16, i així successivament (cada pis és un quadrat amb un més a cada cantó).
* 
*/

using System;
namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgTestNum = "Introdueix el nombre de proves: ";
            const string msgPyramidHeight = "Introdueix el nombre de pisos de la piràmide: ";
            const string msgRequiredFerrero = "Es necessita un total de ";

            int testNum, userIntput, numFerrero, OFFSET = 1;

            Console.WriteLine(msgTestNum);
            testNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testNum; i++)
            {
                Console.WriteLine(msgPyramidHeight);
                userIntput = Convert.ToInt32(Console.ReadLine());

                numFerrero = 0;
                
                for (int j = 0; j < userIntput; j++)
                {
                    numFerrero += ((j + OFFSET) * (j + OFFSET));
                }

                Console.WriteLine($"{msgRequiredFerrero} {numFerrero} bombons");
                Console.WriteLine();
            }
        }
    }
}
