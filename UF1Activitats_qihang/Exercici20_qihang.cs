/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 06/11/2023
* Exercici 20: Especifica un algorisme que demani a l’usuari que introdueixi els números d’una matriu de 7 files per 3 columnes (compresos entre 1 i 9 inclosos) per teclat. Una vegada la matriu estigui omplerta, cal que el vostre programa mostri la matriu trasposta (només els valors, sense els claudàtors).
* 
*/

using System;

namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgEnterRow = "Introdueix la fila de la matriu:";
            const string msgError = "Valor invalid, torna a introduir.";

            const int ROW = 7, COL = 3;

            int[,] matrix = new int[ROW, COL];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(msgEnterRow);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (!(matrix[i,j] >= 1 && matrix[i,j] <=9))
                    {
                        if(j == 0)
                        {
                            i--;
                            j = matrix.GetLength(1) - 1;
                        }
                        else
                        {
                            j--;
                        }
                        Console.WriteLine(msgError);
                    }
                }
            }
            for (int j = 0;j < matrix.GetLength(1); j++)
            {
                for (int i = 0;i < matrix.GetLength(0); i++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
