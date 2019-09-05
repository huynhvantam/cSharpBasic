using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class20
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(78, 95));
            Console.WriteLine(test(25, 35));
            Console.WriteLine(test(40, 50));
            Console.WriteLine(test(55, 60));
            Console.ReadLine();
        }

        public static bool test(int x, int y)
        {
            return (x >= 40 && x <= 50 && y >= 40 && y <= 50) || (x >= 50 && x <= 60 && y >= 50 && y <= 60);
        }
    }
}
