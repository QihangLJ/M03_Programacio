using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class Identifier
    {
        //DEFINITIVA
        public static string Clean(string str)
        {
            string result = "";

            result = str.Replace(" ", "_");

            result = result.Replace("\\0", "CTRL");

            string[] words = str.Split('-');
            if(words.Length > 0)
            {
                string camelCase = words[0];
                for (int i = 1; i < words.Length; i++)
                {
                    camelCase += char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
                result = camelCase;
            }

            const int ASCII_A = 65;
            const int ASCII_Z = 90;
            const int ASCII_a = 97;
            const int ASCII_z = 122;
            string aux = "";

            foreach (char character in result)
            {
                int ascii = (int)character;
                if ((ascii >= ASCII_A && ascii <= ASCII_Z) || (ascii >= ASCII_a && ascii <= ASCII_z))
                {
                    aux += character;
                }
            }



            return result;
        }



        //EX1
        public static string Clean1(string str)
        {
            return str.Replace(" ", "_");
        }

        //EX2
        public static string Clean2(string str, string ctrl = "CTRL")
        {
            return str.Replace("\\", ctrl);
        }

        //EX3
        public static string Clean3(string str, bool kebab = true)
        {
            if (kebab)
            {
                string[] words = str.Split('-');
                string camelCase = words[0];
                for (int i = 1; i < words.Length; i++)
                {
                    camelCase += char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
                return camelCase;
            }
            else
            {
                return str;
            }
        }

        //EX4
        public static string Clean4(string str)
        {
            const int ASCII_A = 65;
            const int ASCII_Z = 90;
            const int ASCII_a = 97;
            const int ASCII_z = 122;
            string result = "";

            foreach (char character in str)
            {
                int ascii = (int)character;
                if ((ascii >= ASCII_A && ascii <= ASCII_Z) || (ascii >= ASCII_a && ascii <= ASCII_z))
                {
                    result += character;
                }
            }
            return result;
        }

        //EX5
        public static string Clean5(string str)
        {
            const string Greek = "αβγδεζηθικλμνξοπρστυφχψω";
            string result = "";
            
            foreach (char character in str)
            {
                if (!Greek.Contains(character))
                {
                    result += character;
                }
            }

            return result;
        }
    }
}
