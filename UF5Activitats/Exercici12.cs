/* Qihang Li Jiang
* M03_UF5 Programacio
* 06/03/2024
* Exercici 12. Donada una llista de números, elimina els elements que siguin majors que un valor específic.
*/

using System;
using System.Collections.Generic;

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            const string MSgValue = "Introduce un valor especifico:";
            int value = 0;

            Console.WriteLine(MSgValue);
            value = Convert.ToInt32(Console.ReadLine());

            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.Add(4);
            nums.Add(3);
            nums.Add(2);
            nums.Add(1);

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > value)
                {
                    nums.Remove(nums[i]);
                    i--;
                }
            }

            Console.WriteLine();

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

        }
    }
}
