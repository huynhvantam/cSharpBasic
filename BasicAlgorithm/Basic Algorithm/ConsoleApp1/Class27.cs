using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class27
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("bbaaccaag"));
            Console.WriteLine(test("jjkiaaasew"));
            Console.WriteLine(test("JSaaakoiaa"));
            Console.ReadLine();
        }

        public static int test(string s)
        {
            int ctr_aa = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s.Substring(i, 2) == "aa")
                {
                    ctr_aa++;
                }
            }
            return ctr_aa;
        }
    }
}
