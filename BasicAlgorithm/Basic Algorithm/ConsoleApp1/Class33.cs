using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Class33
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine(test(new[] { 1, 2, 3, 4, 5, 6 }, 2));
            Console.WriteLine(test(new[] { 1, 2, 2, 3 }, 9));
            Console.ReadLine();
        }
        public static bool test(int[] numbers, int n)
        {
            return numbers.Length < 4 ? numbers.Contains(n) : numbers.Take(4).Contains(n);
        }
    }
}
