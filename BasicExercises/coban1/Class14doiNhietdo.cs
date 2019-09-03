using System;
using System.Collections.Generic;
using System.Text;

namespace coban1
{
    class Class14doiNhietdo
    {
        static void Main()
        {
            float number;
            Console.WriteLine("nhap nhiet do C: ");
            number = float.Parse(Console.ReadLine());
            Console.WriteLine("Kelvin = {0}", number + 273);
            Console.WriteLine("Fahrenheit  = {0}", number * 18 / 10 + 32);
        }
    }
}
