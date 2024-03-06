/* Qihang Li Jiang
* M03_UF5 Programacio
* 05/03/2024
* Exercici 9. Donada una llista de números, filtra i mostra només els nombres parells.
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
            nums.Add(6);

            ShowEven(nums);
        }

        public static void ShowEven(List<int> values)
        {
            foreach (int value in values)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
