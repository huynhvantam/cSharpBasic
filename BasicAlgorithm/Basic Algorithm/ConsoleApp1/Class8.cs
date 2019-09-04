using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class8
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("C Sharp"));
            Console.WriteLine(test("JS"));
            Console.WriteLine(test("a"));
            Console.ReadLine();
        }
        public static string test(string str)
        {
            return str.Length < 2 ? str : str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
        }
    }
}
