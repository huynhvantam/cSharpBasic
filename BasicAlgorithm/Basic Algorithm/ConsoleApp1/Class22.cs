using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class22
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("frizz"));
            Console.WriteLine(test("zane"));
            Console.WriteLine(test("Zazz"));
            Console.WriteLine(test("false"));

            Console.ReadLine();
        }

        public static bool test(string str)
        {
            int ctr = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'z')
                {
                    ctr++;
                }
            }

            return ctr > 1 && ctr < 4;
        }
    }
}
