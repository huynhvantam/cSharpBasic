using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class9
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Red"));
            Console.WriteLine(test("Green"));
            Console.WriteLine(test("1"));
            Console.ReadLine();
        }

        public static string test(string str)
        {
            var s = str.Substring(str.Length - 1);
            return s + str + s;
        }
    }
}
