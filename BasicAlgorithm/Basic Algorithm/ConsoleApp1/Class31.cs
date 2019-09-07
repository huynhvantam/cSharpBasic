using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class31
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("abcdsab"));
            Console.WriteLine(test("abcdabab"));
            Console.WriteLine(test("abcabdabab"));
            Console.WriteLine(test("abcabd"));
            Console.ReadLine();
        }
        public static int test(string str)
        {
            var last_two_char = str.Substring(str.Length - 2);
            var ctr = 0;

            for (var i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2).Equals(last_two_char)) ctr++;
            }
            return ctr;
        }
    }
}
