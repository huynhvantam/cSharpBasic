using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Python", 1));
            Console.WriteLine(test("Python", 0));
            Console.WriteLine(test("Python", 4));
            Console.ReadLine();
        }

        public static string test(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
