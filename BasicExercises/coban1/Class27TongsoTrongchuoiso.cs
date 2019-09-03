using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class27
    {
        public static void Main()
        {
            Console.Write("Input  a number(integer): ");
            //int n = int.Parse(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            //Console.WriteLine(n % 10);
            //Console.WriteLine(n /= 10);
            while (n != 0)

            {
                sum += n % 10;
                n /= 10;
                Console.WriteLine("Sum of the digits of the said integer: " + sum);
            }

        }
    }

}

