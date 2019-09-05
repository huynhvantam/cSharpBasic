using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class23
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(123, 456));
            Console.WriteLine(test(12, 512));
            Console.WriteLine(test(7, 87));
            Console.WriteLine(test(12, 45));

            Console.ReadLine();
        }

        public static bool test(int x, int y)
        {
            return Math.Abs(x % 10) == Math.Abs(y % 10);
        }
    }
}
