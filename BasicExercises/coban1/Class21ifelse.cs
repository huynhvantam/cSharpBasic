using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class21ifelse
    {
        public static int testsum(int a, int b)
        {
            //string str;
            return a == 20 || b == 20 || a + b == 20 ? 1 :0 ;
        }
        public static void Main()
        {
            Console.WriteLine(testsum(50, 20));
            Console.WriteLine(testsum(1, 19));
        }
        //static void Main(string[] args)
        //{
        //    int x, y;


        //    Console.WriteLine("\nInput an integer:");
        //    x = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Input another integer:");
        //    y = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine(x == 20 || y == 20 || (x + y == 20));
    }
    }

