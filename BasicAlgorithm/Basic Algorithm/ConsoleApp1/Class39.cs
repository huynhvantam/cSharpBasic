using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class39
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 1, 2, 2, 1 }));
            Console.WriteLine(test(new[] { 1, 1, 2, 1, 2, 3 }));
            Console.WriteLine(test(new[] { 1, 1, 1, 2, 2, 2, 1 }));
            Console.ReadLine();
        }
        public static bool test(int[] nums)
        {
            int arra_len = nums.Length - 1, n = 0;
            for (int i = 0; i < arra_len; i++)
            {
                n = nums[i];
                if (n == nums[i + 1] && n == nums[i + 2]) return true;
            }
            return false;
        }
    }
}
