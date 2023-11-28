/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 27/11/2023
 * Exercici 9. Implementa un mètode per a utilitzar en un programa principal, o invocat per un altre mètode, que permeti validar si un nombre és més petit que un valor (introduït per teclat) o és dins d’un rang (està dins de dos valors introduïts per teclat). Els missatges que es mostraran han de poder ser parametritzables.
 * 
 */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            string msgSelectAct = "Selecciona que vol fer: \n1. Nombre més petit. \n2. Valor dintre del rang.";
            string msgEnterNum = "Introdueix un nombre:";
            string msgError = "Valors invalids.";
            string msgLower = "El nombre és més petit que el valor de l'usuari.";
            string msgNotLower = "El nombre NO és més petit que el valor de l'usuari.";
            string msgInside = "El nombre esta dintre del rang dels dos nombres.";
            string msgNotInside = "El nombre NO esta dintre del rang dels dos nombres.";

            int act = 0, numOne = 0, value = 0, numTwo = 0;

            EnterValue(msgSelectAct, ref act);

            if(act == 1)
            {
                EnterValue(msgEnterNum, ref numOne);
                value = RandomValue();
                Console.WriteLine(LowerThan(value, numOne) ? msgLower : msgNotLower);
                Console.WriteLine(value);
            }
            else if(act == 2) 
            {
                EnterValue(msgEnterNum, ref numOne);
                EnterValue(msgEnterNum, ref numTwo);
                value = RandomValue();
                Console.WriteLine(InRang(numOne, numTwo, value) ? msgInside : msgNotInside);
                Console.WriteLine(value);

            }
            else
            {
                Console.WriteLine(msgError);
            }
        }
        public static bool LowerThan(int value, int userIntput) 
        {
            return value < userIntput;
        }
        public static bool InRang(int userIntputMin, int userIntputMax, int value)
        {
            return (userIntputMin < value && userIntputMax > value);
        }
        public static void EnterValue (string msg, ref int value)
        {
            Console.WriteLine (msg);
            value = Convert.ToInt32(Console.ReadLine());
        }
        public static int RandomValue()
        {
            Random random = new Random();
            return random.Next(256);
        }
    }
}
