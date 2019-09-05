using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class29
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("PHP"));
            Console.WriteLine(test("JS"));
            Console.ReadLine();
        }
        public static string test(string s)
        {
            var result = string.Empty;
            for (var i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0) result += s[i];
            }
            return result;
        }
    }
}
