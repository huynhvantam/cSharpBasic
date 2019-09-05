using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class11
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("JS"));
            Console.WriteLine(test("Code"));
            Console.ReadLine();
        }
        public static string test(String str)
        {
            if (str.Length < 3)
            {
                return str + str + str;
            }
            else
            {
                string front = str.Substring(0, 3);
                return front + str + front;
            }
        }
    }
}
