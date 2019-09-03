using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class17chenStringDauCuoi
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Input a string : ");
            str = Console.ReadLine();
            if (str.Length >= 1)
            {
                string s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);
            }
        }
    }
}
