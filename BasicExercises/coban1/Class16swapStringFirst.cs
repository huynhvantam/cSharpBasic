using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class16swapStringFirst
    {
        public static string firstlast(string a)
        {
            return a.Length > 1 ? a.Substring(a.Length - 1) + a.Substring(1, a.Length - 2) + a.Substring(0,1) : a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(firstlast("w3resource"));
            Console.WriteLine(firstlast("Python"));
            Console.WriteLine(firstlast("x"));
        }
    }
}
