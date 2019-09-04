using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class12
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("C# Sharp"));
            Console.WriteLine(test("C#"));
            Console.WriteLine(test("C++"));
            Console.ReadLine();
        }
        public static bool test(string str)
        {
            return (str.Length < 3 && str.Equals("C#")) || (str.StartsWith("C#") && str[2] == ' ');
        }
    }
}
