using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class16
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(20, 84));
            Console.WriteLine(test(14, 50));
            Console.WriteLine(test(11, 45));
            Console.WriteLine(test(25, 40));
            Console.ReadLine();
        }

        public static bool test(int x, int y)
        {
            return (x <= 20 || y >= 50) || (y <= 20 || x >= 50);
        }
    }
}
