using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class18ifelse
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Input first integer");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive: ");
            if (a<0 && b>0 || a>0 &&b<0)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");
        }
    }
}
