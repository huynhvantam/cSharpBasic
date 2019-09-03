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
            Console.WriteLine("nhap so 1");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so 2");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("so thu 1 :" + number1 + "\nso thu 2 :" + number2);

        }
    }
}
