using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class19ifelse
    {
        static void Main()
        {
            //int a, b;
            //Console.WriteLine("Input first integer");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input second integer:");
            //b = int.Parse(Console.ReadLine());
            //float result = (a + b) / 2F;

            //if (a == b)
            //{
            //    Console.WriteLine("result ({0}+{1})/2x3={2}", a, b, result*3);

            //}
            //else Console.WriteLine("result ({0}+{1})/2={2}", a, b, result);

            Console.WriteLine(SumTriple(3, 2));
        }
        //public static int SumTriple(int a, int b)
        //{
        //    return a == b ? (a + b) * 3 : a + b;
        //}
        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;

        }

    }
}
