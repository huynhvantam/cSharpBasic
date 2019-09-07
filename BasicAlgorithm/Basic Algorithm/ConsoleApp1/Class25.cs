using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class25
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("JS", 2));
            Console.WriteLine(test("JS", 3));
            Console.WriteLine(test("JS", 1));
            Console.ReadLine();

            Console.ReadLine();
        }
        public static string test(string s, int n)
        {
            string result = String.Empty;
            for (int i = 0; i < n; i++)
            {
                result += s;
            }
            return result;
        }
    }
}
