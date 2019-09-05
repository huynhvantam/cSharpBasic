using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class13
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(120, -1));
            Console.WriteLine(test(-1, 120));
            Console.WriteLine(test(2, 120));
            Console.ReadLine();
        }

        public static bool test(int temp1, int temp2)
        {
            return temp1 < 0 && temp2 > 100 || temp2 < 0 && temp1 > 100;
        }
    }
}
