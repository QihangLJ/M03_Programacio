/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 29/11/2023
 * Exercici 12. Demanar per teclat el nombre de litres consumits aquest mes i calcular la factura d’aigua, tenint en compte les següents dades:
 *                  La quota fixa és de 6€.
 *                  Els primers 50 litres d’aigua són de franc.
 *                  Entre 50 i 200 litres, el litre costa 0,1€
 *                  A partir de 200 el litre costa 0,3€.
 *
 */

using System;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main()
        {
            const string MsgEnterLitre = "Introdueix la cuantitat de litres consumit:";
            const float FirstPrice = 0.1f, SecondPrice = 0.3f;

            float litre = 0, cost;

            EnterValue(MsgEnterLitre, ref litre);
            cost = PriceCalculator(litre,FirstPrice, SecondPrice);

            Console.WriteLine($"La factura de l'aigua és de {cost}");
        }
        public static void EnterValue (string msg, ref float value)
        {
            Console.WriteLine (msg);
            value = (float)Convert.ToDecimal(Console.ReadLine());
        }

        public static float PriceCalculator (float value, float priceOne, float priceTwo)
        {
            float price = 6;
            
            if (value > 200)
                price = (value * priceTwo) + price;
            else if (value > 50 && value <= 200)
                price = (value * priceOne) + price;

            return price;
        }
    }
}
