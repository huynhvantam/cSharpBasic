using System;
using System.Collections.Generic;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aaaaaaaaaa");
            List<Shape> recList = new List<Shape>();
            var shape1 = new Shape();
            Rectangle shape2 = new Rectangle();
            Shape shape3 = new Rectangle();
            recList.Add(shape2);
            shape2.Side1 = 10;
            shape2.Side2 = 15;
            foreach (var rec in recList)
            {
                rec.ToString();
            }
            Console.ReadKey();
        }
    }
}
