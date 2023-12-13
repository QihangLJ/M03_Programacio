/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 13/12/2023
 * Exercici 20. Implementa un programa que donat un nombre decimal introduït per teclat retorni la part entera i la part decimal d’aquest.
 */


using System;
namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main(string[] args)
        {
            const string MsgEnterNum = "Introdueix un nombre decimal amb decimals:";
            const string MsgResult = "El nombre introduit es {0}, la part entera es {1} i part decimal es {2}";

            decimal num, decimalPart = 0;
            int integerPart = 0;

            num = EnterNumber(MsgEnterNum);

            SplitIntegerAndDecimal(num, ref integerPart,ref decimalPart);

            Console.WriteLine(MsgResult, num, integerPart, decimalPart);

        }

        public static decimal EnterNumber(string? msg)
        {
            Console.WriteLine(msg);
            return Convert.ToDecimal(Console.ReadLine());
        }

        public static void SplitIntegerAndDecimal (decimal val, ref int intVal, ref decimal decVal)
        {
            intVal = Convert.ToInt32(val*10)/10; //Multipliquem i dividim per 10 perque el valor del int sigui sempre el valor inferior, ja que el "Convert" ho aproxima.
            decVal = val - intVal;
        }

    }
}
