using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class21
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(78, 95));
            Console.WriteLine(test(20, 30));
            Console.WriteLine(test(21, 25));
            Console.WriteLine(test(28, 28));
            Console.ReadLine();
        }

        public static int test(int x, int y)
        {
            if (x >= 20 && x <= 30 && y >= 20 && y <= 30)
            {
                if (x >= y)
                {
                    return x;
                }
                else
                {
                    return y;
                }
            }
            //else if (x >= 20 && y <= 30)
            //{
            //    return x;
            //}
            //else if (y >= 20 && y <= 30)
            //{
            //    return y;
            //}
            else
            {
                return 0;
            }
        }
    }
}
