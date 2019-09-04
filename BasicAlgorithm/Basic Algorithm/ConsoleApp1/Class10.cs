using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class10
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(3));
            Console.WriteLine(test(14));
            Console.WriteLine(test(12));
            Console.WriteLine(test(37));
            Console.ReadLine();
        }
        public static bool test(int n)
        {
            return n % 3 == 0 || n % 7 == 0;
        }
    }
}
