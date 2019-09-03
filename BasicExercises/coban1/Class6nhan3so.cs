using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class6nhan3so
    {
        public static void Main()
        {
            int a, b, c;
            Console.WriteLine("Input the first number to multiply: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply: ");
            c = int.Parse(Console.ReadLine());
            //Console.WriteLine("Expected Output: " + a * b * c);
            int result = a * b * c;
            Console.WriteLine("Expected Output: {0}x{1}x{2}={3}",a,b,c,result);
        }
    }
}
