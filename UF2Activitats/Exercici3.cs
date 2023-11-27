/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 27/11/2023
 * Exercici 3. Implementa un programa que retorni el valor absolut d'un nombre introduït per teclat.
 * */

using System.ComponentModel.DataAnnotations;
using System.Timers;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const string msgEnterNum = "Introdueix un nombre: ";

            int num;

            Console.WriteLine(msgEnterNum);
            num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("El valor absolut es, " + AbsoluteValue(num));
        }
        public static int AbsoluteValue(int value)
        {
            int res;
            return (value < 0 ? (value + (value * (-2))) : value);
        }
    }
}
