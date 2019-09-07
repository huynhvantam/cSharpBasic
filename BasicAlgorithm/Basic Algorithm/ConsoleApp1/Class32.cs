using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Class32
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine(test(new[] { 1, 2, 2, 3 }, 2));
            Console.WriteLine(test(new[] { 1, 2, 2, 3 }, 9));
            Console.ReadLine();
        }

        public static bool test(int[] numbers, int n)
        {
            return numbers.Length < 4 ? numbers.Contains(n) : numbers.Take(4).Contains(n);
        }
    }
}
