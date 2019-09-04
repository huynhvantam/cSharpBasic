using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(30, 0));
            Console.WriteLine(test(25, 5));
            Console.WriteLine(test(20, 30));
            Console.WriteLine(test(20, 25));
            Console.ReadLine();
        }

        public static bool test(int x, int y)
        {
            return x == 30 || y == 30 || (x + y == 30);
        }
    }
}
