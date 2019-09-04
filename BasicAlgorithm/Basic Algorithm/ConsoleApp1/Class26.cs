using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class26
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Python", 2));
            Console.WriteLine(test("Python", 3));
            Console.WriteLine(test("JS", 3));
            Console.ReadLine();
        }

        public static string test(string s, int n)
        {
            var result = string.Empty;
            var frontOfString = 3;

            if (frontOfString > s.Length)
                frontOfString = s.Length;

            var front = s.Substring(0, frontOfString);

            for (var i = 0; i < n; i++)
            {
                result += front;
            }
            return result;
        }
    }
}
