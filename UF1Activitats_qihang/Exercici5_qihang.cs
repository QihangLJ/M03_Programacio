/*
* Author: Qihang Li Jiang
* M03. Programació UF1
* v1. 10/10/2023
* Exercici 5. Implementa un programa que mostri les opcions jugar o sortir.
* Si l'usuari vol jugar, el programa emmagatzemarà en una constant un número 
* secret entre 1 i 100 (recorda declarar-la abans de mostrar les opcions).
* L’usuari disposarà de 10 intents per endevinar el número, i en cada error
* el programa li indicarà si el número introduït és més gran o més petit que
* el número secret a endevinar. 
* 
*/

using System;

namespace M03Programacio
{
    class EX4
    {
        static void Main()
        {
            const string GameMenu = "Que vols fer?      1_Jugar     2_Sortir";
            const string IntroNum = "Introdueix un nombre: ";
            const string Bigger = "El número secret és més gran";
            const string Smaller = "El número secret és més petit";
            const string Right = "Felicitats! Has encertat el numero secret.";

            int menu, SecretNum = 68, PlayerNum, attempts = 0;
            bool exit = false;

            Console.WriteLine(GameMenu);
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                do
                {
                    Console.WriteLine(IntroNum);
                    PlayerNum = Convert.ToInt32(Console.ReadLine());

                    attempts++;

                    if (PlayerNum < SecretNum)
                    {
                        Console.WriteLine(Bigger);
                    }
                    else if (PlayerNum > SecretNum)
                    {
                        Console.WriteLine(Smaller);
                    }
                    else
                    {
                        exit = true;
                    }

                } while ((attempts < 10) && (!exit));
                Console.WriteLine(Right);
            }
        }
    }
}