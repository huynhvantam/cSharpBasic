using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class8cuuchuong
    {
        public static void Main() {
            int number;
            Console.WriteLine("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            //Console.WriteLine("{0} * 0 = {1}", number,number * 0);
            //Console.WriteLine("{0} * 1 = {1}", number, number * 1);
            //Console.WriteLine("{0} * 2 = {1}", number, number * 2);
            //Console.WriteLine("{0} * 3 = {1}", number, number * 3);
            for (int i =0; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number,i, number * i);
            }
        }

    }
}
