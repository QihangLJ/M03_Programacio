/*
 * Author: Qihang Li Jiang
 * M03. Programació UF2
 * v1. 18/12/2023
 * Exercici 21. Implementa un programa que demani un nombre romà i retorni el seu valor enter.
 */


using System;
using System.Runtime.ExceptionServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QihangProgram
{
    public class QihangCode
    {
        public static void Main(string[] args)
        {
            const int I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000;

            int result = 0;
            char space = ' ';
            bool error = false;
            string RomanChar = "IVXLCDM";

            string userInput = Console.ReadLine();

            userInput = string.Concat(userInput, space);

            char[] charStringInput = userInput.ToCharArray();

            for (int i = 0; i < charStringInput.Length; i++)
            {
                switch (charStringInput[i])
                {
                    case 'I':
                        if (RomanChar.IndexOf(charStringInput[i + 1]) > RomanChar.IndexOf('I') + 2)
                        {
                            error = true;
                        } else if (RomanChar.IndexOf(charStringInput[i + 1]) <= RomanChar.IndexOf('I'))
                        {
                            result += I;
                        }
                        else
                        {
                            result -= I;
                        }

                        break;
                    case 'V':
                        if (RomanChar.IndexOf(charStringInput[i + 1]) > RomanChar.IndexOf('V') + 2)
                        {
                            error = true;
                        }
                        else if (RomanChar.IndexOf(charStringInput[i + 1]) <= RomanChar.IndexOf('V'))
                        {
                            result += V;
                        }
                        else
                        {
                            result -= V;
                        }

                        break;
                    case 'X':

                        if (RomanChar.IndexOf(charStringInput[i + 1]) > RomanChar.IndexOf('X') + 2)
                        {
                            error = true;
                        }
                        else if (RomanChar.IndexOf(charStringInput[i + 1]) <= RomanChar.IndexOf('X'))
                        {
                            result += X;
                        }
                        else
                        {
                            result -= X;
                        }

                        break;
                    case 'L':

                        if (RomanChar.IndexOf(charStringInput[i + 1]) > RomanChar.IndexOf('L') + 2)
                        {
                            error = true;
                        }
                        else if (RomanChar.IndexOf(charStringInput[i + 1]) <= RomanChar.IndexOf('L'))
                        {
                            result += L;
                        }
                        else
                        {
                            result -= L;
                        }

                        break;
                    case 'C':

                        if (RomanChar.IndexOf(charStringInput[i + 1]) > RomanChar.IndexOf('C') + 2)
                        {
                            error = true;
                        }
                        else if (RomanChar.IndexOf(charStringInput[i + 1]) <= RomanChar.IndexOf('C'))
                        {
                            result += C;
                        }
                        else
                        {
                            result -= C;
                        }

                        break;
                    case 'D':

                        if (RomanChar.IndexOf(charStringInput[i + 1]) > RomanChar.IndexOf('D') + 2)
                        {
                            error = true;
                        }
                        else if (RomanChar.IndexOf(charStringInput[i + 1]) <= RomanChar.IndexOf('D'))
                        {
                            result += D;
                        }
                        else
                        {
                            result -= D;
                        }

                        break;
                    case 'M':

                        if (RomanChar.IndexOf(charStringInput[i + 1]) > RomanChar.IndexOf('M') + 2)
                        {
                            error = true;
                        }
                        else if (RomanChar.IndexOf(charStringInput[i + 1]) <= RomanChar.IndexOf('M'))
                        {
                            result += M;
                        }
                        else
                        {
                            result -= M;
                        }

                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(!error ? result : "error");

        }

        public static string EnterUserInput(string? msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        /*public static int ConvertRomanNumbersToInt (string stringInput)
        {

        }*/

    }
}
