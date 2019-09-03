using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class9trungBinhcong
    {
        static void Main()
        {
            int a, b, c, d;
            Console.WriteLine("Input the first number to multiply: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the four number to multiply: ");
            d = int.Parse(Console.ReadLine());
            int reult = (a + b + c + d) / 4;
            Console.WriteLine("Expected Output:");
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", a, b, c, d, reult);
        }
    }
}
