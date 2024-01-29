using System;

namespace Exercici32_M03UF2
{
    public class Super4
    {
        public static void Main()
        {
            const string AskAvatar = "Selecciona el teu avatar:";
            const string MsgSelectedAvatar = "You have selected the avatar {0}!";
            const string AskName = "Introdueix un nom pel Avatar:";
            const string AskWickedness = "Introdueix la maldat del monstre:";
            const string MsgResult = "Resultat:";

            const int OFFSET = 1, MinAvatar = 1, MaxAvatar = 4, MinWickedness = 1000, MaxWickedness = 50000;
            const float Percent = 0.05f;

            int[] avatars = [1, 2, 3, 4];
            float[] allyHealth = [1000, 1000, 1000, 1000];
            int input = 0, team = 4;
            float Wickedness = 0;
            string avatarName;

            while (!CheckValueInRange(input, MinAvatar, MaxAvatar))
            {
                Console.WriteLine(AskAvatar + "\n");
                input = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(MsgSelectedAvatar, avatars[input - OFFSET]);
            
            Console.WriteLine(AskName + "\n");
            avatarName = Console.ReadLine()!;

            while (!CheckValueInRange(Wickedness, MinWickedness, MaxWickedness))
            {
                Console.WriteLine(AskWickedness + "\n");
                Wickedness = (float) Convert.ToDecimal(Console.ReadLine());
            }

            if (CheckMinimumTwoVocals(avatarName))
            {
                for (int i = 0; i < allyHealth.Length; i++)
                {
                    allyHealth[i] += DistributeWickedness(Wickedness, team);
                }
            }
            else
            {
                for (int i = 0; i < allyHealth.Length; i++)
                {
                    allyHealth[i] += DistributeWickedness(Wickedness, team, Percent);
                }
            }

            Console.WriteLine("\n" + MsgResult);
            foreach (int i in allyHealth)
            {
                Console.WriteLine(i);
            }
        }

        public static int ReadNumberOfVocals (string name)
        {
            char[] nameChar = name.ToLower().ToCharArray();
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (nameChar[i] == 'a' || nameChar[i] == 'e' || nameChar[i] == 'i' || nameChar[i] == 'o' || nameChar[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }

        public static bool CheckMinimumTwoVocals(string name)
        {
            int numVocals = ReadNumberOfVocals(name);
            return numVocals >= 2 ? true : false;
        }

        public static bool CheckValueInRange(float input, int min, int max)
        {
            return input >= min && input <= max;
        }

        public static float DistributeWickedness(float totalWickedness, int charactersNum)
        {
            return totalWickedness / charactersNum;
        }
        public static float DistributeWickedness(float totalWickedness, int charactersNum, float percentage)
        {
            return totalWickedness * percentage / charactersNum;
        }
    }
}
