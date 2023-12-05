/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 05/12/2023
 * Exercici 17. Implementa un programa que llegeixi graus en escala Celsius (CC) i els converteixi en graus en escala Fahrenheit (FF). Arrodoneix el resultat a 2 dígits després del punt decimal.
 */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main(string[] args)
        {
            const string MsgEnterValue = "Introdueix un valor:";
            const string MsgToFahrenheit = "El valor en Fahrenheit son";

            float numCelsius = EnterNumber(MsgEnterValue);
            float numFahremheit = CelsiusToFahrenheit(numCelsius);

            Console.WriteLine($"{MsgToFahrenheit} {numFahremheit:N2}");
        }

        public static float EnterNumber(string? msg)
        {
            Console.WriteLine(msg);
            return (float) Convert.ToDecimal(Console.ReadLine());
        }

        public static float CelsiusToFahrenheit(float celsius)
        {
            float fahrenheit = 0;

            fahrenheit = celsius * 9 / 5 + 32;

            return fahrenheit;
        }
    }
}
