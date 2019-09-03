using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class5swap2Number
    {
        public static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.WriteLine("\n Input the First Number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Output the Second Number");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.Read();
        }
    }
}
