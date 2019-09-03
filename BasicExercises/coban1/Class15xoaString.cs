using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class15xoaString
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(remove_char("w3resource", 1));
        //    Console.WriteLine(remove_char("w3resource", 9));
        //    Console.WriteLine(remove_char("w3resource", 0));
        //}
        //public static string remove_char(string str, int n)
        //{
        //    return str.Remove(n, 1);
        //}
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 2);
        }
        public static void Main()
        {
            String a = "w3resource";
            Console.WriteLine(remove_char(a, 1));
            Console.WriteLine(remove_char(a, a.Length-2));
            Console.WriteLine(remove_char(a, 0));
        }
    }
}
