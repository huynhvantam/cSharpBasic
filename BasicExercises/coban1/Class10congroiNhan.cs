using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class10congroiNhan
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter first number ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            Console.WriteLine("Result of specified numbers {0},{1} and {2},(x+y).z is {3} and x.y + y.z is {4}", a, b, c, (a + b) * c, a * b + b * c);
        }
    }
}
