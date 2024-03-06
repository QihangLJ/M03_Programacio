/* Qihang Li Jiang
* M03_UF5 Programacio
* 05/03/2024
* Exercici 8. Donada una llista de números, escriu un programa que calculi la suma de tots els elements.
*/

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);

            Console.WriteLine(Sum(nums));
        }

        public static int Sum(List<int> values)
        {
            int sum = 0;
            foreach (int value in values) { sum += value; }
            return sum;
        }
    }
}
