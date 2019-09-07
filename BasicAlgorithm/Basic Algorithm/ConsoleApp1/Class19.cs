using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class19
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(78, 95));
            Console.WriteLine(test(95, 95));
            Console.WriteLine(test(99, 70));
            Console.ReadLine();
        }
        public static int test(int x, int y)
        {
            const int n = 100;
            var val = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);

            return val == val2 ? 0 : (val < val2 ? x : y);
        }
    }
}
