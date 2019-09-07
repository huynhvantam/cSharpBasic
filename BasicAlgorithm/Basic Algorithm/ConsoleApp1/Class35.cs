using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class35
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("abcdefgh", "abijsklm"));
            Console.WriteLine(test("abcde", "osuefrcd"));
            Console.WriteLine(test("pqrstuvwx", "pqkdiewx"));
            Console.ReadLine();
        }

        public static int test(string str1, string str2)
        {
            var ctr = 0;
            for (var i = 0; i < str1.Length - 1; i++)
            {
                var firstString = str1.Substring(i, 2);
                for (var j = 0; j < str2.Length - 1; j++)
                {
                    var secondString = str2.Substring(j, 2);
                    if (firstString.Equals(secondString))
                        ctr++;
                }
            }
            return ctr;
        }
    }
}
