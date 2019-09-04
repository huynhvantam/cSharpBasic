using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class17
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("ytade"));
            Console.WriteLine(test("jsues"));
            Console.ReadLine();

        }
        public static string test(string str)
        {
            return str.Substring(1, 2).Equals("yt") ? str.Remove(1, 2) : str;
        }
    }
}
