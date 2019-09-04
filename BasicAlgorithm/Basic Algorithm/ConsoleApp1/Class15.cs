using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class15
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(11, 20, 12));
            Console.WriteLine(test(30, 30, 17));
            Console.WriteLine(test(25, 35, 50));
            Console.WriteLine(test(15, 12, 8));
            Console.ReadLine();
        }

        public static bool test(int x, int y, int z)
        {
            return (x >= 20 && x <= 50) || (y >= 20 && y <= 50) || (z >= 20 && z <= 50);
        }
    }
}
