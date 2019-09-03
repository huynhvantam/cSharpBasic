using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class7
    {
        public static void Main()
        {
            int number1, number2;
            Console.WriteLine("nhap so thu nhat: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu hai: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            Console.WriteLine("{0}+{1}={2}", number1, number2, number1 + number2);
            Console.WriteLine("{0}-{1}={2}", number1, number2, number1 - number2);
            Console.WriteLine("{0}x{1}={2}", number1, number2, number1 * number2);
            Console.WriteLine("{0}/{1}={2}", number1, number2, number1 /number2);
        }
    }
}
