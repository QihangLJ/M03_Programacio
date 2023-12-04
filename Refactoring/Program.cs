using System;
namespace Refactoring
{
    public class FirstRefactoringExercise
    {
        static void Main(string[] args)
        {
            const string MsgArrayLength = "Indica quants valors vols introduir:";
            const string MsgEnterValidValue = "introdueix un valor entre el 5 i el 150 (inclosos). Tens 3 intents com a màxim";
            const string MsgValueNotValid = "El valor introduït no és vàlid.";
            const string MsgLimit = "Has superat el total d'intents.";

            const int MaxError = 3, MinRange = 5, MaxRange = 150;

            int quantity, input, errors = 0;

            quantity = EnterIntegrer(MsgArrayLength);

            int[] numbers = new int[quantity];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (errors < MaxError)
                {
                    input = EnterIntegrer(MsgEnterValidValue);
                    if (OutOfRange(input, MinRange, MaxRange))
                    {
                        Console.WriteLine(MsgValueNotValid);
                        errors++;
                        i--;
                    }
                    else
                    {
                        numbers[i] = input;
                    }
                }
            }

            if (errors == MinRange)
            {
                Console.WriteLine(MsgLimit);
            }
            else
            {
                Console.WriteLine(CalculateMultiply(numbers));
            }
        }

        public static int CalculateMultiply(int[] numbers)
        {
            int answer = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                answer *= numbers[i];
            }
            return answer;
        }

        public static int EnterIntegrer(string msg)
        {
            Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static bool OutOfRange(int input, int min, int max)
        {
            return (input < min || input > max) ? true : false;
        }
    }
}
