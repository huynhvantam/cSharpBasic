using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class30
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("abcd"));
            Console.WriteLine(test("abc"));
            Console.WriteLine(test("a"));
            Console.ReadLine();
        }
        public static string test(string str)
        {
            var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                result += str.Substring(0, i + 1);
            }
            return result;
        }
    }
}
