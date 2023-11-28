/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 05/11/2023
* Exercici 25: Implementa un programa que emmagatzemi una frase introduïda per teclat en la variable textOne. Demana un altre text i emmagatzema’l en la variable textTwo. Afegeix textTwo a textOne i mostra-la per pantalla. És correcte? Què pots observar a les variables textOne i textTwo?
* 
*/

using System;
namespace M03Programacio
{
    class Activitats
    {
        static void Main()
        {
            const string msgEnterText = "Introdueix un text: ";

            string textOne, textTwo;

            Console.WriteLine(msgEnterText);
            textOne = Console.ReadLine();

            Console.WriteLine(msgEnterText);
            textTwo = Console.ReadLine();

            textOne = textOne + textTwo;

            Console.WriteLine(textOne);

            /*Podem observar que la variable textTwo segueix igual, i en el textOne se li ha afegit les dades del textTwo.*/
        }
    }
}