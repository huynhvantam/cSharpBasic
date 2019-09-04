using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class14
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(100, 199));
            Console.WriteLine(test(250, 300));
            Console.WriteLine(test(105, 190));
            Console.ReadLine();
        }
        public static bool test(int x, int y)
        {
            return (x >= 100 && x <= 200) || (y >= 100 && y <= 200);
        }
    }
}
