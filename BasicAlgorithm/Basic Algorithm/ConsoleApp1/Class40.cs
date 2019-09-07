using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class40
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(12, 17));
            Console.WriteLine(test(2, 17));
            Console.WriteLine(test(22, 17));
            Console.WriteLine(test(20, 0));
            Console.ReadLine();
        }
        public static int test(int a, int b)
        {
            return a + b >= 10 && a + b <= 20 ? 30 : a + b;
        }
    }
}
