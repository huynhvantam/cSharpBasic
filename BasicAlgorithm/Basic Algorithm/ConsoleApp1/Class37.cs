using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class37
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringX("xxHxix", "x"));
            Console.WriteLine(StringX("abxdddca", "a"));
            Console.WriteLine(StringX("xabjbhtrb", "b"));
            Console.ReadLine();
        }

        public static string StringX(string str1, string c)
        {
            for (int i = str1.Length - 2; i > 0; i--)
            {
                if (str1[i] == c[0])
                {
                    str1 = str1.Remove(i, 1);
                }
            }

            return str1;
        }
    }
}
